namespace XexToolGUI
{
    partial class xml
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xml));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.savexmlButton2 = new System.Windows.Forms.Button();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.openxexButton1 = new System.Windows.Forms.Button();
            this.SavexmlTextBox = new System.Windows.Forms.TextBox();
            this.SearchxexTextBox = new System.Windows.Forms.TextBox();
            this.CreatexmlButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.xmlLogBox = new System.Windows.Forms.TextBox();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "xml File|*.xml";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearToolStripMenuItem.Image")));
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InfoToolStripMenuItem.Image")));
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InfoToolStripMenuItem.Text = "Info";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.ToolStrip1.Size = new System.Drawing.Size(398, 25);
            this.ToolStrip1.TabIndex = 21;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "xex File|*.xex";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(44, 92);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 13);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "There must be no spaces available";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(315, 19);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(48, 48);
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // savexmlButton2
            // 
            this.savexmlButton2.Image = ((System.Drawing.Image)(resources.GetObject("savexmlButton2.Image")));
            this.savexmlButton2.Location = new System.Drawing.Point(275, 162);
            this.savexmlButton2.Name = "savexmlButton2";
            this.savexmlButton2.Size = new System.Drawing.Size(88, 34);
            this.savexmlButton2.TabIndex = 14;
            this.savexmlButton2.Text = "Save As";
            this.savexmlButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savexmlButton2.UseVisualStyleBackColor = true;
            this.savexmlButton2.Click += new System.EventHandler(this.savexmlButton2_Click);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Checked = true;
            this.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox1.Location = new System.Drawing.Point(265, 22);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(44, 17);
            this.CheckBox1.TabIndex = 12;
            this.CheckBox1.Text = "Log";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // openxexButton1
            // 
            this.openxexButton1.Image = ((System.Drawing.Image)(resources.GetObject("openxexButton1.Image")));
            this.openxexButton1.Location = new System.Drawing.Point(276, 122);
            this.openxexButton1.Name = "openxexButton1";
            this.openxexButton1.Size = new System.Drawing.Size(88, 34);
            this.openxexButton1.TabIndex = 13;
            this.openxexButton1.Text = "xex";
            this.openxexButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openxexButton1.UseVisualStyleBackColor = true;
            this.openxexButton1.Click += new System.EventHandler(this.openxexButton1_Click);
            // 
            // SavexmlTextBox
            // 
            this.SavexmlTextBox.Location = new System.Drawing.Point(6, 170);
            this.SavexmlTextBox.Name = "SavexmlTextBox";
            this.SavexmlTextBox.Size = new System.Drawing.Size(253, 20);
            this.SavexmlTextBox.TabIndex = 16;
            // 
            // SearchxexTextBox
            // 
            this.SearchxexTextBox.Location = new System.Drawing.Point(6, 130);
            this.SearchxexTextBox.Name = "SearchxexTextBox";
            this.SearchxexTextBox.Size = new System.Drawing.Size(253, 20);
            this.SearchxexTextBox.TabIndex = 15;
            // 
            // CreatexmlButton
            // 
            this.CreatexmlButton.Image = ((System.Drawing.Image)(resources.GetObject("CreatexmlButton.Image")));
            this.CreatexmlButton.Location = new System.Drawing.Point(275, 73);
            this.CreatexmlButton.Name = "CreatexmlButton";
            this.CreatexmlButton.Size = new System.Drawing.Size(88, 34);
            this.CreatexmlButton.TabIndex = 11;
            this.CreatexmlButton.Text = "Create xml";
            this.CreatexmlButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreatexmlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreatexmlButton.UseVisualStyleBackColor = true;
            this.CreatexmlButton.Click += new System.EventHandler(this.CreatexmlButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.PictureBox1);
            this.GroupBox1.Controls.Add(this.xmlLogBox);
            this.GroupBox1.Controls.Add(this.savexmlButton2);
            this.GroupBox1.Controls.Add(this.CheckBox1);
            this.GroupBox1.Controls.Add(this.openxexButton1);
            this.GroupBox1.Controls.Add(this.SavexmlTextBox);
            this.GroupBox1.Controls.Add(this.SearchxexTextBox);
            this.GroupBox1.Controls.Add(this.CreatexmlButton);
            this.GroupBox1.Location = new System.Drawing.Point(12, 28);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(370, 206);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            // 
            // xmlLogBox
            // 
            this.xmlLogBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xmlLogBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.xmlLogBox.Location = new System.Drawing.Point(6, 19);
            this.xmlLogBox.Multiline = true;
            this.xmlLogBox.Name = "xmlLogBox";
            this.xmlLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.xmlLogBox.Size = new System.Drawing.Size(253, 70);
            this.xmlLogBox.TabIndex = 7;
            // 
            // xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xml";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xml Script";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.xml_FormClosing);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Button openxexButton1;
        private System.Windows.Forms.TextBox SavexmlTextBox;
        private System.Windows.Forms.TextBox SearchxexTextBox;
        private System.Windows.Forms.Button CreatexmlButton;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox xmlLogBox;
    }
}