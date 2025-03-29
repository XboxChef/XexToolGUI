namespace XexToolGUI
{
    partial class Dump
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dump));
            OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            Label1 = new System.Windows.Forms.Label();
            PictureBox1 = new System.Windows.Forms.PictureBox();
            dumpfolder = new System.Windows.Forms.Button();
            XFolder = new System.Windows.Forms.TextBox();
            saveidcButton2 = new System.Windows.Forms.Button();
            ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            ToolStrip1 = new System.Windows.Forms.ToolStrip();
            openxexButton1 = new System.Windows.Forms.Button();
            Dumpall = new System.Windows.Forms.Button();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            Dumpbase = new System.Windows.Forms.Button();
            SavedumpTextBox = new System.Windows.Forms.TextBox();
            SearchxexTextBox = new System.Windows.Forms.TextBox();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            CheckBox1 = new System.Windows.Forms.CheckBox();
            dumpLogBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).BeginInit();
            ToolStrip1.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.Filter = "xex File|*.xex|xexp File|*xexp";
            // 
            // SaveFileDialog1
            // 
            SaveFileDialog1.Filter = "exe File|*.exe|pe File|*.pe|dll File|*.dll|All Files|*.*";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(77, 201);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(172, 13);
            Label1.TabIndex = 20;
            Label1.Text = "There must be no spaces available";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            PictureBox1.Location = new System.Drawing.Point(375, 10);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new System.Drawing.Size(48, 48);
            PictureBox1.TabIndex = 19;
            PictureBox1.TabStop = false;
            // 
            // dumpfolder
            // 
            dumpfolder.Image = ((System.Drawing.Image)(resources.GetObject("dumpfolder.Image")));
            dumpfolder.Location = new System.Drawing.Point(332, 289);
            dumpfolder.Name = "dumpfolder";
            dumpfolder.Size = new System.Drawing.Size(88, 34);
            dumpfolder.TabIndex = 18;
            dumpfolder.Text = "Dump folder";
            dumpfolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(dumpfolder, "Select save location Folder");
            dumpfolder.UseVisualStyleBackColor = true;
            dumpfolder.Click += new System.EventHandler(dumpfolder_Click);
            // 
            // XFolder
            // 
            XFolder.Location = new System.Drawing.Point(6, 297);
            XFolder.Name = "XFolder";
            XFolder.Size = new System.Drawing.Size(320, 20);
            XFolder.TabIndex = 17;
            // 
            // saveidcButton2
            // 
            saveidcButton2.Image = global::XexToolGUI.Properties.Resources.SaveButton_Image;
            saveidcButton2.Location = new System.Drawing.Point(332, 249);
            saveidcButton2.Name = "saveidcButton2";
            saveidcButton2.Size = new System.Drawing.Size(88, 34);
            saveidcButton2.TabIndex = 16;
            saveidcButton2.Text = "Save Basefile";
            saveidcButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(saveidcButton2, "Save As");
            saveidcButton2.UseVisualStyleBackColor = true;
            saveidcButton2.Click += new System.EventHandler(saveidcButton2_Click);
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripMenuItem.Image")));
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            ClearToolStripMenuItem.Text = "Clear";
            ClearToolStripMenuItem.Click += new System.EventHandler(ClearToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripMenuItem.Image")));
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            InfoToolStripMenuItem.Text = "Info";
            InfoToolStripMenuItem.Click += new System.EventHandler(InfoToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            HelpToolStripMenuItem.Text = "Help";
            HelpToolStripMenuItem.Click += new System.EventHandler(HelpToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton1
            // 
            ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            HelpToolStripMenuItem,
            InfoToolStripMenuItem,
            ClearToolStripMenuItem});
            ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            ToolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            ToolStripDropDownButton1.Text = "Help";
            // 
            // ToolStrip1
            // 
            ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            ToolStripDropDownButton1});
            ToolStrip1.Location = new System.Drawing.Point(0, 0);
            ToolStrip1.Name = "ToolStrip1";
            ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            ToolStrip1.Size = new System.Drawing.Size(454, 25);
            ToolStrip1.TabIndex = 11;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // openxexButton1
            // 
            openxexButton1.Image = global::XexToolGUI.Properties.Resources.OpenxexButton_Image;
            openxexButton1.Location = new System.Drawing.Point(332, 209);
            openxexButton1.Name = "openxexButton1";
            openxexButton1.Size = new System.Drawing.Size(88, 34);
            openxexButton1.TabIndex = 15;
            openxexButton1.Text = "xex";
            openxexButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(openxexButton1, "Select xex file");
            openxexButton1.UseVisualStyleBackColor = true;
            openxexButton1.Click += new System.EventHandler(openxexButton1_Click);
            // 
            // Dumpall
            // 
            Dumpall.Image = ((System.Drawing.Image)(resources.GetObject("Dumpall.Image")));
            Dumpall.Location = new System.Drawing.Point(332, 130);
            Dumpall.Name = "Dumpall";
            Dumpall.Size = new System.Drawing.Size(88, 34);
            Dumpall.TabIndex = 9;
            Dumpall.Text = "Dump all";
            Dumpall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(Dumpall, "Dump all resources");
            Dumpall.UseVisualStyleBackColor = true;
            Dumpall.Click += new System.EventHandler(Dumpall_Click);
            // 
            // Dumpbase
            // 
            Dumpbase.Image = ((System.Drawing.Image)(resources.GetObject("Dumpbase.Image")));
            Dumpbase.Location = new System.Drawing.Point(332, 77);
            Dumpbase.Name = "Dumpbase";
            Dumpbase.Size = new System.Drawing.Size(88, 34);
            Dumpbase.TabIndex = 10;
            Dumpbase.Text = "Dump basefile";
            Dumpbase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(Dumpbase, "Dump basefile from xex");
            Dumpbase.UseVisualStyleBackColor = true;
            Dumpbase.Click += new System.EventHandler(Dumpbase_Click);
            // 
            // SavedumpTextBox
            // 
            SavedumpTextBox.Location = new System.Drawing.Point(6, 257);
            SavedumpTextBox.Name = "SavedumpTextBox";
            SavedumpTextBox.Size = new System.Drawing.Size(320, 20);
            SavedumpTextBox.TabIndex = 14;
            // 
            // SearchxexTextBox
            // 
            SearchxexTextBox.Location = new System.Drawing.Point(6, 217);
            SearchxexTextBox.Name = "SearchxexTextBox";
            SearchxexTextBox.Size = new System.Drawing.Size(320, 20);
            SearchxexTextBox.TabIndex = 13;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(PictureBox1);
            GroupBox1.Controls.Add(dumpfolder);
            GroupBox1.Controls.Add(XFolder);
            GroupBox1.Controls.Add(saveidcButton2);
            GroupBox1.Controls.Add(openxexButton1);
            GroupBox1.Controls.Add(SavedumpTextBox);
            GroupBox1.Controls.Add(SearchxexTextBox);
            GroupBox1.Controls.Add(Dumpbase);
            GroupBox1.Controls.Add(Dumpall);
            GroupBox1.Controls.Add(CheckBox1);
            GroupBox1.Controls.Add(dumpLogBox);
            GroupBox1.Location = new System.Drawing.Point(12, 28);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(429, 333);
            GroupBox1.TabIndex = 10;
            GroupBox1.TabStop = false;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBox1.Location = new System.Drawing.Point(339, 186);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new System.Drawing.Size(40, 17);
            CheckBox1.TabIndex = 8;
            CheckBox1.Text = "log";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.Visible = false;
            // 
            // dumpLogBox
            // 
            dumpLogBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dumpLogBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            dumpLogBox.Location = new System.Drawing.Point(6, 19);
            dumpLogBox.Multiline = true;
            dumpLogBox.Name = "dumpLogBox";
            dumpLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dumpLogBox.Size = new System.Drawing.Size(320, 179);
            dumpLogBox.TabIndex = 7;
            // 
            // Dump
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(454, 371);
            Controls.Add(ToolStrip1);
            Controls.Add(GroupBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "Dump";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Xex Dump";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(Dump_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).EndInit();
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button dumpfolder;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.TextBox XFolder;
        private System.Windows.Forms.Button saveidcButton2;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.Button openxexButton1;
        private System.Windows.Forms.Button Dumpall;
        private System.Windows.Forms.Button Dumpbase;
        private System.Windows.Forms.TextBox SavedumpTextBox;
        private System.Windows.Forms.TextBox SearchxexTextBox;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.TextBox dumpLogBox;
    }
}