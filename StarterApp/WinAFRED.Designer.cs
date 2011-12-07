﻿namespace StarterApp
{
   partial class WinAFRED
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAFRED));
         this.label1 = new System.Windows.Forms.Label();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.targetDirectory = new System.Windows.Forms.TextBox();
         this.btnTargetDirectoryChoose = new System.Windows.Forms.Button();
         this.shortNamesOnly = new System.Windows.Forms.CheckBox();
         this.directoryDepth = new System.Windows.Forms.NumericUpDown();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.numberOfFiles = new System.Windows.Forms.NumericUpDown();
         this.fileSizeKB = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.incrementSizeKB = new System.Windows.Forms.NumericUpDown();
         this.label5 = new System.Windows.Forms.Label();
         this.ignoreDriveSpace = new System.Windows.Forms.CheckBox();
         this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.btnBreadStart = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.tabLoaves = new System.Windows.Forms.TabPage();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.btnSlicedBreadStart = new System.Windows.Forms.Button();
         this.label8 = new System.Windows.Forms.Label();
         this.pooledThreads = new System.Windows.Forms.NumericUpDown();
         this.button1 = new System.Windows.Forms.Button();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         this.tabBread = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.label9 = new System.Windows.Forms.Label();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.tabSlicedBread = new System.Windows.Forms.TabPage();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.imageTabList = new System.Windows.Forms.ImageList(this.components);
         this.currentProcessing = new System.Windows.Forms.DataGridView();
         this.IconState = new System.Windows.Forms.DataGridViewImageColumn();
         this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.suggestAScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.versionNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         ((System.ComponentModel.ISupportInitialize)(this.directoryDepth)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numberOfFiles)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.fileSizeKB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.incrementSizeKB)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.tabLoaves.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pooledThreads)).BeginInit();
         this.tabBread.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabSlicedBread.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.currentProcessing)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 40);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(62, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "&Start Point:";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.toolTip1.SetToolTip(this.label1, "What location do you want the tests to run against.");
         // 
         // targetDirectory
         // 
         this.targetDirectory.Location = new System.Drawing.Point(77, 37);
         this.targetDirectory.Name = "targetDirectory";
         this.targetDirectory.Size = new System.Drawing.Size(431, 21);
         this.targetDirectory.TabIndex = 1;
         this.toolTip1.SetToolTip(this.targetDirectory, "What location do you want the tests to run against.");
         // 
         // btnTargetDirectoryChoose
         // 
         this.btnTargetDirectoryChoose.Location = new System.Drawing.Point(514, 35);
         this.btnTargetDirectoryChoose.Name = "btnTargetDirectoryChoose";
         this.btnTargetDirectoryChoose.Size = new System.Drawing.Size(33, 23);
         this.btnTargetDirectoryChoose.TabIndex = 2;
         this.btnTargetDirectoryChoose.Text = "...";
         this.toolTip1.SetToolTip(this.btnTargetDirectoryChoose, "What location do you want the tests to run against.");
         this.btnTargetDirectoryChoose.UseVisualStyleBackColor = true;
         // 
         // shortNamesOnly
         // 
         this.shortNamesOnly.AutoSize = true;
         this.shortNamesOnly.Location = new System.Drawing.Point(625, 40);
         this.shortNamesOnly.Name = "shortNamesOnly";
         this.shortNamesOnly.Size = new System.Drawing.Size(112, 17);
         this.shortNamesOnly.TabIndex = 3;
         this.shortNamesOnly.Text = "Short &Names Only";
         this.toolTip1.SetToolTip(this.shortNamesOnly, "Only use 8.3 naming convention");
         this.shortNamesOnly.UseVisualStyleBackColor = true;
         // 
         // directoryDepth
         // 
         this.directoryDepth.Location = new System.Drawing.Point(119, 19);
         this.directoryDepth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.directoryDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.directoryDepth.Name = "directoryDepth";
         this.directoryDepth.Size = new System.Drawing.Size(120, 21);
         this.directoryDepth.TabIndex = 0;
         this.directoryDepth.ThousandsSeparator = true;
         this.toolTip1.SetToolTip(this.directoryDepth, "Number of Directories to create");
         this.directoryDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 18);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(83, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "&Directory Depth";
         this.toolTip1.SetToolTip(this.label2, "Number of Directories to create");
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 87);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(83, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Number &Of Files";
         this.toolTip1.SetToolTip(this.label3, "How many files to create in each directory");
         // 
         // numberOfFiles
         // 
         this.numberOfFiles.Location = new System.Drawing.Point(119, 88);
         this.numberOfFiles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.numberOfFiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numberOfFiles.Name = "numberOfFiles";
         this.numberOfFiles.Size = new System.Drawing.Size(120, 21);
         this.numberOfFiles.TabIndex = 3;
         this.toolTip1.SetToolTip(this.numberOfFiles, "How many files to create in each directory");
         this.numberOfFiles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // fileSizeKB
         // 
         this.fileSizeKB.Location = new System.Drawing.Point(119, 127);
         this.fileSizeKB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.fileSizeKB.Name = "fileSizeKB";
         this.fileSizeKB.Size = new System.Drawing.Size(120, 21);
         this.fileSizeKB.TabIndex = 5;
         this.toolTip1.SetToolTip(this.fileSizeKB, "Initial File Size (KB)");
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 126);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(68, 13);
         this.label4.TabIndex = 4;
         this.label4.Text = "&File Size (KB)";
         this.toolTip1.SetToolTip(this.label4, "Initial File Size (KB)");
         // 
         // incrementSizeKB
         // 
         this.incrementSizeKB.Location = new System.Drawing.Point(119, 164);
         this.incrementSizeKB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.incrementSizeKB.Name = "incrementSizeKB";
         this.incrementSizeKB.Size = new System.Drawing.Size(120, 21);
         this.incrementSizeKB.TabIndex = 7;
         this.toolTip1.SetToolTip(this.incrementSizeKB, "Initial File Size (KB)");
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(9, 163);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(101, 13);
         this.label5.TabIndex = 6;
         this.label5.Text = "&Increment Size (KB)";
         this.toolTip1.SetToolTip(this.label5, "Increment File Size (KB)");
         // 
         // ignoreDriveSpace
         // 
         this.ignoreDriveSpace.AutoSize = true;
         this.ignoreDriveSpace.Location = new System.Drawing.Point(11, 199);
         this.ignoreDriveSpace.Name = "ignoreDriveSpace";
         this.ignoreDriveSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
         this.ignoreDriveSpace.Size = new System.Drawing.Size(124, 17);
         this.ignoreDriveSpace.TabIndex = 12;
         this.ignoreDriveSpace.Text = "Ignore &Target Space";
         this.toolTip1.SetToolTip(this.ignoreDriveSpace, "Allow to start if the reported drive space is less than the above.");
         this.ignoreDriveSpace.UseVisualStyleBackColor = true;
         // 
         // maskedTextBox1
         // 
         this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.maskedTextBox1.Location = new System.Drawing.Point(515, 421);
         this.maskedTextBox1.Mask = "00:00:0000";
         this.maskedTextBox1.Name = "maskedTextBox1";
         this.maskedTextBox1.ReadOnly = true;
         this.maskedTextBox1.Size = new System.Drawing.Size(67, 21);
         this.maskedTextBox1.TabIndex = 14;
         this.maskedTextBox1.Text = "12345678";
         this.toolTip1.SetToolTip(this.maskedTextBox1, "Min:Sec:Milli");
         // 
         // label6
         // 
         this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(389, 424);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(120, 13);
         this.label6.TabIndex = 13;
         this.label6.Text = "Time Taken to complete";
         this.toolTip1.SetToolTip(this.label6, "Min:Sec:Milli");
         // 
         // btnBreadStart
         // 
         this.btnBreadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnBreadStart.Location = new System.Drawing.Point(285, 228);
         this.btnBreadStart.Name = "btnBreadStart";
         this.btnBreadStart.Size = new System.Drawing.Size(75, 23);
         this.btnBreadStart.TabIndex = 13;
         this.btnBreadStart.Text = "Start";
         this.toolTip1.SetToolTip(this.btnBreadStart, "Perform the scenario");
         this.btnBreadStart.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(12, 53);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(83, 13);
         this.label7.TabIndex = 16;
         this.label7.Text = "Directory &Count";
         this.toolTip1.SetToolTip(this.label7, "Number of Directories to create in each directory");
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(119, 54);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
         this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
         this.numericUpDown1.TabIndex = 15;
         this.numericUpDown1.ThousandsSeparator = true;
         this.toolTip1.SetToolTip(this.numericUpDown1, "Number of Directories to create in each directory");
         this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         // 
         // tabLoaves
         // 
         this.tabLoaves.Controls.Add(this.textBox2);
         this.tabLoaves.Controls.Add(this.btnSlicedBreadStart);
         this.tabLoaves.Controls.Add(this.label8);
         this.tabLoaves.Controls.Add(this.pooledThreads);
         this.tabLoaves.ImageIndex = 2;
         this.tabLoaves.Location = new System.Drawing.Point(4, 39);
         this.tabLoaves.Margin = new System.Windows.Forms.Padding(0);
         this.tabLoaves.Name = "tabLoaves";
         this.tabLoaves.Size = new System.Drawing.Size(363, 387);
         this.tabLoaves.TabIndex = 1;
         this.tabLoaves.Text = "Loaves";
         this.toolTip1.SetToolTip(this.tabLoaves, "Simultaneous BREAD");
         this.tabLoaves.ToolTipText = "Run the BREAD tests in sultaneous threads.";
         this.tabLoaves.UseVisualStyleBackColor = true;
         // 
         // textBox2
         // 
         this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox2.Location = new System.Drawing.Point(3, 251);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.ReadOnly = true;
         this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox2.Size = new System.Drawing.Size(356, 138);
         this.textBox2.TabIndex = 18;
         this.textBox2.Text = "Sliced BREAD = Simultaneous Browse Read Edit Add Delete\r\nThis test will \r\n- Perfo" +
    "rm the Tests from the B.R.E.A.D Page\r\n- And Run them in the number of threads sp" +
    "ecified (In .Net Thread pool)";
         // 
         // btnSlicedBreadStart
         // 
         this.btnSlicedBreadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnSlicedBreadStart.Location = new System.Drawing.Point(284, 222);
         this.btnSlicedBreadStart.Name = "btnSlicedBreadStart";
         this.btnSlicedBreadStart.Size = new System.Drawing.Size(75, 23);
         this.btnSlicedBreadStart.TabIndex = 17;
         this.btnSlicedBreadStart.Text = "Start";
         this.toolTip1.SetToolTip(this.btnSlicedBreadStart, "Perform the scenario");
         this.btnSlicedBreadStart.UseVisualStyleBackColor = true;
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(11, 12);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(81, 13);
         this.label8.TabIndex = 16;
         this.label8.Text = "&Pooled Threads";
         this.toolTip1.SetToolTip(this.label8, "Number of Threads in pool");
         // 
         // pooledThreads
         // 
         this.pooledThreads.Location = new System.Drawing.Point(118, 13);
         this.pooledThreads.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
         this.pooledThreads.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.pooledThreads.Name = "pooledThreads";
         this.pooledThreads.Size = new System.Drawing.Size(120, 21);
         this.pooledThreads.TabIndex = 15;
         this.pooledThreads.ThousandsSeparator = true;
         this.toolTip1.SetToolTip(this.pooledThreads, "Number of Threads in pool");
         this.pooledThreads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         // 
         // button1
         // 
         this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.button1.Location = new System.Drawing.Point(285, 228);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 15;
         this.button1.Text = "Start";
         this.toolTip1.SetToolTip(this.button1, "Perform the scenario");
         this.button1.UseVisualStyleBackColor = true;
         // 
         // tabBread
         // 
         this.tabBread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.tabBread.Controls.Add(this.tabPage1);
         this.tabBread.Controls.Add(this.tabSlicedBread);
         this.tabBread.Controls.Add(this.tabLoaves);
         this.tabBread.ImageList = this.imageTabList;
         this.tabBread.Location = new System.Drawing.Point(12, 63);
         this.tabBread.Name = "tabBread";
         this.tabBread.SelectedIndex = 0;
         this.tabBread.Size = new System.Drawing.Size(371, 430);
         this.tabBread.TabIndex = 6;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.label9);
         this.tabPage1.Controls.Add(this.textBox3);
         this.tabPage1.Controls.Add(this.button1);
         this.tabPage1.ImageIndex = 0;
         this.tabPage1.Location = new System.Drawing.Point(4, 39);
         this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Size = new System.Drawing.Size(363, 387);
         this.tabPage1.TabIndex = 2;
         this.tabPage1.Text = "B.R.E.A.D.";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(3, 18);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(217, 13);
         this.label9.TabIndex = 17;
         this.label9.Text = "Simple Tests to see if the Target is writable.";
         // 
         // textBox3
         // 
         this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox3.Location = new System.Drawing.Point(4, 257);
         this.textBox3.Multiline = true;
         this.textBox3.Name = "textBox3";
         this.textBox3.ReadOnly = true;
         this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox3.Size = new System.Drawing.Size(356, 138);
         this.textBox3.TabIndex = 16;
         this.textBox3.Text = "BREAD = Browse Read Edit Add Delete\r\nThis test will \r\n- Create a directory\r\n- Cre" +
    "ate a File (initial size 0 bytes)\r\n- Increase the file size contents and save\r\n-" +
    " Delete the above";
         // 
         // tabSlicedBread
         // 
         this.tabSlicedBread.Controls.Add(this.label7);
         this.tabSlicedBread.Controls.Add(this.numericUpDown1);
         this.tabSlicedBread.Controls.Add(this.textBox1);
         this.tabSlicedBread.Controls.Add(this.btnBreadStart);
         this.tabSlicedBread.Controls.Add(this.ignoreDriveSpace);
         this.tabSlicedBread.Controls.Add(this.incrementSizeKB);
         this.tabSlicedBread.Controls.Add(this.label5);
         this.tabSlicedBread.Controls.Add(this.fileSizeKB);
         this.tabSlicedBread.Controls.Add(this.label4);
         this.tabSlicedBread.Controls.Add(this.numberOfFiles);
         this.tabSlicedBread.Controls.Add(this.label3);
         this.tabSlicedBread.Controls.Add(this.label2);
         this.tabSlicedBread.Controls.Add(this.directoryDepth);
         this.tabSlicedBread.ImageIndex = 1;
         this.tabSlicedBread.Location = new System.Drawing.Point(4, 39);
         this.tabSlicedBread.Margin = new System.Windows.Forms.Padding(0);
         this.tabSlicedBread.Name = "tabSlicedBread";
         this.tabSlicedBread.Size = new System.Drawing.Size(363, 387);
         this.tabSlicedBread.TabIndex = 0;
         this.tabSlicedBread.Text = "Sliced BREAD";
         this.tabSlicedBread.ToolTipText = "BREAD = Browse Read Edit Add Delete";
         this.tabSlicedBread.UseVisualStyleBackColor = true;
         // 
         // textBox1
         // 
         this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.textBox1.Location = new System.Drawing.Point(4, 257);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBox1.Size = new System.Drawing.Size(356, 138);
         this.textBox1.TabIndex = 14;
         this.textBox1.Text = resources.GetString("textBox1.Text");
         // 
         // imageTabList
         // 
         this.imageTabList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageTabList.ImageStream")));
         this.imageTabList.TransparentColor = System.Drawing.Color.Transparent;
         this.imageTabList.Images.SetKeyName(0, "Bread.ico");
         this.imageTabList.Images.SetKeyName(1, "Sliced.ico");
         this.imageTabList.Images.SetKeyName(2, "loaves.ico");
         // 
         // currentProcessing
         // 
         this.currentProcessing.AllowUserToAddRows = false;
         this.currentProcessing.AllowUserToDeleteRows = false;
         this.currentProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.currentProcessing.BackgroundColor = System.Drawing.SystemColors.Control;
         this.currentProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.currentProcessing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IconState,
            this.Process,
            this.Status});
         this.currentProcessing.GridColor = System.Drawing.SystemColors.Control;
         this.currentProcessing.Location = new System.Drawing.Point(392, 85);
         this.currentProcessing.Name = "currentProcessing";
         this.currentProcessing.ReadOnly = true;
         this.currentProcessing.RowHeadersVisible = false;
         this.currentProcessing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.currentProcessing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.currentProcessing.Size = new System.Drawing.Size(418, 326);
         this.currentProcessing.TabIndex = 12;
         // 
         // IconState
         // 
         this.IconState.FillWeight = 50F;
         this.IconState.Frozen = true;
         this.IconState.HeaderText = "";
         this.IconState.MinimumWidth = 20;
         this.IconState.Name = "IconState";
         this.IconState.ReadOnly = true;
         this.IconState.Width = 50;
         // 
         // Process
         // 
         this.Process.HeaderText = "Process";
         this.Process.Name = "Process";
         this.Process.ReadOnly = true;
         this.Process.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // Status
         // 
         this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Status.HeaderText = "Status";
         this.Status.Name = "Status";
         this.Status.ReadOnly = true;
         this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // errorProvider1
         // 
         this.errorProvider1.ContainerControl = this;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(820, 24);
         this.menuStrip1.TabIndex = 15;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // suggestAScenarioToolStripMenuItem
         // 
         this.suggestAScenarioToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
         this.suggestAScenarioToolStripMenuItem.Name = "suggestAScenarioToolStripMenuItem";
         this.suggestAScenarioToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
         this.suggestAScenarioToolStripMenuItem.Text = "Suggest a Scenario";
         // 
         // versionNumberToolStripMenuItem
         // 
         this.versionNumberToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.versionNumberToolStripMenuItem.Enabled = false;
         this.versionNumberToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.versionNumberToolStripMenuItem.Name = "versionNumberToolStripMenuItem";
         this.versionNumberToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
         this.versionNumberToolStripMenuItem.Text = "Version Number";
         this.versionNumberToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // pictureBox1
         // 
         this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(677, 411);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 95);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 16;
         this.pictureBox1.TabStop = false;
         this.toolTip1.SetToolTip(this.pictureBox1, "Wina and Bread ambigram");
         // 
         // WinAFRED
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(820, 505);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.maskedTextBox1);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.currentProcessing);
         this.Controls.Add(this.shortNamesOnly);
         this.Controls.Add(this.tabBread);
         this.Controls.Add(this.btnTargetDirectoryChoose);
         this.Controls.Add(this.targetDirectory);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.menuStrip1);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.MinimizeBox = false;
         this.MinimumSize = new System.Drawing.Size(400, 200);
         this.Name = "WinAFRED";
         this.Text = "WinAFRED Tester";
         this.toolTip1.SetToolTip(this, "Windows Add File Read Edit Delete Tester");
         ((System.ComponentModel.ISupportInitialize)(this.directoryDepth)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numberOfFiles)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.fileSizeKB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.incrementSizeKB)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.tabLoaves.ResumeLayout(false);
         this.tabLoaves.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pooledThreads)).EndInit();
         this.tabBread.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabSlicedBread.ResumeLayout(false);
         this.tabSlicedBread.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.currentProcessing)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.TextBox targetDirectory;
      private System.Windows.Forms.Button btnTargetDirectoryChoose;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
      private System.Windows.Forms.TabControl tabBread;
      private System.Windows.Forms.TabPage tabSlicedBread;
      private System.Windows.Forms.TabPage tabLoaves;
      private System.Windows.Forms.NumericUpDown incrementSizeKB;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.NumericUpDown fileSizeKB;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.NumericUpDown numberOfFiles;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown directoryDepth;
      private System.Windows.Forms.CheckBox shortNamesOnly;
      private System.Windows.Forms.CheckBox ignoreDriveSpace;
      private System.Windows.Forms.MaskedTextBox maskedTextBox1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.DataGridView currentProcessing;
      private System.Windows.Forms.Button btnBreadStart;
      private System.Windows.Forms.ErrorProvider errorProvider1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button btnSlicedBreadStart;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.NumericUpDown pooledThreads;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ImageList imageTabList;
      private System.Windows.Forms.DataGridViewImageColumn IconState;
      private System.Windows.Forms.DataGridViewTextBoxColumn Process;
      private System.Windows.Forms.DataGridViewTextBoxColumn Status;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem versionNumberToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem suggestAScenarioToolStripMenuItem;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}
