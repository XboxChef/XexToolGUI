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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dump));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.dumpfolder = new System.Windows.Forms.Button();
            this.XFolder = new System.Windows.Forms.TextBox();
            this.saveidcButton2 = new System.Windows.Forms.Button();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openxexButton1 = new System.Windows.Forms.Button();
            this.Dumpall = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Dumpbase = new System.Windows.Forms.Button();
            this.SavedumpTextBox = new System.Windows.Forms.TextBox();
            this.SearchxexTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.dumpLogBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "xex File|*.xex|xexp File|*xexp";
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "exe File|*.exe|pe File|*.pe|dll File|*.dll|All Files|*.*";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(77, 201);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 13);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "There must be no spaces available";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(375, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 48);
            this.PictureBox1.TabIndex = 19;
            this.PictureBox1.TabStop = false;
            // 
            // dumpfolder
            // 
            this.dumpfolder.Image = ((System.Drawing.Image)(resources.GetObject("dumpfolder.Image")));
            this.dumpfolder.Location = new System.Drawing.Point(332, 289);
            this.dumpfolder.Name = "dumpfolder";
            this.dumpfolder.Size = new System.Drawing.Size(88, 34);
            this.dumpfolder.TabIndex = 18;
            this.dumpfolder.Text = "Dump folder";
            this.dumpfolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.dumpfolder, "Select save location Folder");
            this.dumpfolder.UseVisualStyleBackColor = true;
            this.dumpfolder.Click += new System.EventHandler(this.dumpfolder_Click);
            // 
            // XFolder
            // 
            this.XFolder.Location = new System.Drawing.Point(6, 297);
            this.XFolder.Name = "XFolder";
            this.XFolder.Size = new System.Drawing.Size(320, 20);
            this.XFolder.TabIndex = 17;
            // 
            // saveidcButton2
            // 
            this.saveidcButton2.Image = global::XexToolGUI.Properties.Resources.SaveButton_Image;
            this.saveidcButton2.Location = new System.Drawing.Point(332, 249);
            this.saveidcButton2.Name = "saveidcButton2";
            this.saveidcButton2.Size = new System.Drawing.Size(88, 34);
            this.saveidcButton2.TabIndex = 16;
            this.saveidcButton2.Text = "Save Basefile";
            this.saveidcButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.saveidcButton2, "Save As");
            this.saveidcButton2.UseVisualStyleBackColor = true;
            this.saveidcButton2.Click += new System.EventHandler(this.saveidcButton2_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripMenuItem.Image")));
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripMenuItem.Image")));
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.InfoToolStripMenuItem.Text = "Info";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.HelpToolStripMenuItem.Text = "Help";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.InfoToolStripMenuItem,
            this.ClearToolStripMenuItem});
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
            this.ToolStripDropDownButton1.Text = "Help";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(454, 25);
            this.ToolStrip1.TabIndex = 11;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // openxexButton1
            // 
            this.openxexButton1.Image = global::XexToolGUI.Properties.Resources.OpenxexButton_Image;
            this.openxexButton1.Location = new System.Drawing.Point(332, 209);
            this.openxexButton1.Name = "openxexButton1";
            this.openxexButton1.Size = new System.Drawing.Size(88, 34);
            this.openxexButton1.TabIndex = 15;
            this.openxexButton1.Text = "xex";
            this.openxexButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.openxexButton1, "Select xex file");
            this.openxexButton1.UseVisualStyleBackColor = true;
            this.openxexButton1.Click += new System.EventHandler(this.openxexButton1_Click);
            // 
            // Dumpall
            // 
            this.Dumpall.Image = ((System.Drawing.Image)(resources.GetObject("Dumpall.Image")));
            this.Dumpall.Location = new System.Drawing.Point(332, 130);
            this.Dumpall.Name = "Dumpall";
            this.Dumpall.Size = new System.Drawing.Size(88, 34);
            this.Dumpall.TabIndex = 9;
            this.Dumpall.Text = "Dump all";
            this.Dumpall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.Dumpall, "Dump all resources");
            this.Dumpall.UseVisualStyleBackColor = true;
            this.Dumpall.Click += new System.EventHandler(this.Dumpall_Click);
            // 
            // Dumpbase
            // 
            this.Dumpbase.Image = ((System.Drawing.Image)(resources.GetObject("Dumpbase.Image")));
            this.Dumpbase.Location = new System.Drawing.Point(332, 77);
            this.Dumpbase.Name = "Dumpbase";
            this.Dumpbase.Size = new System.Drawing.Size(88, 34);
            this.Dumpbase.TabIndex = 10;
            this.Dumpbase.Text = "Dump basefile";
            this.Dumpbase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.Dumpbase, "Dump basefile from xex");
            this.Dumpbase.UseVisualStyleBackColor = true;
            this.Dumpbase.Click += new System.EventHandler(this.Dumpbase_Click);
            // 
            // SavedumpTextBox
            // 
            this.SavedumpTextBox.Location = new System.Drawing.Point(6, 257);
            this.SavedumpTextBox.Name = "SavedumpTextBox";
            this.SavedumpTextBox.Size = new System.Drawing.Size(320, 20);
            this.SavedumpTextBox.TabIndex = 14;
            // 
            // SearchxexTextBox
            // 
            this.SearchxexTextBox.Location = new System.Drawing.Point(6, 217);
            this.SearchxexTextBox.Name = "SearchxexTextBox";
            this.SearchxexTextBox.Size = new System.Drawing.Size(320, 20);
            this.SearchxexTextBox.TabIndex = 13;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.dumpfolder);
            this.GroupBox1.Controls.Add(this.XFolder);
            this.GroupBox1.Controls.Add(this.saveidcButton2);
            this.GroupBox1.Controls.Add(this.openxexButton1);
            this.GroupBox1.Controls.Add(this.SavedumpTextBox);
            this.GroupBox1.Controls.Add(this.SearchxexTextBox);
            this.GroupBox1.Controls.Add(this.Dumpbase);
            this.GroupBox1.Controls.Add(this.Dumpall);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.dumpLogBox);
            this.GroupBox1.Location = new System.Drawing.Point(12, 28);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(429, 333);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(339, 186);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(40, 17);
            this.CheckBox1.TabIndex = 8;
            this.CheckBox1.Text = "log";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // dumpLogBox
            // 
            this.dumpLogBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dumpLogBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dumpLogBox.Location = new System.Drawing.Point(6, 19);
            this.dumpLogBox.Multiline = true;
            this.dumpLogBox.Name = "dumpLogBox";
            this.dumpLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dumpLogBox.Size = new System.Drawing.Size(320, 179);
            this.dumpLogBox.TabIndex = 7;
            // 
            // Dump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 371);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xex Dump";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dump_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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