#region Copyright (C)
// ---------------------------------------------------------------------------------------------------------------
//  <copyright file="AssemblyInfo.cs" company="Smurf-IV">
// 
//  Copyright (C) 2011 Smurf-IV
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StarterApp
{
   public partial class WinAFRED : Form
   {
      public WinAFRED()
      {
         InitializeComponent();
         // Need to place this here, because everytime the designer does something it removes the list.
         // This is due to the 1 or more menu items haveing a font attribute.. Silly designer.
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suggestAScenarioToolStripMenuItem,
            this.versionNumberToolStripMenuItem});
      }

   }
}
