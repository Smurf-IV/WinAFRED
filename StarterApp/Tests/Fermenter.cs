#region Copyright (C)
// ---------------------------------------------------------------------------------------------------------------
//  <copyright file="Fermenter.cs" company="Smurf-IV">
// 
//  Copyright (C) 2012 Smurf-IV
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
using Thirdparty;

namespace StarterApp
{
   partial class WinAFRED
   {
      private readonly List<TemporaryFile> tempFiles = new List<TemporaryFile>();

      private void fileStart_Click(object sender, EventArgs e)
      {
         try
         {
            StartProcessing();
            int newFiles = (int)fermenterFiles.Value;
            int count = tempFiles.Count;
            if (count > newFiles)
            {
               Log.Warn("Reducing the number of files down to [{0}]", newFiles);
               tempFiles.RemoveRange(newFiles, count - newFiles);
            }
            else if (count == newFiles)
               Log.Info("No Change - Already have this number of files");
            else
            {
               progressBar1.Maximum = newFiles;
               progressBar1.Value = count;
               for (int i = count + 1; i <= newFiles; i++)
               {
                  Log.Info("New file [{0}]", i);
                  progressBar1.PerformStep();
                  tempFiles.Add(new TemporaryFile(targetDirectory.Text, i+".tmp", true));
               }
            }
         }
         finally
         {
            EndProcessing();
         }
      }

      private void removeFiles_Click(object sender, EventArgs e)
      {
         try
         {
            StartProcessing();
            progressBar1.Value = progressBar1.Maximum = tempFiles.Count + 1;
            foreach (TemporaryFile tempFile in tempFiles)
            {
               Log.Info("Removing file [{0}]", tempFile.IO.Name);
               tempFile.Dispose();
               progressBar1.Increment(-1);
            }
            tempFiles.Clear();
         }
         finally
         {
            EndProcessing();
         }
      }

      private readonly List<TemporaryDirectory> tempDirs = new List<TemporaryDirectory>();

      private void dirStart_Click(object sender, EventArgs e)
      {
         try
         {
            StartProcessing();
            int newDirs = (int)fermenterDirectories.Value;
            int count = tempDirs.Count;
            if (count > newDirs)
            {
               Log.Warn("Reducing the number of directories down to [{0}]", newDirs);
               tempDirs.RemoveRange(newDirs, count - newDirs);
            }
            else if (count == newDirs)
               Log.Info("No Change - Already have this number of directories");
            else
            {
               progressBar1.Maximum = newDirs;
               progressBar1.Value = count;
               for (int i = count + 1; i <= newDirs; i++)
               {
                  Log.Info("New directory [{0}]", i);
                  progressBar1.PerformStep();
                  tempDirs.Add(new TemporaryDirectory(targetDirectory.Text, i+"tmp"));
               }
            }
         }
         finally
         {
            EndProcessing();
         }
      }


      private void removeDirectories_Click(object sender, EventArgs e)
      {
         try
         {
            StartProcessing();
            progressBar1.Value = progressBar1.Maximum = tempDirs.Count + 1;
            foreach (TemporaryDirectory tempDir in tempDirs)
            {
               Log.Info("Removing directory [{0}]", tempDir.IO.Name);
               progressBar1.Increment(-1);
               tempDir.Dispose();
            }
            tempDirs.Clear();
         }
         finally
         {
            EndProcessing();
         }
      }
   }
}
