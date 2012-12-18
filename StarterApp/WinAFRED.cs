#region Copyright (C)
// ---------------------------------------------------------------------------------------------------------------
//  <copyright file="WinaFred.cs" company="Smurf-IV">
// 
//  Copyright (C) 2011-2012 Smurf-IV
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 2 of the License, or
//   any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program. If not, see http://www.gnu.org/licenses/.
//  </copyright>
//  <summary>
//  Url: http://WinAFRED.codeplex.com/
//  Email: http://www.codeplex.com/site/users/view/smurfiv
//  </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Elucidate;
using LiquesceSvc;
using NLog;

namespace StarterApp
{
   public partial class WinAFRED : Form
   {
      static private readonly Logger Log = LogManager.GetCurrentClassLogger();
      public WinAFRED()
      {
         InitializeComponent();
         // Need to place this here, because everytime the designer does something it removes the list.
         // This is due to the 1 or more menu items haveing a font attribute.. Silly designer.
         menuStrip1.Items.AddRange(new ToolStripItem[] {
            suggestAScenarioToolStripMenuItem,
            versionNumberToolStripMenuItem,
            helpToolStripMenuItem
         });

         versionNumberToolStripMenuItem.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
         if (Properties.Settings.Default.UpdateRequired)
         {
            // Thanks go to http://cs.rthand.com/blogs/blog_with_righthand/archive/2005/12/09/246.aspx
            Properties.Settings.Default.Upgrade();
            Properties.Settings.Default.UpdateRequired = false;
            Properties.Settings.Default.Save();
         }
         WindowLocation.GeometryFromString(Properties.Settings.Default.WindowLocation, this);
      }

      private void suggestAScenarioToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start(@"http://winafred.codeplex.com/discussions");
      }

      private void versionNumberToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start(@"ChangeLog.rtf");
      }

      private void helpToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Process.Start(@"http://winafred.codeplex.com/documentation");
      }

      private void btnTargetDirectoryChoose_Click(object sender, EventArgs e)
      {
         using (FolderBrowserDialog fbd = new FolderBrowserDialog())
         {
            fbd.SelectedPath = Path.GetFullPath(targetDirectory.Text);
            Log.Info("targetDirectory from [{0}]", fbd.RootFolder);
            if (DialogResult.OK == fbd.ShowDialog())
            {
               targetDirectory.Text = Path.GetFullPath(fbd.SelectedPath);
            }
         }
      }

      private void targetDirectory_TextChanged(object sender, EventArgs e)
      {
         ValidateData();
      }

      private bool ValidateData()
      {
         errorProvider1.Clear();
         bool isValid = true;
         if (!Directory.Exists(targetDirectory.Text))
         {
            isValid = false;
            errorProvider1.SetError(targetDirectory, "Directory Not found");
         }
         return isValid;
      }

      #region DLL Imports

      [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.Winapi)]
      [return: MarshalAs(UnmanagedType.Bool)]
      private static extern bool GetDiskFreeSpaceExW(string lpDirectoryName, out ulong lpFreeBytesAvailable,
         out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

      [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
      [return: MarshalAs(UnmanagedType.Bool)]
      private static extern bool GetVolumeNameForVolumeMountPointW(string lpszVolumeMountPoint, [Out] StringBuilder lpszVolumeName,
         uint cchBufferLength);

      #endregion

      public static string GetVolumeName(string MountPoint)
      {
         const int MaxVolumeNameLength = 100;
         StringBuilder sb = new StringBuilder(MaxVolumeNameLength);
         if (!GetVolumeNameForVolumeMountPointW(MountPoint, sb, (uint)MaxVolumeNameLength))
            Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
         return sb.ToString();
      }

      static public string GetRootOrMountFor(string path)
      {
         do
         {
            NativeFileOps dirInfo = new NativeFileOps(path);
            FileAttributes attr = dirInfo.Attributes;
            if ((attr & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
            {
               char ch = path[path.Length - 1];
               if ((ch != Path.DirectorySeparatorChar)
                  && (ch != Path.AltDirectorySeparatorChar)
                  && (ch != Path.VolumeSeparatorChar)
                  )
                  path += Path.DirectorySeparatorChar;
               const int MaxVolumeNameLength = 250;
               StringBuilder sb = new StringBuilder(MaxVolumeNameLength);
               if (GetVolumeNameForVolumeMountPointW(path, sb, (uint)MaxVolumeNameLength))
                  return sb.ToString();
            }
            DirectoryInfo tmp = Directory.GetParent(path);
            if ( tmp == null )
               return path;
            path = tmp.FullName;
         } while (!string.IsNullOrEmpty(path));
         return path;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         string mount = @"C:\C-Mounted\C-Mounted\tes";
         //string mount = @"C:\C-Mounted";
         NativeFileOps dirInfo = new NativeFileOps(mount);
         FileAttributes attr = dirInfo.Attributes;
         MessageBox.Show(this, attr.ToString());
         string MountPoint = GetRootOrMountFor(mount);
         ulong localFreeBytesAvailable = 0, localTotalBytes = 0, localTotalFreeBytes = 0;
            ulong num;
            ulong num2;
            ulong num3;
            if (GetDiskFreeSpaceExW(MountPoint, out num, out num2, out num3))
            {
               localFreeBytesAvailable += num;
               localTotalBytes += num2;
               localTotalFreeBytes += num3;
            }

         NativeFileOps dirInfo2 = new NativeFileOps(@"C:\");

            string MountPoint2 = GetVolumeName(mount + @"tes\");
            string MountPoint3 = GetVolumeName(@"C:\");
         //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\C-Mounted");
         //try
         //{
         //   ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskPartition");
         //   StringBuilder str = new StringBuilder();
         //   foreach (ManagementObject queryObj in searcher.Get())
         //   {
         //      str.AppendFormat("Type: {0}", queryObj["Type"]).AppendLine();
         //   }
         //   MessageBox.Show(this, str.ToString());
         //}
         //catch (ManagementException ex)
         //{
         //   MessageBox.Show("An error occurred while querying for WMI data: " + ex.Message);
         //}
      }

      /// <summary>
      /// Perform the tidy ups
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void WinAFRED_FormClosing(object sender, FormClosingEventArgs e)
      {
         // persist our geometry string.
         Properties.Settings.Default.WindowLocation = WindowLocation.GeometryToString(this);
         Properties.Settings.Default.Save();

         removeFiles_Click(sender, e);
         removeDirectories_Click(sender, e);
      }

      private Stopwatch stopWatch;
      private void StartProcessing()
      {
         currentProcessing.Clear();
         UseWaitCursor = true;
         Enabled = false;
         stopWatch = Stopwatch.StartNew();
      }

      private void EndProcessing()
      {
         stopWatch.Stop();
         Enabled = true;
         UseWaitCursor = false;
         progressBar1.Value = 0;
         // Get the elapsed time as a TimeSpan value.
         timeTaken.Text = string.Format("{0:c}", stopWatch.Elapsed);
      }

      private void timer1_Tick(object sender, EventArgs e)
      {
         try
         {
            if (logs.Count <= 0)
               return;
            // Now lock in case the timer is overlapping !
            lock (logs)
            {
               currentProcessing._Paint = false; // turn off flag to ignore WM_PAINT messages
               //read out of the file until the EOF
               while (logs.Count > 0)
               {
                  int textLength = textBox1.TextLength;
                  textBox1.Select(textLength, 0);
                  LogString log = logs.Dequeue();
                  switch (log.LevelUppercase)
                  {
                     case "FATAL":
                        currentProcessing.SelectionColor = Color.DarkViolet;
                        break;
                     case "ERROR":
                        currentProcessing.SelectionColor = Color.Red;
                        break;
                     case "WARN":
                        currentProcessing.SelectionColor = Color.RoyalBlue;
                        break;
                     case "INFO":
                        currentProcessing.SelectionColor = Color.Black;
                        break;
                     case "DEBUG":
                        currentProcessing.SelectionColor = Color.DarkGray;
                        break;
                     case "TRACE":
                        currentProcessing.SelectionColor = Color.DimGray;
                        break;
                     default:
                        // Leave it as is
                        break;
                  }
                  currentProcessing.AppendText(log.Message + Environment.NewLine);
               }
            }
         }
         catch { }
         currentProcessing._Paint = true;// restore flag so we can paint the control
      }

      private class LogString
      {
         public string LevelUppercase;
         public string Message;
      };

      static private readonly Queue<LogString> logs = new Queue<LogString>();
      public static void LogMethod(string levelUppercase, string message)
      {
         logs.Enqueue(new LogString
         {
            LevelUppercase = levelUppercase,
            Message = message
         });
      }


   }
}
