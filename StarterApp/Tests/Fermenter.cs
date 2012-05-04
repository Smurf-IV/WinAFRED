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

namespace StarterApp.Tests
{
   internal static class Fermenter
   {
      private static readonly List<TemporaryFile> tempFiles = new List<TemporaryFile>();

      public static void CreateFiles(string targetDirectory, Int64 numberOfFiles)
      {
         tempFiles.Clear();
         for (Int64 i = 1; i <= numberOfFiles; i++)
         {
            tempFiles.Add(new TemporaryFile( targetDirectory, string.Format("{0:g8}.tmp",i), true));
         }
      }
   }
}
