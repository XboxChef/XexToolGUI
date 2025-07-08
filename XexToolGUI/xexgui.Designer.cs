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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xexgui));
            XLogBox = new TextBox();
            ProgressBar1 = new ProgressBar();
            CheckBox1 = new CheckBox();
            GroupBox1 = new GroupBox();
            Label1 = new Label();
            XeXFileTextBox = new TextBox();
            ToolTip1 = new ToolTip(components);
            OpenFileDialog1 = new OpenFileDialog();
            SavePatchTextBox = new TextBox();
            XeXpFileTextBox = new TextBox();
            ImageList1 = new ImageList(components);
            OpenFileDialog2 = new OpenFileDialog();
            SaveFileDialog1 = new SaveFileDialog();
            ToolStrip1 = new ToolStrip();
            ToolStripDropDownButton2 = new ToolStripDropDownButton();
            SelectxexToolStripMenuItem1 = new ToolStripMenuItem();
            SelectToolStripMenuItem = new ToolStripMenuItem();
            SavexexToolStripMenuItem = new ToolStripMenuItem();
            ClearToolStripMenuItem1 = new ToolStripMenuItem();
            ExitToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripDropDownButton4 = new ToolStripDropDownButton();
            CMDToolStripMenuItem = new ToolStripMenuItem();
            HxDToolStripMenuItem1 = new ToolStripMenuItem();
            WxPirsToolStripMenuItem = new ToolStripMenuItem();
            ToolStripDropDownButton5 = new ToolStripDropDownButton();
            TitleUpdatesToolStripMenuItem1 = new ToolStripMenuItem();
            IdcFileForIDAToolStripMenuItem = new ToolStripMenuItem();
            XMLToolStripMenuItem = new ToolStripMenuItem();
            DumbToolStripMenuItem = new ToolStripMenuItem();
            ToolStripDropDownButton6 = new ToolStripDropDownButton();
            HelpToolStripMenuItem2 = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem2 = new ToolStripMenuItem();
            AboutToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripLabel1 = new ToolStripLabel();
            ToolStripDropDownButton1 = new ToolStripDropDownButton();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            OpenFileDialog3 = new OpenFileDialog();
            FolderBrowserDialog1 = new FolderBrowserDialog();
            NotifyIcon1 = new NotifyIcon(components);
            StatusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStrip3 = new ToolStrip();
            BackupxexToolStripButton = new ToolStripButton();
            ToolStripSeparator2 = new ToolStripSeparator();
            PatchxexToolStripButton = new ToolStripButton();
            ToolStripSeparator3 = new ToolStripSeparator();
            Clear2ToolStripButton = new ToolStripButton();
            ToolStripSeparator5 = new ToolStripSeparator();
            ToolStripDropDownButton7 = new ToolStripDropDownButton();
            RegionToolStripMenuItem = new ToolStripMenuItem();
            MediaToolStripMenuItem = new ToolStripMenuItem();
            DashToolStripMenuItem = new ToolStripMenuItem();
            PathnameToolStripMenuItem = new ToolStripMenuItem();
            KeyvaultToolStripMenuItem = new ToolStripMenuItem();
            RequiredToolStripMenuItem = new ToolStripMenuItem();
            ZeroIDToolStripMenuItem = new ToolStripMenuItem();
            AP25ToolStripMenuItem = new ToolStripMenuItem();
            ToolStripDropDownButton8 = new ToolStripDropDownButton();
            RetailToolStripMenuItem = new ToolStripMenuItem();
            DevkitToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripDropDownButton3 = new ToolStripDropDownButton();
            UncryptedToolStripMenuItem = new ToolStripMenuItem();
            EncryptedToolStripMenuItem = new ToolStripMenuItem();
            ToolStripDropDownButton9 = new ToolStripDropDownButton();
            XexBasicToolStripMenuItem = new ToolStripMenuItem();
            XexExtendedToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator1 = new ToolStripSeparator();
            ReadInfoToolStripButton = new ToolStripButton();
            ToolStripDropDownButton10 = new ToolStripDropDownButton();
            UncompressedToolStripMenuItem = new ToolStripMenuItem();
            CompressedToolStripMenuItem = new ToolStripMenuItem();
            BinaryToolStripMenuItem = new ToolStripMenuItem();
            GroupBox6 = new GroupBox();
            SaveButton = new Button();
            OpenxexpButton = new Button();
            Label2 = new Label();
            Label8 = new Label();
            Label7 = new Label();
            OpenxexButton = new Button();
            Label6 = new Label();
            GroupBox1.SuspendLayout();
            ToolStrip1.SuspendLayout();
            StatusStrip1.SuspendLayout();
            ToolStrip3.SuspendLayout();
            GroupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // XLogBox
            // 
            XLogBox.BackColor = SystemColors.ActiveCaptionText;
            XLogBox.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            XLogBox.ForeColor = SystemColors.HighlightText;
            XLogBox.Location = new Point(18, 22);
            XLogBox.Margin = new Padding(4, 3, 4, 3);
            XLogBox.Multiline = true;
            XLogBox.Name = "XLogBox";
            XLogBox.ReadOnly = true;
            XLogBox.ScrollBars = ScrollBars.Vertical;
            XLogBox.Size = new Size(475, 156);
            XLogBox.TabIndex = 0;
            ToolTip1.SetToolTip(XLogBox, "xextool process log window");
            // 
            // ProgressBar1
            // 
            ProgressBar1.Location = new Point(18, 186);
            ProgressBar1.Margin = new Padding(4, 3, 4, 3);
            ProgressBar1.Name = "ProgressBar1";
            ProgressBar1.Size = new Size(476, 17);
            ProgressBar1.TabIndex = 1;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = CheckState.Checked;
            CheckBox1.Location = new Point(31, 310);
            CheckBox1.Margin = new Padding(4, 3, 4, 3);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(86, 19);
            CheckBox1.TabIndex = 2;
            CheckBox1.Text = "Detaild log ";
            ToolTip1.SetToolTip(CheckBox1, "better information about the process");
            CheckBox1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(ProgressBar1);
            GroupBox1.Controls.Add(XLogBox);
            GroupBox1.Location = new Point(14, 74);
            GroupBox1.Margin = new Padding(4, 3, 4, 3);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(4, 3, 4, 3);
            GroupBox1.Size = new Size(517, 222);
            GroupBox1.TabIndex = 3;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Xex";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(146, 303);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(302, 30);
            Label1.TabIndex = 3;
            Label1.Text = "The program runs in the background when it is finished \r\nor an error in the log window appears.      (ca. 1.min)\r\n";
            // 
            // XeXFileTextBox
            // 
            XeXFileTextBox.AllowDrop = true;
            XeXFileTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            XeXFileTextBox.Location = new Point(54, 52);
            XeXFileTextBox.Margin = new Padding(4, 3, 4, 3);
            XeXFileTextBox.Name = "XeXFileTextBox";
            XeXFileTextBox.Size = new Size(350, 23);
            XeXFileTextBox.TabIndex = 20;
            XeXFileTextBox.DragDrop += XeXFileTextBox_DragDrop;
            XeXFileTextBox.DragEnter += XeXFileTextBox_DragEnter;
            XeXFileTextBox.DragLeave += XeXFileTextBox_DragLeave;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // SavePatchTextBox
            // 
            SavePatchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SavePatchTextBox.Location = new Point(54, 177);
            SavePatchTextBox.Margin = new Padding(4, 3, 4, 3);
            SavePatchTextBox.Name = "SavePatchTextBox";
            SavePatchTextBox.Size = new Size(350, 23);
            SavePatchTextBox.TabIndex = 22;
            // 
            // XeXpFileTextBox
            // 
            XeXpFileTextBox.AllowDrop = true;
            XeXpFileTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            XeXpFileTextBox.Location = new Point(54, 114);
            XeXpFileTextBox.Margin = new Padding(4, 3, 4, 3);
            XeXpFileTextBox.Name = "XeXpFileTextBox";
            XeXpFileTextBox.Size = new Size(350, 23);
            XeXpFileTextBox.TabIndex = 21;
            XeXpFileTextBox.DragDrop += XeXpFileTextBox_DragDrop;
            XeXpFileTextBox.DragEnter += XeXpFileTextBox_DragEnter;
            XeXpFileTextBox.DragLeave += XeXpFileTextBox_DragLeave;
            // 
            // ImageList1
            // 
            ImageList1.ColorDepth = ColorDepth.Depth8Bit;
            ImageList1.ImageSize = new Size(16, 16);
            ImageList1.TransparentColor = Color.Transparent;
            // 
            // OpenFileDialog2
            // 
            OpenFileDialog2.Filter = "xexp File|*.xexp";
            // 
            // SaveFileDialog1
            // 
            SaveFileDialog1.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // ToolStrip1
            // 
            ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripDropDownButton2, ToolStripDropDownButton4, ToolStripDropDownButton5, ToolStripDropDownButton6 });
            ToolStrip1.Location = new Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.RenderMode = ToolStripRenderMode.System;
            ToolStrip1.Size = new Size(546, 25);
            ToolStrip1.TabIndex = 29;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripDropDownButton2
            // 
            ToolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { SelectxexToolStripMenuItem1, SelectToolStripMenuItem, SavexexToolStripMenuItem, ClearToolStripMenuItem1, ExitToolStripMenuItem2 });
            ToolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton2.Name = "ToolStripDropDownButton2";
            ToolStripDropDownButton2.Size = new Size(38, 22);
            ToolStripDropDownButton2.Text = "File";
            ToolStripDropDownButton2.ToolTipText = "Option";
            // 
            // SelectxexToolStripMenuItem1
            // 
            SelectxexToolStripMenuItem1.Image = Properties.Resources.SelectxexToolStripMenuItem1_Image;
            SelectxexToolStripMenuItem1.Name = "SelectxexToolStripMenuItem1";
            SelectxexToolStripMenuItem1.Size = new Size(133, 22);
            SelectxexToolStripMenuItem1.Text = "Select xex";
            SelectxexToolStripMenuItem1.ToolTipText = "Open xex file";
            SelectxexToolStripMenuItem1.Click += SelectxexToolStripMenuItem1_Click;
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.Image = Properties.Resources.SelectToolStripMenuItem_Image;
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new Size(133, 22);
            SelectToolStripMenuItem.Text = "Select xexp";
            SelectToolStripMenuItem.ToolTipText = "Open xexp file";
            SelectToolStripMenuItem.Click += SelectToolStripMenuItem_Click;
            // 
            // SavexexToolStripMenuItem
            // 
            SavexexToolStripMenuItem.Image = Properties.Resources.SavexexToolStripMenuItem_Image;
            SavexexToolStripMenuItem.Name = "SavexexToolStripMenuItem";
            SavexexToolStripMenuItem.Size = new Size(133, 22);
            SavexexToolStripMenuItem.Text = "Save As";
            SavexexToolStripMenuItem.ToolTipText = "Save file";
            // 
            // ClearToolStripMenuItem1
            // 
            ClearToolStripMenuItem1.Image = Properties.Resources.Clear2ToolStripButton_Image;
            ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1";
            ClearToolStripMenuItem1.Size = new Size(133, 22);
            ClearToolStripMenuItem1.Text = "Clear";
            ClearToolStripMenuItem1.ToolTipText = "Clear all Box";
            ClearToolStripMenuItem1.Click += ClearToolStripMenuItem1_Click;
            // 
            // ExitToolStripMenuItem2
            // 
            ExitToolStripMenuItem2.Image = Properties.Resources.ExitToolStripMenuItem_Image;
            ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2";
            ExitToolStripMenuItem2.Size = new Size(133, 22);
            ExitToolStripMenuItem2.Text = "Exit";
            ExitToolStripMenuItem2.ToolTipText = "Close App";
            ExitToolStripMenuItem2.Click += ExitToolStripMenuItem2_Click;
            // 
            // ToolStripDropDownButton4
            // 
            ToolStripDropDownButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDropDownButton4.DropDownItems.AddRange(new ToolStripItem[] { CMDToolStripMenuItem, HxDToolStripMenuItem1, WxPirsToolStripMenuItem });
            ToolStripDropDownButton4.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton4.Name = "ToolStripDropDownButton4";
            ToolStripDropDownButton4.Size = new Size(40, 22);
            ToolStripDropDownButton4.Text = "Edit";
            // 
            // CMDToolStripMenuItem
            // 
            CMDToolStripMenuItem.Image = Properties.Resources.CMDToolStripMenuItem_Image;
            CMDToolStripMenuItem.Name = "CMDToolStripMenuItem";
            CMDToolStripMenuItem.Size = new Size(108, 22);
            CMDToolStripMenuItem.Text = "CMD";
            CMDToolStripMenuItem.ToolTipText = "xextool.exe run from the command line";
            CMDToolStripMenuItem.Click += CMDToolStripMenuItem_Click;
            // 
            // HxDToolStripMenuItem1
            // 
            HxDToolStripMenuItem1.Image = Properties.Resources.HxDToolStripMenuItem1_Image;
            HxDToolStripMenuItem1.Name = "HxDToolStripMenuItem1";
            HxDToolStripMenuItem1.Size = new Size(108, 22);
            HxDToolStripMenuItem1.Text = "HxD";
            HxDToolStripMenuItem1.ToolTipText = "Hex Editor";
            HxDToolStripMenuItem1.Visible = false;
            HxDToolStripMenuItem1.Click += HxDToolStripMenuItem1_Click;
            // 
            // WxPirsToolStripMenuItem
            // 
            WxPirsToolStripMenuItem.Image = Properties.Resources.WxPirsToolStripMenuItem_Image;
            WxPirsToolStripMenuItem.Name = "WxPirsToolStripMenuItem";
            WxPirsToolStripMenuItem.Size = new Size(108, 22);
            WxPirsToolStripMenuItem.Text = "wxPirs";
            WxPirsToolStripMenuItem.ToolTipText = "Extract Live, Pirs files";
            WxPirsToolStripMenuItem.Visible = false;
            WxPirsToolStripMenuItem.Click += WxPirsToolStripMenuItem_Click;
            // 
            // ToolStripDropDownButton5
            // 
            ToolStripDropDownButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDropDownButton5.DropDownItems.AddRange(new ToolStripItem[] { TitleUpdatesToolStripMenuItem1, IdcFileForIDAToolStripMenuItem, XMLToolStripMenuItem, DumbToolStripMenuItem });
            ToolStripDropDownButton5.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton5.Name = "ToolStripDropDownButton5";
            ToolStripDropDownButton5.Size = new Size(46, 22);
            ToolStripDropDownButton5.Text = "Extra";
            // 
            // TitleUpdatesToolStripMenuItem1
            // 
            TitleUpdatesToolStripMenuItem1.Image = Properties.Resources.TitleUpdatesToolStripMenuItem1_Image;
            TitleUpdatesToolStripMenuItem1.Name = "TitleUpdatesToolStripMenuItem1";
            TitleUpdatesToolStripMenuItem1.Size = new Size(142, 22);
            TitleUpdatesToolStripMenuItem1.Text = "Title Updates";
            TitleUpdatesToolStripMenuItem1.ToolTipText = "Search Game Updates ";
            TitleUpdatesToolStripMenuItem1.Click += TitleUpdatesToolStripMenuItem1_Click;
            // 
            // IdcFileForIDAToolStripMenuItem
            // 
            IdcFileForIDAToolStripMenuItem.Image = Properties.Resources.IdcFileForIDAToolStripMenuItem_Image;
            IdcFileForIDAToolStripMenuItem.Name = "IdcFileForIDAToolStripMenuItem";
            IdcFileForIDAToolStripMenuItem.Size = new Size(142, 22);
            IdcFileForIDAToolStripMenuItem.Text = "IDC";
            IdcFileForIDAToolStripMenuItem.ToolTipText = "Create idc file for IDA";
            IdcFileForIDAToolStripMenuItem.Click += IdcFileForIDAToolStripMenuItem_Click;
            // 
            // XMLToolStripMenuItem
            // 
            XMLToolStripMenuItem.Image = Properties.Resources.XMLToolStripMenuItem_Image;
            XMLToolStripMenuItem.Name = "XMLToolStripMenuItem";
            XMLToolStripMenuItem.Size = new Size(142, 22);
            XMLToolStripMenuItem.Text = "XML ";
            XMLToolStripMenuItem.Visible = false;
            XMLToolStripMenuItem.Click += XMLToolStripMenuItem_Click;
            // 
            // DumbToolStripMenuItem
            // 
            DumbToolStripMenuItem.Image = Properties.Resources.DumbToolStripMenuItem_Image;
            DumbToolStripMenuItem.Name = "DumbToolStripMenuItem";
            DumbToolStripMenuItem.Size = new Size(142, 22);
            DumbToolStripMenuItem.Text = "Dump";
            DumbToolStripMenuItem.ToolTipText = "Dump an xex file";
            DumbToolStripMenuItem.Click += DumbToolStripMenuItem_Click;
            // 
            // ToolStripDropDownButton6
            // 
            ToolStripDropDownButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolStripDropDownButton6.DropDownItems.AddRange(new ToolStripItem[] { HelpToolStripMenuItem2, HelpToolStripMenuItem, InfoToolStripMenuItem2, AboutToolStripMenuItem1 });
            ToolStripDropDownButton6.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton6.Name = "ToolStripDropDownButton6";
            ToolStripDropDownButton6.Size = new Size(45, 22);
            ToolStripDropDownButton6.Text = "Help";
            // 
            // HelpToolStripMenuItem2
            // 
            HelpToolStripMenuItem2.Image = Properties.Resources.HelpToolStripMenuItem2_Image;
            HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2";
            HelpToolStripMenuItem2.Size = new Size(191, 22);
            HelpToolStripMenuItem2.Text = "Help";
            HelpToolStripMenuItem2.Click += HelpToolStripMenuItem2_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.Image = Properties.Resources.HelpToolStripMenuItem_Image;
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(191, 22);
            HelpToolStripMenuItem.Text = "Help  reverse engineer";
            HelpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
            // 
            // InfoToolStripMenuItem2
            // 
            InfoToolStripMenuItem2.Image = Properties.Resources.XexBasicToolStripMenuItem_Image;
            InfoToolStripMenuItem2.Name = "InfoToolStripMenuItem2";
            InfoToolStripMenuItem2.Size = new Size(191, 22);
            InfoToolStripMenuItem2.Text = "Info";
            InfoToolStripMenuItem2.Click += InfoToolStripMenuItem2_Click;
            // 
            // AboutToolStripMenuItem1
            // 
            AboutToolStripMenuItem1.Image = Properties.Resources.AboutToolStripMenuItem1_Image;
            AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            AboutToolStripMenuItem1.Size = new Size(191, 22);
            AboutToolStripMenuItem1.Text = "About GUI";
            AboutToolStripMenuItem1.Click += AboutToolStripMenuItem1_Click;
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(32, 22);
            ToolStripLabel1.Text = "Help";
            // 
            // ToolStripDropDownButton1
            // 
            ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { InfoToolStripMenuItem, AboutToolStripMenuItem, ExitToolStripMenuItem });
            ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            ToolStripDropDownButton1.Size = new Size(13, 22);
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new Size(107, 22);
            InfoToolStripMenuItem.Text = "Info";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(107, 22);
            AboutToolStripMenuItem.Text = "About";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(107, 22);
            ExitToolStripMenuItem.Text = "Exit";
            // 
            // OpenFileDialog3
            // 
            OpenFileDialog3.Filter = "xex File|*.xex|All Files|*.*";
            // 
            // NotifyIcon1
            // 
            NotifyIcon1.Icon = (Icon)resources.GetObject("NotifyIcon1.Icon");
            NotifyIcon1.Text = "XexTool MiniGUI";
            NotifyIcon1.Visible = true;
            // 
            // StatusStrip1
            // 
            StatusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1 });
            StatusStrip1.Location = new Point(0, 583);
            StatusStrip1.Name = "StatusStrip1";
            StatusStrip1.Padding = new Padding(1, 0, 16, 0);
            StatusStrip1.Size = new Size(546, 22);
            StatusStrip1.SizingGrip = false;
            StatusStrip1.TabIndex = 30;
            StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.AutoSize = false;
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(54, 17);
            ToolStripStatusLabel1.Text = "v1.8 Beta";
            // 
            // ToolStrip3
            // 
            ToolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip3.Items.AddRange(new ToolStripItem[] { BackupxexToolStripButton, ToolStripSeparator2, PatchxexToolStripButton, ToolStripSeparator3, Clear2ToolStripButton, ToolStripSeparator5, ToolStripDropDownButton7, ToolStripDropDownButton8, ToolStripDropDownButton3, ToolStripDropDownButton9, ToolStripSeparator1, ReadInfoToolStripButton, ToolStripDropDownButton10 });
            ToolStrip3.Location = new Point(0, 25);
            ToolStrip3.Name = "ToolStrip3";
            ToolStrip3.RenderMode = ToolStripRenderMode.Professional;
            ToolStrip3.Size = new Size(546, 25);
            ToolStrip3.TabIndex = 31;
            ToolStrip3.Text = "ToolStrip3";
            // 
            // BackupxexToolStripButton
            // 
            BackupxexToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackupxexToolStripButton.Image = Properties.Resources.BackupxexToolStripButton_Image;
            BackupxexToolStripButton.ImageTransparentColor = Color.Magenta;
            BackupxexToolStripButton.Name = "BackupxexToolStripButton";
            BackupxexToolStripButton.Size = new Size(23, 22);
            BackupxexToolStripButton.Text = "Backup from a xex file";
            BackupxexToolStripButton.ToolTipText = "Backup a xex file";
            BackupxexToolStripButton.Click += BackupxexToolStripButton_Click;
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // PatchxexToolStripButton
            // 
            PatchxexToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PatchxexToolStripButton.Image = Properties.Resources.PatchxexToolStripButton_Image;
            PatchxexToolStripButton.ImageTransparentColor = Color.Magenta;
            PatchxexToolStripButton.Name = "PatchxexToolStripButton";
            PatchxexToolStripButton.Size = new Size(23, 22);
            PatchxexToolStripButton.Text = "Patch a xex file with xexp file";
            PatchxexToolStripButton.ToolTipText = "Patch xex file with xexp file";
            PatchxexToolStripButton.Click += PatchxexToolStripButton_Click;
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 25);
            // 
            // Clear2ToolStripButton
            // 
            Clear2ToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Clear2ToolStripButton.Image = Properties.Resources.Clear2ToolStripButton_Image;
            Clear2ToolStripButton.ImageTransparentColor = Color.Magenta;
            Clear2ToolStripButton.Name = "Clear2ToolStripButton";
            Clear2ToolStripButton.Size = new Size(23, 22);
            Clear2ToolStripButton.Text = "Clear";
            Clear2ToolStripButton.Click += Clear2ToolStripButton_Click;
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator5.Size = new Size(6, 25);
            // 
            // ToolStripDropDownButton7
            // 
            ToolStripDropDownButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton7.DropDownItems.AddRange(new ToolStripItem[] { RegionToolStripMenuItem, MediaToolStripMenuItem, DashToolStripMenuItem, PathnameToolStripMenuItem, KeyvaultToolStripMenuItem, RequiredToolStripMenuItem, ZeroIDToolStripMenuItem, AP25ToolStripMenuItem });
            ToolStripDropDownButton7.Image = Properties.Resources.ExitToolStripMenuItem_Image;
            ToolStripDropDownButton7.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton7.Name = "ToolStripDropDownButton7";
            ToolStripDropDownButton7.Size = new Size(29, 22);
            ToolStripDropDownButton7.Text = "Remove xex limits";
            // 
            // RegionToolStripMenuItem
            // 
            RegionToolStripMenuItem.Image = Properties.Resources.RegionToolStripMenuItem_Image;
            RegionToolStripMenuItem.Name = "RegionToolStripMenuItem";
            RegionToolStripMenuItem.Size = new Size(128, 22);
            RegionToolStripMenuItem.Text = "Region";
            RegionToolStripMenuItem.ToolTipText = "Makes a Region Free file\r\n* Region limits limit what console regions an xex can be booted on.";
            RegionToolStripMenuItem.Click += RegionToolStripMenuItem_Click;
            // 
            // MediaToolStripMenuItem
            // 
            MediaToolStripMenuItem.Image = Properties.Resources.MediaToolStripMenuItem_Image;
            MediaToolStripMenuItem.Name = "MediaToolStripMenuItem";
            MediaToolStripMenuItem.Size = new Size(128, 22);
            MediaToolStripMenuItem.Text = "Media";
            MediaToolStripMenuItem.ToolTipText = "Remove the media limits\r\n* Media limits limit what media the xex can be booted from.";
            MediaToolStripMenuItem.Click += MediaToolStripMenuItem_Click;
            // 
            // DashToolStripMenuItem
            // 
            DashToolStripMenuItem.Image = Properties.Resources.DashToolStripMenuItem_Image;
            DashToolStripMenuItem.Name = "DashToolStripMenuItem";
            DashToolStripMenuItem.Size = new Size(128, 22);
            DashToolStripMenuItem.Text = "Dash";
            DashToolStripMenuItem.ToolTipText = "Remove Dashboard version\r\n* Minimum library versions require system dlls to be of a specified\r\n  version of higher. The usual imports are from xboxkrnl.exe and xam.exe.";
            DashToolStripMenuItem.Click += DashToolStripMenuItem_Click;
            // 
            // PathnameToolStripMenuItem
            // 
            PathnameToolStripMenuItem.Image = Properties.Resources.PathnameToolStripMenuItem_Image;
            PathnameToolStripMenuItem.Name = "PathnameToolStripMenuItem";
            PathnameToolStripMenuItem.Size = new Size(128, 22);
            PathnameToolStripMenuItem.Text = "Pathname";
            PathnameToolStripMenuItem.ToolTipText = "Remove Bounding pathname limits\r\n* Bounding pathname limits a xex to being executed from a specified \r\n   path only.";
            PathnameToolStripMenuItem.Click += PathnameToolStripMenuItem_Click;
            // 
            // KeyvaultToolStripMenuItem
            // 
            KeyvaultToolStripMenuItem.Image = Properties.Resources.KeyvaultToolStripMenuItem_Image;
            KeyvaultToolStripMenuItem.Name = "KeyvaultToolStripMenuItem";
            KeyvaultToolStripMenuItem.Size = new Size(128, 22);
            KeyvaultToolStripMenuItem.Text = "Keyvault";
            KeyvaultToolStripMenuItem.ToolTipText = "Remove Signed keyvault limits\r\n* Signed keyvault limits an xex to running from an xbox360 which has a \r\n   signed keyvault.";
            KeyvaultToolStripMenuItem.Click += KeyvaultToolStripMenuItem_Click;
            // 
            // RequiredToolStripMenuItem
            // 
            RequiredToolStripMenuItem.Image = Properties.Resources.RequiredToolStripMenuItem_Image;
            RequiredToolStripMenuItem.Name = "RequiredToolStripMenuItem";
            RequiredToolStripMenuItem.Size = new Size(128, 22);
            RequiredToolStripMenuItem.Text = "Required";
            RequiredToolStripMenuItem.ToolTipText = "Remove Required revocation check\r\n* Required revocation check requires the xex to be checked against\r\n   a list of revocated xexs before allowing it to boot.";
            RequiredToolStripMenuItem.Click += RequiredToolStripMenuItem_Click;
            // 
            // ZeroIDToolStripMenuItem
            // 
            ZeroIDToolStripMenuItem.Image = Properties.Resources.ZeroIDToolStripMenuItem_Image;
            ZeroIDToolStripMenuItem.Name = "ZeroIDToolStripMenuItem";
            ZeroIDToolStripMenuItem.Size = new Size(128, 22);
            ZeroIDToolStripMenuItem.Text = "Zero ID";
            ZeroIDToolStripMenuItem.ToolTipText = "Zero the media id\r\n* A media id can be used to block an xex from running if it matches known\r\n  \"banned\" media ids. This is the case for xexs from the famous \"kiosk disc\".";
            ZeroIDToolStripMenuItem.Click += ZeroIDToolStripMenuItem_Click;
            // 
            // AP25ToolStripMenuItem
            // 
            AP25ToolStripMenuItem.Image = Properties.Resources.AP25ToolStripMenuItem_Image;
            AP25ToolStripMenuItem.Name = "AP25ToolStripMenuItem";
            AP25ToolStripMenuItem.Size = new Size(128, 22);
            AP25ToolStripMenuItem.Text = "AP2.5";
            AP25ToolStripMenuItem.ToolTipText = "Remove Ap2.5 Checks Beta";
            AP25ToolStripMenuItem.Click += AP25ToolStripMenuItem_Click;
            // 
            // ToolStripDropDownButton8
            // 
            ToolStripDropDownButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton8.DropDownItems.AddRange(new ToolStripItem[] { RetailToolStripMenuItem, DevkitToolStripMenuItem, InfoToolStripMenuItem1 });
            ToolStripDropDownButton8.Image = Properties.Resources.ToolStripDropDownButton8_Image;
            ToolStripDropDownButton8.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton8.Name = "ToolStripDropDownButton8";
            ToolStripDropDownButton8.Size = new Size(29, 22);
            ToolStripDropDownButton8.Text = "Create xex machine format";
            // 
            // RetailToolStripMenuItem
            // 
            RetailToolStripMenuItem.Image = Properties.Resources.RetailToolStripMenuItem_Image;
            RetailToolStripMenuItem.Name = "RetailToolStripMenuItem";
            RetailToolStripMenuItem.Size = new Size(107, 22);
            RetailToolStripMenuItem.Text = "Retail";
            RetailToolStripMenuItem.ToolTipText = "Created from a development xex file a xex file \r\nfor the retail xbox360";
            RetailToolStripMenuItem.Click += RetailToolStripMenuItem_Click;
            // 
            // DevkitToolStripMenuItem
            // 
            DevkitToolStripMenuItem.Image = Properties.Resources.DevkitToolStripMenuItem_Image;
            DevkitToolStripMenuItem.Name = "DevkitToolStripMenuItem";
            DevkitToolStripMenuItem.Size = new Size(107, 22);
            DevkitToolStripMenuItem.Text = "Devkit";
            DevkitToolStripMenuItem.ToolTipText = "Created from a retail xex file a xex file for the \r\nprocessing of a development xbox360";
            DevkitToolStripMenuItem.Click += DevkitToolStripMenuItem_Click;
            // 
            // InfoToolStripMenuItem1
            // 
            InfoToolStripMenuItem1.Image = Properties.Resources.InfoToolStripMenuItem_Image;
            InfoToolStripMenuItem1.Name = "InfoToolStripMenuItem1";
            InfoToolStripMenuItem1.Size = new Size(107, 22);
            InfoToolStripMenuItem1.Text = "Info";
            InfoToolStripMenuItem1.ToolTipText = "Not only will the xex work on a devkit, it will also now work from any media\r\nand run region independently";
            InfoToolStripMenuItem1.Click += InfoToolStripMenuItem1_Click;
            // 
            // ToolStripDropDownButton3
            // 
            ToolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { UncryptedToolStripMenuItem, EncryptedToolStripMenuItem });
            ToolStripDropDownButton3.Image = Properties.Resources.ToolStripDropDownButton3_Image;
            ToolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton3.Name = "ToolStripDropDownButton3";
            ToolStripDropDownButton3.Size = new Size(29, 22);
            ToolStripDropDownButton3.Text = "xex encryption format";
            // 
            // UncryptedToolStripMenuItem
            // 
            UncryptedToolStripMenuItem.Image = Properties.Resources.UncryptedToolStripMenuItem_Image;
            UncryptedToolStripMenuItem.Name = "UncryptedToolStripMenuItem";
            UncryptedToolStripMenuItem.Size = new Size(129, 22);
            UncryptedToolStripMenuItem.Text = "Uncrypted";
            UncryptedToolStripMenuItem.ToolTipText = "xex to be uncrypted";
            UncryptedToolStripMenuItem.Click += UncryptedToolStripMenuItem_Click;
            // 
            // EncryptedToolStripMenuItem
            // 
            EncryptedToolStripMenuItem.Image = Properties.Resources.EncryptedToolStripMenuItem_Image;
            EncryptedToolStripMenuItem.Name = "EncryptedToolStripMenuItem";
            EncryptedToolStripMenuItem.Size = new Size(129, 22);
            EncryptedToolStripMenuItem.Text = "Encrypted";
            EncryptedToolStripMenuItem.ToolTipText = "xex to be encrypted";
            EncryptedToolStripMenuItem.Click += EncryptedToolStripMenuItem_Click;
            // 
            // ToolStripDropDownButton9
            // 
            ToolStripDropDownButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton9.DropDownItems.AddRange(new ToolStripItem[] { XexBasicToolStripMenuItem, XexExtendedToolStripMenuItem });
            ToolStripDropDownButton9.Image = Properties.Resources.ToolStripDropDownButton9_Image;
            ToolStripDropDownButton9.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton9.Name = "ToolStripDropDownButton9";
            ToolStripDropDownButton9.Size = new Size(29, 22);
            ToolStripDropDownButton9.Text = "Xex file info";
            // 
            // XexBasicToolStripMenuItem
            // 
            XexBasicToolStripMenuItem.Image = Properties.Resources.InfoToolStripMenuItem1_Image;
            XexBasicToolStripMenuItem.Name = "XexBasicToolStripMenuItem";
            XexBasicToolStripMenuItem.Size = new Size(144, 22);
            XexBasicToolStripMenuItem.Text = "xex Basic";
            XexBasicToolStripMenuItem.ToolTipText = "Print basic info about an xex file";
            XexBasicToolStripMenuItem.Click += XexBasicToolStripMenuItem_Click;
            // 
            // XexExtendedToolStripMenuItem
            // 
            XexExtendedToolStripMenuItem.Image = Properties.Resources.XexExtendedToolStripMenuItem_Image;
            XexExtendedToolStripMenuItem.Name = "XexExtendedToolStripMenuItem";
            XexExtendedToolStripMenuItem.Size = new Size(144, 22);
            XexExtendedToolStripMenuItem.Text = "xex Extended";
            XexExtendedToolStripMenuItem.ToolTipText = "Print extended info list about xex file\r\nTitle ID, Media ID, Dashversion and\r\nmany more";
            XexExtendedToolStripMenuItem.Click += XexExtendedToolStripMenuItem_Click;
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // ReadInfoToolStripButton
            // 
            ReadInfoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ReadInfoToolStripButton.Image = Properties.Resources.ReadInfoToolStripButton_Image;
            ReadInfoToolStripButton.ImageTransparentColor = Color.Magenta;
            ReadInfoToolStripButton.Name = "ReadInfoToolStripButton";
            ReadInfoToolStripButton.Size = new Size(23, 22);
            ReadInfoToolStripButton.Text = "Read Log";
            ReadInfoToolStripButton.ToolTipText = "Read the xex info log";
            ReadInfoToolStripButton.Click += ReadInfoToolStripButton_Click;
            // 
            // ToolStripDropDownButton10
            // 
            ToolStripDropDownButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripDropDownButton10.DropDownItems.AddRange(new ToolStripItem[] { UncompressedToolStripMenuItem, CompressedToolStripMenuItem, BinaryToolStripMenuItem });
            ToolStripDropDownButton10.Image = Properties.Resources.ToolStripDropDownButton10_Image;
            ToolStripDropDownButton10.ImageTransparentColor = Color.Magenta;
            ToolStripDropDownButton10.Name = "ToolStripDropDownButton10";
            ToolStripDropDownButton10.Size = new Size(29, 22);
            ToolStripDropDownButton10.Text = "xex compression";
            // 
            // UncompressedToolStripMenuItem
            // 
            UncompressedToolStripMenuItem.Image = Properties.Resources.UncompressedToolStripMenuItem_Image;
            UncompressedToolStripMenuItem.Name = "UncompressedToolStripMenuItem";
            UncompressedToolStripMenuItem.Size = new Size(153, 22);
            UncompressedToolStripMenuItem.Text = "Uncompressed";
            UncompressedToolStripMenuItem.ToolTipText = "xex to be uncompressed (no zeroed data)";
            UncompressedToolStripMenuItem.Click += UncompressedToolStripMenuItem_Click;
            // 
            // CompressedToolStripMenuItem
            // 
            CompressedToolStripMenuItem.Image = Properties.Resources.CompressedToolStripMenuItem_Image;
            CompressedToolStripMenuItem.Name = "CompressedToolStripMenuItem";
            CompressedToolStripMenuItem.Size = new Size(153, 22);
            CompressedToolStripMenuItem.Text = "Compressed";
            CompressedToolStripMenuItem.ToolTipText = "xex to be compressed";
            CompressedToolStripMenuItem.Click += CompressedToolStripMenuItem_Click;
            // 
            // BinaryToolStripMenuItem
            // 
            BinaryToolStripMenuItem.Image = Properties.Resources.BinaryToolStripMenuItem_Image;
            BinaryToolStripMenuItem.Name = "BinaryToolStripMenuItem";
            BinaryToolStripMenuItem.Size = new Size(153, 22);
            BinaryToolStripMenuItem.Text = "Binary";
            BinaryToolStripMenuItem.ToolTipText = "xex to be binary (has zeroed data)";
            BinaryToolStripMenuItem.Click += BinaryToolStripMenuItem_Click;
            // 
            // GroupBox6
            // 
            GroupBox6.Controls.Add(SaveButton);
            GroupBox6.Controls.Add(OpenxexpButton);
            GroupBox6.Controls.Add(Label2);
            GroupBox6.Controls.Add(Label8);
            GroupBox6.Controls.Add(Label7);
            GroupBox6.Controls.Add(OpenxexButton);
            GroupBox6.Controls.Add(Label6);
            GroupBox6.Controls.Add(XeXFileTextBox);
            GroupBox6.Controls.Add(XeXpFileTextBox);
            GroupBox6.Controls.Add(SavePatchTextBox);
            GroupBox6.Location = new Point(14, 337);
            GroupBox6.Margin = new Padding(4, 3, 4, 3);
            GroupBox6.Name = "GroupBox6";
            GroupBox6.Padding = new Padding(4, 3, 4, 3);
            GroupBox6.Size = new Size(517, 222);
            GroupBox6.TabIndex = 32;
            GroupBox6.TabStop = false;
            GroupBox6.Text = "Files";
            // 
            // SaveButton
            // 
            SaveButton.Image = Properties.Resources.SaveButton_Image;
            SaveButton.Location = new Point(412, 159);
            SaveButton.Margin = new Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(56, 55);
            SaveButton.TabIndex = 30;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // OpenxexpButton
            // 
            OpenxexpButton.Image = Properties.Resources.OpenxexpButton_Image;
            OpenxexpButton.Location = new Point(412, 97);
            OpenxexpButton.Margin = new Padding(4, 3, 4, 3);
            OpenxexpButton.Name = "OpenxexpButton";
            OpenxexpButton.Size = new Size(56, 55);
            OpenxexpButton.TabIndex = 31;
            OpenxexpButton.UseVisualStyleBackColor = true;
            OpenxexpButton.Click += OpenxexpButton_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(132, 18);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(186, 15);
            Label2.TabIndex = 28;
            Label2.Text = "There must be no spaces available";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.Location = new Point(50, 158);
            Label8.Margin = new Padding(4, 0, 4, 0);
            Label8.Name = "Label8";
            Label8.Size = new Size(110, 13);
            Label8.TabIndex = 23;
            Label8.Text = "Xex Save location";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.Location = new Point(50, 96);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(35, 13);
            Label7.TabIndex = 22;
            Label7.Text = "Xexp";
            // 
            // OpenxexButton
            // 
            OpenxexButton.Image = Properties.Resources.OpenxexButton_Image;
            OpenxexButton.Location = new Point(412, 35);
            OpenxexButton.Margin = new Padding(4, 3, 4, 3);
            OpenxexButton.Name = "OpenxexButton";
            OpenxexButton.Size = new Size(56, 55);
            OpenxexButton.TabIndex = 29;
            OpenxexButton.UseVisualStyleBackColor = true;
            OpenxexButton.Click += OpenxexButton_Click;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.Location = new Point(50, 33);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(28, 13);
            Label6.TabIndex = 21;
            Label6.Text = "Xex";
            // 
            // xexgui
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(546, 605);
            Controls.Add(CheckBox1);
            Controls.Add(Label1);
            Controls.Add(GroupBox6);
            Controls.Add(ToolStrip3);
            Controls.Add(StatusStrip1);
            Controls.Add(ToolStrip1);
            Controls.Add(GroupBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "xexgui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XexToolGUI ";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            StatusStrip1.ResumeLayout(false);
            StatusStrip1.PerformLayout();
            ToolStrip3.ResumeLayout(false);
            ToolStrip3.PerformLayout();
            GroupBox6.ResumeLayout(false);
            GroupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox XLogBox;
        private ProgressBar ProgressBar1;
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

