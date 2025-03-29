namespace XexToolGUI
{
    partial class IDCScript
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDCScript));
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            ToolStrip1 = new System.Windows.Forms.ToolStrip();
            OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Label1 = new System.Windows.Forms.Label();
            PictureBox1 = new System.Windows.Forms.PictureBox();
            savexmlButton2 = new System.Windows.Forms.Button();
            openxexButton1 = new System.Windows.Forms.Button();
            SaveidcTextBox = new System.Windows.Forms.TextBox();
            SearchxexTextBox = new System.Windows.Forms.TextBox();
            CreateidcButton = new System.Windows.Forms.Button();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            CheckBox1 = new System.Windows.Forms.CheckBox();
            idcLogBox = new System.Windows.Forms.TextBox();
            ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).BeginInit();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveFileDialog1
            // 
            SaveFileDialog1.Filter = "xml File|*.xml";
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripMenuItem.Image")));
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            ClearToolStripMenuItem.Text = "Clear";
            ClearToolStripMenuItem.Click += new System.EventHandler(ClearToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripMenuItem.Image")));
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            InfoToolStripMenuItem.Text = "Info";
            InfoToolStripMenuItem.Click += new System.EventHandler(InfoToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            ToolStrip1.Size = new System.Drawing.Size(398, 25);
            ToolStrip1.TabIndex = 21;
            ToolStrip1.Text = "ToolStrip1";
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.Filter = "xex File|*.xex";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(44, 92);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(172, 13);
            Label1.TabIndex = 18;
            Label1.Text = "There must be no spaces available";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            PictureBox1.Location = new System.Drawing.Point(315, 19);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new System.Drawing.Size(48, 48);
            PictureBox1.TabIndex = 17;
            PictureBox1.TabStop = false;
            // 
            // savexmlButton2
            // 
            savexmlButton2.Image = ((System.Drawing.Image)(resources.GetObject("savexmlButton2.Image")));
            savexmlButton2.Location = new System.Drawing.Point(275, 162);
            savexmlButton2.Name = "savexmlButton2";
            savexmlButton2.Size = new System.Drawing.Size(88, 34);
            savexmlButton2.TabIndex = 14;
            savexmlButton2.Text = "Save As";
            savexmlButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            savexmlButton2.UseVisualStyleBackColor = true;
            // 
            // openxexButton1
            // 
            openxexButton1.Image = ((System.Drawing.Image)(resources.GetObject("openxexButton1.Image")));
            openxexButton1.Location = new System.Drawing.Point(276, 122);
            openxexButton1.Name = "openxexButton1";
            openxexButton1.Size = new System.Drawing.Size(88, 34);
            openxexButton1.TabIndex = 13;
            openxexButton1.Text = "xex";
            openxexButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            openxexButton1.UseVisualStyleBackColor = true;
            openxexButton1.Click += new System.EventHandler(openxexButton1_Click);
            // 
            // SaveidcTextBox
            // 
            SaveidcTextBox.Location = new System.Drawing.Point(6, 170);
            SaveidcTextBox.Name = "SaveidcTextBox";
            SaveidcTextBox.Size = new System.Drawing.Size(253, 20);
            SaveidcTextBox.TabIndex = 16;
            // 
            // SearchxexTextBox
            // 
            SearchxexTextBox.Location = new System.Drawing.Point(6, 130);
            SearchxexTextBox.Name = "SearchxexTextBox";
            SearchxexTextBox.Size = new System.Drawing.Size(253, 20);
            SearchxexTextBox.TabIndex = 15;
            // 
            // CreateidcButton
            // 
            CreateidcButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateidcButton.Image")));
            CreateidcButton.Location = new System.Drawing.Point(275, 73);
            CreateidcButton.Name = "CreateidcButton";
            CreateidcButton.Size = new System.Drawing.Size(88, 34);
            CreateidcButton.TabIndex = 11;
            CreateidcButton.Text = "Create idc";
            CreateidcButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            CreateidcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            CreateidcButton.UseVisualStyleBackColor = true;
            CreateidcButton.Click += new System.EventHandler(CreateidcButton_Click);
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(CheckBox1);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Controls.Add(PictureBox1);
            GroupBox1.Controls.Add(idcLogBox);
            GroupBox1.Controls.Add(savexmlButton2);
            GroupBox1.Controls.Add(openxexButton1);
            GroupBox1.Controls.Add(SaveidcTextBox);
            GroupBox1.Controls.Add(SearchxexTextBox);
            GroupBox1.Controls.Add(CreateidcButton);
            GroupBox1.Location = new System.Drawing.Point(12, 28);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(370, 206);
            GroupBox1.TabIndex = 20;
            GroupBox1.TabStop = false;
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Checked = true;
            CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            CheckBox1.Location = new System.Drawing.Point(265, 22);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new System.Drawing.Size(44, 17);
            CheckBox1.TabIndex = 19;
            CheckBox1.Text = "Log";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.Visible = false;
            // 
            // idcLogBox
            // 
            idcLogBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            idcLogBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            idcLogBox.Location = new System.Drawing.Point(6, 19);
            idcLogBox.Multiline = true;
            idcLogBox.Name = "idcLogBox";
            idcLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            idcLogBox.Size = new System.Drawing.Size(253, 70);
            idcLogBox.TabIndex = 7;
            // 
            // IDCScript
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(398, 246);
            Controls.Add(ToolStrip1);
            Controls.Add(GroupBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "IDCScript";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "IDC Script";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(IDCScript_FormClosing);
            ToolStrip1.ResumeLayout(false);
            ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button savexmlButton2;
        private System.Windows.Forms.Button openxexButton1;
        private System.Windows.Forms.TextBox SaveidcTextBox;
        private System.Windows.Forms.TextBox SearchxexTextBox;
        private System.Windows.Forms.Button CreateidcButton;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox idcLogBox;
        private System.Windows.Forms.CheckBox CheckBox1;
    }
}