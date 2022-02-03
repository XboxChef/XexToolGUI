using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace XexToolGUI
{
    partial class xexgui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xexgui));
            this.XLogBox = new System.Windows.Forms.TextBox();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.XeXFileTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SavePatchTextBox = new System.Windows.Forms.TextBox();
            this.XeXpFileTextBox = new System.Windows.Forms.TextBox();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SelectxexToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavexexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.CMDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HxDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WxPirsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.TitleUpdatesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.IdcFileForIDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DumbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
            this.HelpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
            this.BackupxexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PatchxexToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Clear2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripDropDownButton7 = new System.Windows.Forms.ToolStripDropDownButton();
            this.RegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathnameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyvaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RequiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZeroIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AP25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton8 = new System.Windows.Forms.ToolStripDropDownButton();
            this.RetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevkitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.UncryptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton9 = new System.Windows.Forms.ToolStripDropDownButton();
            this.XexBasicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XexExtendedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ReadInfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripDropDownButton10 = new System.Windows.Forms.ToolStripDropDownButton();
            this.UncompressedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompressedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenxexpButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.OpenxexButton = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip3.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // XLogBox
            // 
            this.XLogBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XLogBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLogBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.XLogBox.Location = new System.Drawing.Point(15, 19);
            this.XLogBox.Multiline = true;
            this.XLogBox.Name = "XLogBox";
            this.XLogBox.ReadOnly = true;
            this.XLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.XLogBox.Size = new System.Drawing.Size(408, 136);
            this.XLogBox.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.XLogBox, "xextool process log window");
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(15, 161);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(408, 15);
            this.ProgressBar1.TabIndex = 1;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(27, 269);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(79, 17);
            this.CheckBox1.TabIndex = 2;
            this.CheckBox1.Text = "Detaild log ";
            this.ToolTip1.SetToolTip(this.CheckBox1, "better information about the process");
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ProgressBar1);
            this.GroupBox1.Controls.Add(this.XLogBox);
            this.GroupBox1.Location = new System.Drawing.Point(12, 64);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(443, 192);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Xex";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(125, 263);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(268, 26);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "The program runs in the background when it is finished \r\nor an error in the log w" +
    "indow appears.      (ca. 1.min)\r\n";
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // XeXFileTextBox
            // 
            this.XeXFileTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.XeXFileTextBox.Location = new System.Drawing.Point(46, 45);
            this.XeXFileTextBox.Name = "XeXFileTextBox";
            this.XeXFileTextBox.Size = new System.Drawing.Size(301, 20);
            this.XeXFileTextBox.TabIndex = 20;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // SavePatchTextBox
            // 
            this.SavePatchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SavePatchTextBox.Location = new System.Drawing.Point(46, 153);
            this.SavePatchTextBox.Name = "SavePatchTextBox";
            this.SavePatchTextBox.Size = new System.Drawing.Size(301, 20);
            this.SavePatchTextBox.TabIndex = 22;
            // 
            // XeXpFileTextBox
            // 
            this.XeXpFileTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.XeXpFileTextBox.Location = new System.Drawing.Point(46, 99);
            this.XeXpFileTextBox.Name = "XeXpFileTextBox";
            this.XeXpFileTextBox.Size = new System.Drawing.Size(301, 20);
            this.XeXpFileTextBox.TabIndex = 21;
            // 
            // ImageList1
            // 
            this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // OpenFileDialog2
            // 
            this.OpenFileDialog2.Filter = "xexp File|*.xexp";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton2,
            this.ToolStripDropDownButton4,
            this.ToolStripDropDownButton5,
            this.ToolStripDropDownButton6});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip1.Size = new System.Drawing.Size(468, 25);
            this.ToolStrip1.TabIndex = 29;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripDropDownButton2
            // 
            this.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectxexToolStripMenuItem1,
            this.SelectToolStripMenuItem,
            this.SavexexToolStripMenuItem,
            this.ClearToolStripMenuItem1,
            this.ExitToolStripMenuItem2});
            this.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2";
            this.ToolStripDropDownButton2.Size = new System.Drawing.Size(38, 22);
            this.ToolStripDropDownButton2.Text = "File";
            this.ToolStripDropDownButton2.ToolTipText = "Option";
            // 
            // SelectxexToolStripMenuItem1
            // 
            this.SelectxexToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.SelectxexToolStripMenuItem1_Image;
            this.SelectxexToolStripMenuItem1.Name = "SelectxexToolStripMenuItem1";
            this.SelectxexToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.SelectxexToolStripMenuItem1.Text = "Select xex";
            this.SelectxexToolStripMenuItem1.ToolTipText = "Open xex file";
            this.SelectxexToolStripMenuItem1.Click += new System.EventHandler(this.SelectxexToolStripMenuItem1_Click);
            // 
            // SelectToolStripMenuItem
            // 
            this.SelectToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.SelectToolStripMenuItem_Image;
            this.SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            this.SelectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SelectToolStripMenuItem.Text = "Select xexp";
            this.SelectToolStripMenuItem.ToolTipText = "Open xexp file";
            this.SelectToolStripMenuItem.Click += new System.EventHandler(this.SelectToolStripMenuItem_Click);
            // 
            // SavexexToolStripMenuItem
            // 
            this.SavexexToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.SavexexToolStripMenuItem_Image;
            this.SavexexToolStripMenuItem.Name = "SavexexToolStripMenuItem";
            this.SavexexToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SavexexToolStripMenuItem.Text = "Save As";
            this.SavexexToolStripMenuItem.ToolTipText = "Save file";
            // 
            // ClearToolStripMenuItem1
            // 
            this.ClearToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.Clear2ToolStripButton_Image;
            this.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1";
            this.ClearToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.ClearToolStripMenuItem1.Text = "Clear";
            this.ClearToolStripMenuItem1.ToolTipText = "Clear all Box";
            this.ClearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem1_Click);
            // 
            // ExitToolStripMenuItem2
            // 
            this.ExitToolStripMenuItem2.Image = global::XexToolGUI.Properties.Resources.ExitToolStripMenuItem_Image;
            this.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2";
            this.ExitToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.ExitToolStripMenuItem2.Text = "Exit";
            this.ExitToolStripMenuItem2.ToolTipText = "Close App";
            this.ExitToolStripMenuItem2.Click += new System.EventHandler(this.ExitToolStripMenuItem2_Click);
            // 
            // ToolStripDropDownButton4
            // 
            this.ToolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMDToolStripMenuItem,
            this.HxDToolStripMenuItem1,
            this.WxPirsToolStripMenuItem});
            this.ToolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton4.Name = "ToolStripDropDownButton4";
            this.ToolStripDropDownButton4.Size = new System.Drawing.Size(40, 22);
            this.ToolStripDropDownButton4.Text = "Edit";
            // 
            // CMDToolStripMenuItem
            // 
            this.CMDToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.CMDToolStripMenuItem_Image;
            this.CMDToolStripMenuItem.Name = "CMDToolStripMenuItem";
            this.CMDToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.CMDToolStripMenuItem.Text = "CMD";
            this.CMDToolStripMenuItem.ToolTipText = "xextool.exe run from the command line";
            this.CMDToolStripMenuItem.Click += new System.EventHandler(this.CMDToolStripMenuItem_Click);
            // 
            // HxDToolStripMenuItem1
            // 
            this.HxDToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.HxDToolStripMenuItem1_Image;
            this.HxDToolStripMenuItem1.Name = "HxDToolStripMenuItem1";
            this.HxDToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.HxDToolStripMenuItem1.Text = "HxD";
            this.HxDToolStripMenuItem1.ToolTipText = "Hex Editor";
            this.HxDToolStripMenuItem1.Visible = false;
            this.HxDToolStripMenuItem1.Click += new System.EventHandler(this.HxDToolStripMenuItem1_Click);
            // 
            // WxPirsToolStripMenuItem
            // 
            this.WxPirsToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.WxPirsToolStripMenuItem_Image;
            this.WxPirsToolStripMenuItem.Name = "WxPirsToolStripMenuItem";
            this.WxPirsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.WxPirsToolStripMenuItem.Text = "wxPirs";
            this.WxPirsToolStripMenuItem.ToolTipText = "Extract Live, Pirs files";
            this.WxPirsToolStripMenuItem.Visible = false;
            this.WxPirsToolStripMenuItem.Click += new System.EventHandler(this.WxPirsToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton5
            // 
            this.ToolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitleUpdatesToolStripMenuItem1,
            this.IdcFileForIDAToolStripMenuItem,
            this.XMLToolStripMenuItem,
            this.DumbToolStripMenuItem});
            this.ToolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton5.Name = "ToolStripDropDownButton5";
            this.ToolStripDropDownButton5.Size = new System.Drawing.Size(46, 22);
            this.ToolStripDropDownButton5.Text = "Extra";
            // 
            // TitleUpdatesToolStripMenuItem1
            // 
            this.TitleUpdatesToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.TitleUpdatesToolStripMenuItem1_Image;
            this.TitleUpdatesToolStripMenuItem1.Name = "TitleUpdatesToolStripMenuItem1";
            this.TitleUpdatesToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.TitleUpdatesToolStripMenuItem1.Text = "Title Updates";
            this.TitleUpdatesToolStripMenuItem1.ToolTipText = "Search Game Updates ";
            this.TitleUpdatesToolStripMenuItem1.Click += new System.EventHandler(this.TitleUpdatesToolStripMenuItem1_Click);
            // 
            // IdcFileForIDAToolStripMenuItem
            // 
            this.IdcFileForIDAToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.IdcFileForIDAToolStripMenuItem_Image;
            this.IdcFileForIDAToolStripMenuItem.Name = "IdcFileForIDAToolStripMenuItem";
            this.IdcFileForIDAToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.IdcFileForIDAToolStripMenuItem.Text = "IDC";
            this.IdcFileForIDAToolStripMenuItem.ToolTipText = "Create idc file for IDA";
            this.IdcFileForIDAToolStripMenuItem.Click += new System.EventHandler(this.IdcFileForIDAToolStripMenuItem_Click);
            // 
            // XMLToolStripMenuItem
            // 
            this.XMLToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.XMLToolStripMenuItem_Image;
            this.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem";
            this.XMLToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.XMLToolStripMenuItem.Text = "XML ";
            this.XMLToolStripMenuItem.Visible = false;
            this.XMLToolStripMenuItem.Click += new System.EventHandler(this.XMLToolStripMenuItem_Click);
            // 
            // DumbToolStripMenuItem
            // 
            this.DumbToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.DumbToolStripMenuItem_Image;
            this.DumbToolStripMenuItem.Name = "DumbToolStripMenuItem";
            this.DumbToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DumbToolStripMenuItem.Text = "Dump";
            this.DumbToolStripMenuItem.ToolTipText = "Dump an xex file";
            this.DumbToolStripMenuItem.Click += new System.EventHandler(this.DumbToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton6
            // 
            this.ToolStripDropDownButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem2,
            this.HelpToolStripMenuItem,
            this.InfoToolStripMenuItem2,
            this.AboutToolStripMenuItem1});
            this.ToolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton6.Name = "ToolStripDropDownButton6";
            this.ToolStripDropDownButton6.Size = new System.Drawing.Size(45, 22);
            this.ToolStripDropDownButton6.Text = "Help";
            // 
            // HelpToolStripMenuItem2
            // 
            this.HelpToolStripMenuItem2.Image = global::XexToolGUI.Properties.Resources.HelpToolStripMenuItem2_Image;
            this.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2";
            this.HelpToolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.HelpToolStripMenuItem2.Text = "Help";
            this.HelpToolStripMenuItem2.Click += new System.EventHandler(this.HelpToolStripMenuItem2_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.HelpToolStripMenuItem_Image;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.HelpToolStripMenuItem.Text = "Help  reverse engineer";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem2
            // 
            this.InfoToolStripMenuItem2.Image = global::XexToolGUI.Properties.Resources.XexBasicToolStripMenuItem_Image;
            this.InfoToolStripMenuItem2.Name = "InfoToolStripMenuItem2";
            this.InfoToolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.InfoToolStripMenuItem2.Text = "Info";
            this.InfoToolStripMenuItem2.Click += new System.EventHandler(this.InfoToolStripMenuItem2_Click);
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.AboutToolStripMenuItem1_Image;
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.AboutToolStripMenuItem1.Text = "About GUI";
            this.AboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.ToolStripLabel1.Text = "Help";
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.InfoToolStripMenuItem.Text = "Info";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // OpenFileDialog3
            // 
            this.OpenFileDialog3.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "XexTool MiniGUI";
            this.NotifyIcon1.Visible = true;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 502);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(468, 22);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 30;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.AutoSize = false;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.ToolStripStatusLabel1.Text = "v1.7 Beta";
            // 
            // ToolStrip3
            // 
            this.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupxexToolStripButton,
            this.ToolStripSeparator2,
            this.PatchxexToolStripButton,
            this.ToolStripSeparator3,
            this.Clear2ToolStripButton,
            this.ToolStripSeparator5,
            this.ToolStripDropDownButton7,
            this.ToolStripDropDownButton8,
            this.ToolStripDropDownButton3,
            this.ToolStripDropDownButton9,
            this.ToolStripSeparator1,
            this.ReadInfoToolStripButton,
            this.ToolStripDropDownButton10});
            this.ToolStrip3.Location = new System.Drawing.Point(0, 25);
            this.ToolStrip3.Name = "ToolStrip3";
            this.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip3.Size = new System.Drawing.Size(468, 25);
            this.ToolStrip3.TabIndex = 31;
            this.ToolStrip3.Text = "ToolStrip3";
            // 
            // BackupxexToolStripButton
            // 
            this.BackupxexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackupxexToolStripButton.Image = global::XexToolGUI.Properties.Resources.BackupxexToolStripButton_Image;
            this.BackupxexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackupxexToolStripButton.Name = "BackupxexToolStripButton";
            this.BackupxexToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BackupxexToolStripButton.Text = "Backup from a xex file";
            this.BackupxexToolStripButton.ToolTipText = "Backup a xex file";
            this.BackupxexToolStripButton.Click += new System.EventHandler(this.BackupxexToolStripButton_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PatchxexToolStripButton
            // 
            this.PatchxexToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PatchxexToolStripButton.Image = global::XexToolGUI.Properties.Resources.PatchxexToolStripButton_Image;
            this.PatchxexToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PatchxexToolStripButton.Name = "PatchxexToolStripButton";
            this.PatchxexToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PatchxexToolStripButton.Text = "Patch a xex file with xexp file";
            this.PatchxexToolStripButton.ToolTipText = "Patch xex file with xexp file";
            this.PatchxexToolStripButton.Click += new System.EventHandler(this.PatchxexToolStripButton_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Clear2ToolStripButton
            // 
            this.Clear2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Clear2ToolStripButton.Image = global::XexToolGUI.Properties.Resources.Clear2ToolStripButton_Image;
            this.Clear2ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear2ToolStripButton.Name = "Clear2ToolStripButton";
            this.Clear2ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Clear2ToolStripButton.Text = "Clear";
            this.Clear2ToolStripButton.Click += new System.EventHandler(this.Clear2ToolStripButton_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripDropDownButton7
            // 
            this.ToolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegionToolStripMenuItem,
            this.MediaToolStripMenuItem,
            this.DashToolStripMenuItem,
            this.PathnameToolStripMenuItem,
            this.KeyvaultToolStripMenuItem,
            this.RequiredToolStripMenuItem,
            this.ZeroIDToolStripMenuItem,
            this.AP25ToolStripMenuItem});
            this.ToolStripDropDownButton7.Image = global::XexToolGUI.Properties.Resources.ExitToolStripMenuItem_Image;
            this.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7";
            this.ToolStripDropDownButton7.Size = new System.Drawing.Size(29, 22);
            this.ToolStripDropDownButton7.Text = "Remove xex limits";
            // 
            // RegionToolStripMenuItem
            // 
            this.RegionToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.RegionToolStripMenuItem_Image;
            this.RegionToolStripMenuItem.Name = "RegionToolStripMenuItem";
            this.RegionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.RegionToolStripMenuItem.Text = "Region";
            this.RegionToolStripMenuItem.ToolTipText = "Makes a Region Free file\r\n* Region limits limit what console regions an xex can b" +
    "e booted on.";
            this.RegionToolStripMenuItem.Click += new System.EventHandler(this.RegionToolStripMenuItem_Click);
            // 
            // MediaToolStripMenuItem
            // 
            this.MediaToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.MediaToolStripMenuItem_Image;
            this.MediaToolStripMenuItem.Name = "MediaToolStripMenuItem";
            this.MediaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.MediaToolStripMenuItem.Text = "Media";
            this.MediaToolStripMenuItem.ToolTipText = "Remove the media limits\r\n* Media limits limit what media the xex can be booted fr" +
    "om.";
            this.MediaToolStripMenuItem.Click += new System.EventHandler(this.MediaToolStripMenuItem_Click);
            // 
            // DashToolStripMenuItem
            // 
            this.DashToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.DashToolStripMenuItem_Image;
            this.DashToolStripMenuItem.Name = "DashToolStripMenuItem";
            this.DashToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.DashToolStripMenuItem.Text = "Dash";
            this.DashToolStripMenuItem.ToolTipText = "Remove Dashboard version\r\n* Minimum library versions require system dlls to be of" +
    " a specified\r\n  version of higher. The usual imports are from xboxkrnl.exe and x" +
    "am.exe.";
            this.DashToolStripMenuItem.Click += new System.EventHandler(this.DashToolStripMenuItem_Click);
            // 
            // PathnameToolStripMenuItem
            // 
            this.PathnameToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.PathnameToolStripMenuItem_Image;
            this.PathnameToolStripMenuItem.Name = "PathnameToolStripMenuItem";
            this.PathnameToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.PathnameToolStripMenuItem.Text = "Pathname";
            this.PathnameToolStripMenuItem.ToolTipText = "Remove Bounding pathname limits\r\n* Bounding pathname limits a xex to being execut" +
    "ed from a specified \r\n   path only.";
            this.PathnameToolStripMenuItem.Click += new System.EventHandler(this.PathnameToolStripMenuItem_Click);
            // 
            // KeyvaultToolStripMenuItem
            // 
            this.KeyvaultToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.KeyvaultToolStripMenuItem_Image;
            this.KeyvaultToolStripMenuItem.Name = "KeyvaultToolStripMenuItem";
            this.KeyvaultToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.KeyvaultToolStripMenuItem.Text = "Keyvault";
            this.KeyvaultToolStripMenuItem.ToolTipText = "Remove Signed keyvault limits\r\n* Signed keyvault limits an xex to running from an" +
    " xbox360 which has a \r\n   signed keyvault.";
            this.KeyvaultToolStripMenuItem.Click += new System.EventHandler(this.KeyvaultToolStripMenuItem_Click);
            // 
            // RequiredToolStripMenuItem
            // 
            this.RequiredToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.RequiredToolStripMenuItem_Image;
            this.RequiredToolStripMenuItem.Name = "RequiredToolStripMenuItem";
            this.RequiredToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.RequiredToolStripMenuItem.Text = "Required";
            this.RequiredToolStripMenuItem.ToolTipText = "Remove Required revocation check\r\n* Required revocation check requires the xex to" +
    " be checked against\r\n   a list of revocated xexs before allowing it to boot.";
            this.RequiredToolStripMenuItem.Click += new System.EventHandler(this.RequiredToolStripMenuItem_Click);
            // 
            // ZeroIDToolStripMenuItem
            // 
            this.ZeroIDToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.ZeroIDToolStripMenuItem_Image;
            this.ZeroIDToolStripMenuItem.Name = "ZeroIDToolStripMenuItem";
            this.ZeroIDToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.ZeroIDToolStripMenuItem.Text = "Zero ID";
            this.ZeroIDToolStripMenuItem.ToolTipText = "Zero the media id\r\n* A media id can be used to block an xex from running if it ma" +
    "tches known\r\n  \"banned\" media ids. This is the case for xexs from the famous \"ki" +
    "osk disc\".";
            this.ZeroIDToolStripMenuItem.Click += new System.EventHandler(this.ZeroIDToolStripMenuItem_Click);
            // 
            // AP25ToolStripMenuItem
            // 
            this.AP25ToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.AP25ToolStripMenuItem_Image;
            this.AP25ToolStripMenuItem.Name = "AP25ToolStripMenuItem";
            this.AP25ToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.AP25ToolStripMenuItem.Text = "AP2.5";
            this.AP25ToolStripMenuItem.ToolTipText = "Remove Ap2.5 Checks Beta";
            this.AP25ToolStripMenuItem.Click += new System.EventHandler(this.AP25ToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton8
            // 
            this.ToolStripDropDownButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RetailToolStripMenuItem,
            this.DevkitToolStripMenuItem,
            this.InfoToolStripMenuItem1});
            this.ToolStripDropDownButton8.Image = global::XexToolGUI.Properties.Resources.ToolStripDropDownButton8_Image;
            this.ToolStripDropDownButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton8.Name = "ToolStripDropDownButton8";
            this.ToolStripDropDownButton8.Size = new System.Drawing.Size(29, 22);
            this.ToolStripDropDownButton8.Text = "Create xex machine format";
            // 
            // RetailToolStripMenuItem
            // 
            this.RetailToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.RetailToolStripMenuItem_Image;
            this.RetailToolStripMenuItem.Name = "RetailToolStripMenuItem";
            this.RetailToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.RetailToolStripMenuItem.Text = "Retail";
            this.RetailToolStripMenuItem.ToolTipText = "Created from a development xex file a xex file \r\nfor the retail xbox360";
            this.RetailToolStripMenuItem.Click += new System.EventHandler(this.RetailToolStripMenuItem_Click);
            // 
            // DevkitToolStripMenuItem
            // 
            this.DevkitToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.DevkitToolStripMenuItem_Image;
            this.DevkitToolStripMenuItem.Name = "DevkitToolStripMenuItem";
            this.DevkitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.DevkitToolStripMenuItem.Text = "Devkit";
            this.DevkitToolStripMenuItem.ToolTipText = "Created from a retail xex file a xex file for the \r\nprocessing of a development x" +
    "box360";
            this.DevkitToolStripMenuItem.Click += new System.EventHandler(this.DevkitToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem1
            // 
            this.InfoToolStripMenuItem1.Image = global::XexToolGUI.Properties.Resources.InfoToolStripMenuItem_Image;
            this.InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            this.InfoToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.InfoToolStripMenuItem1.Text = "Info";
            this.InfoToolStripMenuItem1.ToolTipText = "Not only will the xex work on a devkit, it will also now work from any media\r\nand" +
    " run region independently";
            this.InfoToolStripMenuItem1.Click += new System.EventHandler(this.InfoToolStripMenuItem1_Click);
            // 
            // ToolStripDropDownButton3
            // 
            this.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UncryptedToolStripMenuItem,
            this.EncryptedToolStripMenuItem});
            this.ToolStripDropDownButton3.Image = global::XexToolGUI.Properties.Resources.ToolStripDropDownButton3_Image;
            this.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3";
            this.ToolStripDropDownButton3.Size = new System.Drawing.Size(29, 22);
            this.ToolStripDropDownButton3.Text = "xex encryption format";
            // 
            // UncryptedToolStripMenuItem
            // 
            this.UncryptedToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.UncryptedToolStripMenuItem_Image;
            this.UncryptedToolStripMenuItem.Name = "UncryptedToolStripMenuItem";
            this.UncryptedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.UncryptedToolStripMenuItem.Text = "Uncrypted";
            this.UncryptedToolStripMenuItem.ToolTipText = "xex to be uncrypted";
            this.UncryptedToolStripMenuItem.Click += new System.EventHandler(this.UncryptedToolStripMenuItem_Click);
            // 
            // EncryptedToolStripMenuItem
            // 
            this.EncryptedToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.EncryptedToolStripMenuItem_Image;
            this.EncryptedToolStripMenuItem.Name = "EncryptedToolStripMenuItem";
            this.EncryptedToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.EncryptedToolStripMenuItem.Text = "Encrypted";
            this.EncryptedToolStripMenuItem.ToolTipText = "xex to be encrypted";
            this.EncryptedToolStripMenuItem.Click += new System.EventHandler(this.EncryptedToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton9
            // 
            this.ToolStripDropDownButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XexBasicToolStripMenuItem,
            this.XexExtendedToolStripMenuItem});
            this.ToolStripDropDownButton9.Image = global::XexToolGUI.Properties.Resources.ToolStripDropDownButton9_Image;
            this.ToolStripDropDownButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton9.Name = "ToolStripDropDownButton9";
            this.ToolStripDropDownButton9.Size = new System.Drawing.Size(29, 22);
            this.ToolStripDropDownButton9.Text = "Xex file info";
            // 
            // XexBasicToolStripMenuItem
            // 
            this.XexBasicToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.InfoToolStripMenuItem1_Image;
            this.XexBasicToolStripMenuItem.Name = "XexBasicToolStripMenuItem";
            this.XexBasicToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.XexBasicToolStripMenuItem.Text = "xex Basic";
            this.XexBasicToolStripMenuItem.ToolTipText = "Print basic info about an xex file";
            this.XexBasicToolStripMenuItem.Click += new System.EventHandler(this.XexBasicToolStripMenuItem_Click);
            // 
            // XexExtendedToolStripMenuItem
            // 
            this.XexExtendedToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.XexExtendedToolStripMenuItem_Image;
            this.XexExtendedToolStripMenuItem.Name = "XexExtendedToolStripMenuItem";
            this.XexExtendedToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.XexExtendedToolStripMenuItem.Text = "xex Extended";
            this.XexExtendedToolStripMenuItem.ToolTipText = "Print extended info list about xex file\r\nTitle ID, Media ID, Dashversion and\r\nman" +
    "y more";
            this.XexExtendedToolStripMenuItem.Click += new System.EventHandler(this.XexExtendedToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ReadInfoToolStripButton
            // 
            this.ReadInfoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReadInfoToolStripButton.Image = global::XexToolGUI.Properties.Resources.ReadInfoToolStripButton_Image;
            this.ReadInfoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReadInfoToolStripButton.Name = "ReadInfoToolStripButton";
            this.ReadInfoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ReadInfoToolStripButton.Text = "Read Log";
            this.ReadInfoToolStripButton.ToolTipText = "Read the xex info log";
            this.ReadInfoToolStripButton.Click += new System.EventHandler(this.ReadInfoToolStripButton_Click);
            // 
            // ToolStripDropDownButton10
            // 
            this.ToolStripDropDownButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDropDownButton10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UncompressedToolStripMenuItem,
            this.CompressedToolStripMenuItem,
            this.BinaryToolStripMenuItem});
            this.ToolStripDropDownButton10.Image = global::XexToolGUI.Properties.Resources.ToolStripDropDownButton10_Image;
            this.ToolStripDropDownButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton10.Name = "ToolStripDropDownButton10";
            this.ToolStripDropDownButton10.Size = new System.Drawing.Size(29, 22);
            this.ToolStripDropDownButton10.Text = "xex compression";
            // 
            // UncompressedToolStripMenuItem
            // 
            this.UncompressedToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.UncompressedToolStripMenuItem_Image;
            this.UncompressedToolStripMenuItem.Name = "UncompressedToolStripMenuItem";
            this.UncompressedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.UncompressedToolStripMenuItem.Text = "Uncompressed";
            this.UncompressedToolStripMenuItem.ToolTipText = "xex to be uncompressed (no zeroed data)";
            this.UncompressedToolStripMenuItem.Click += new System.EventHandler(this.UncompressedToolStripMenuItem_Click);
            // 
            // CompressedToolStripMenuItem
            // 
            this.CompressedToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.CompressedToolStripMenuItem_Image;
            this.CompressedToolStripMenuItem.Name = "CompressedToolStripMenuItem";
            this.CompressedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.CompressedToolStripMenuItem.Text = "Compressed";
            this.CompressedToolStripMenuItem.ToolTipText = "xex to be compressed";
            this.CompressedToolStripMenuItem.Click += new System.EventHandler(this.CompressedToolStripMenuItem_Click);
            // 
            // BinaryToolStripMenuItem
            // 
            this.BinaryToolStripMenuItem.Image = global::XexToolGUI.Properties.Resources.BinaryToolStripMenuItem_Image;
            this.BinaryToolStripMenuItem.Name = "BinaryToolStripMenuItem";
            this.BinaryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.BinaryToolStripMenuItem.Text = "Binary";
            this.BinaryToolStripMenuItem.ToolTipText = "xex to be binary (has zeroed data)";
            this.BinaryToolStripMenuItem.Click += new System.EventHandler(this.BinaryToolStripMenuItem_Click);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.SaveButton);
            this.GroupBox6.Controls.Add(this.OpenxexpButton);
            this.GroupBox6.Controls.Add(this.Label2);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.Controls.Add(this.Label7);
            this.GroupBox6.Controls.Add(this.OpenxexButton);
            this.GroupBox6.Controls.Add(this.Label6);
            this.GroupBox6.Controls.Add(this.XeXFileTextBox);
            this.GroupBox6.Controls.Add(this.XeXpFileTextBox);
            this.GroupBox6.Controls.Add(this.SavePatchTextBox);
            this.GroupBox6.Location = new System.Drawing.Point(12, 292);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(443, 192);
            this.GroupBox6.TabIndex = 32;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Files";
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::XexToolGUI.Properties.Resources.SaveButton_Image;
            this.SaveButton.Location = new System.Drawing.Point(353, 138);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(48, 48);
            this.SaveButton.TabIndex = 30;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenxexpButton
            // 
            this.OpenxexpButton.Image = global::XexToolGUI.Properties.Resources.OpenxexpButton_Image;
            this.OpenxexpButton.Location = new System.Drawing.Point(353, 84);
            this.OpenxexpButton.Name = "OpenxexpButton";
            this.OpenxexpButton.Size = new System.Drawing.Size(48, 48);
            this.OpenxexpButton.TabIndex = 31;
            this.OpenxexpButton.UseVisualStyleBackColor = true;
            this.OpenxexpButton.Click += new System.EventHandler(this.OpenxexpButton_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(113, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(172, 13);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "There must be no spaces available";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(43, 137);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(110, 13);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Xex Save location";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(43, 83);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 13);
            this.Label7.TabIndex = 22;
            this.Label7.Text = "Xexp";
            // 
            // OpenxexButton
            // 
            this.OpenxexButton.Image = global::XexToolGUI.Properties.Resources.OpenxexButton_Image;
            this.OpenxexButton.Location = new System.Drawing.Point(353, 30);
            this.OpenxexButton.Name = "OpenxexButton";
            this.OpenxexButton.Size = new System.Drawing.Size(48, 48);
            this.OpenxexButton.TabIndex = 29;
            this.OpenxexButton.UseVisualStyleBackColor = true;
            this.OpenxexButton.Click += new System.EventHandler(this.OpenxexButton_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(43, 29);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 13);
            this.Label6.TabIndex = 21;
            this.Label6.Text = "Xex";
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // xexgui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(468, 524);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.ToolStrip3);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "xexgui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XexToolGUI ";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip3.ResumeLayout(false);
            this.ToolStrip3.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox XLogBox;
        private ProgressBar ProgressBar1;
        private Timer Timer2;
        private ToolStripMenuItem HxDToolStripMenuItem1;
        private ToolStripMenuItem WxPirsToolStripMenuItem;
        private ToolStripDropDownButton ToolStripDropDownButton5;
        private ToolStripMenuItem TitleUpdatesToolStripMenuItem1;
        private ToolStripMenuItem IdcFileForIDAToolStripMenuItem;
        private ToolStripMenuItem XMLToolStripMenuItem;
        private ToolStripMenuItem DumbToolStripMenuItem;
        private ToolStripDropDownButton ToolStripDropDownButton6;
        private ToolStripMenuItem HelpToolStripMenuItem2;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem2;
        private ToolStripMenuItem AboutToolStripMenuItem1;
        private ToolStripLabel ToolStripLabel1;
        private ToolStripDropDownButton ToolStripDropDownButton1;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private OpenFileDialog OpenFileDialog3;
        private FolderBrowserDialog FolderBrowserDialog1;
        private NotifyIcon NotifyIcon1;
        private StatusStrip StatusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStrip ToolStrip3;
        private ToolStripButton BackupxexToolStripButton;
        private ToolStripSeparator ToolStripSeparator2;
        private ToolStripButton PatchxexToolStripButton;
        private ToolStripSeparator ToolStripSeparator3;
        private ToolStripButton Clear2ToolStripButton;
        private ToolStripSeparator ToolStripSeparator5;
        private ToolStripDropDownButton ToolStripDropDownButton7;
        private ToolStripMenuItem RegionToolStripMenuItem;
        private ToolStripMenuItem MediaToolStripMenuItem;
        private ToolStripMenuItem DashToolStripMenuItem;
        private ToolStripMenuItem PathnameToolStripMenuItem;
        private ToolStripMenuItem KeyvaultToolStripMenuItem;
        private ToolStripMenuItem RequiredToolStripMenuItem;
        private ToolStripMenuItem ZeroIDToolStripMenuItem;
        private ToolStripMenuItem AP25ToolStripMenuItem;
        private ToolStripDropDownButton ToolStripDropDownButton8;
        private ToolStripMenuItem RetailToolStripMenuItem;
        private ToolStripMenuItem DevkitToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem1;
        private ToolStripDropDownButton ToolStripDropDownButton3;
        private ToolStripMenuItem UncryptedToolStripMenuItem;
        private ToolStripMenuItem EncryptedToolStripMenuItem;
        private ToolStripDropDownButton ToolStripDropDownButton9;
        private ToolStripMenuItem XexBasicToolStripMenuItem;
        private ToolStripMenuItem XexExtendedToolStripMenuItem;
        private ToolStripSeparator ToolStripSeparator1;
        private ToolStripButton ReadInfoToolStripButton;
        private ToolStripDropDownButton ToolStripDropDownButton10;
        private ToolStripMenuItem UncompressedToolStripMenuItem;
        private ToolStripMenuItem CompressedToolStripMenuItem;
        private ToolStripMenuItem BinaryToolStripMenuItem;
        private GroupBox GroupBox6;
        private Button SaveButton;
        private Button OpenxexpButton;
        private Label Label2;
        private Label Label8;
        private Label Label7;
        private Button OpenxexButton;
        private Label Label6;
        private CheckBox CheckBox1;
        private GroupBox GroupBox1;
        private Label Label1;
        private Timer Timer1;
        private TextBox XeXFileTextBox;
        private ToolTip ToolTip1;
        private OpenFileDialog OpenFileDialog1;
        private TextBox SavePatchTextBox;
        private TextBox XeXpFileTextBox;
        private ImageList ImageList1;
        private OpenFileDialog OpenFileDialog2;
        private SaveFileDialog SaveFileDialog1;
        private ToolStrip ToolStrip1;
        private ToolStripDropDownButton ToolStripDropDownButton2;
        private ToolStripMenuItem SelectxexToolStripMenuItem1;
        private ToolStripMenuItem SelectToolStripMenuItem;
        private ToolStripMenuItem SavexexToolStripMenuItem;
        private ToolStripMenuItem ClearToolStripMenuItem1;
        private ToolStripMenuItem ExitToolStripMenuItem2;
        private ToolStripDropDownButton ToolStripDropDownButton4;
        private ToolStripMenuItem CMDToolStripMenuItem;
    }
}

