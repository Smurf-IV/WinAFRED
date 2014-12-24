using System;
using System.IO;

namespace Thirdparty
{
   /// <summary>
   /// Stolen from http://stackoverflow.com/questions/3240968/should-dispose-or-finalize-be-used-to-delete-temporary-files
   /// and then had some modifications to allow attributes and filestream usage
   /// </summary>
   /// <example>
   /// using (TemporaryDirectory temporaryDir = new TemporaryDirectory(true)) 
   /// { 
   ///    temporaryDir.Keep = true; 
   /// }
   /// </example>
   public class TemporaryDirectory : IDisposable
   {
      private bool isDisposed;

      /// <summary>
      /// If you decide, after constructing a TemporaryFile, that you want to prevent it from being deleted, 
      /// simply set the TemporaryFile.Keep property to true:
      /// </summary>
// ReSharper disable MemberCanBePrivate.Global
      public bool Keep { get; set; }
// ReSharper restore MemberCanBePrivate.Global

      /// <summary>
      /// Accessor for the generated filePathName
      /// </summary>
      public DirectoryInfo IO { get; private set; }

      /// <summary>
      /// Default constructor
      /// </summary>
      public TemporaryDirectory()
         : this(Path.GetTempPath(), Guid.NewGuid().ToString())
      {
      }

      /// <summary>
      /// Constructor for the in memory cache version
      /// </summary>
      public TemporaryDirectory(string targetDirectory, string directoryName)
      {
         IO = CreateTemporaryDirectory(directoryName, new DirectoryInfo(targetDirectory));
      }

      /// <summary>
      /// Use C# destructor syntax for finalization code.
      /// This destructor will run only if the Dispose method does not get called.
      /// It gives your base class the opportunity to finalize.
      /// Do not provide destructors in types derived from this class.      
      /// </summary>
      ~TemporaryDirectory()
      {
         Dispose(false);
      }

      public void Dispose()
      {
         Dispose(true);
         // This object will be cleaned up by the Dispose method.
         // Therefore, you should call GC.SupressFinalize to take this object 
         // off the finalization queue and prevent finalization code for this 
         // object from executing a second time.
         GC.SuppressFinalize(this);
      }

      /// <summary>
      /// Dispose(bool disposing) executes in two distinct scenarios.
      /// If disposing equals true, the method has been called directly
      /// or indirectly by a user's code. Managed and unmanaged resources
      /// can be disposed.
      /// If disposing equals false, the method has been called by the
      /// runtime from inside the finalizer and you should not reference
      /// other objects. Only unmanaged resources can be disposed.
      /// </summary>
      /// <param name="disposing"></param>
      private void Dispose(bool disposing)
      {
         if (!isDisposed)
         {
            isDisposed = true;

            if (!Keep)
            {
               TryDelete();
            }
         }
      }

      private void TryDelete()
      {
         try
         {
            if (IO != null)
            {
               IO.Delete(true);
            }
         }
         catch (IOException)
         {
         }
         catch (UnauthorizedAccessException)
         {
         }
      }

      /// <summary>
      /// Use this in an attempt to cache in memory.
      /// </summary>
      /// <param name="directoryName"> </param>
      /// <param name="di"> </param>
      /// <returns>newInfo</returns>
      private static DirectoryInfo CreateTemporaryDirectory(string directoryName, DirectoryInfo di)
      {
         DirectoryInfo newInfo = di.CreateSubdirectory(directoryName);
         FileAttributes attributes = newInfo.Attributes;
         attributes |= FileAttributes.NotContentIndexed;
         newInfo.Attributes = attributes;

         return newInfo;
      }
   }
}
