namespace XexToolGUI
{
    partial class info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(info));
            GroupBox1 = new System.Windows.Forms.GroupBox();
            Label1 = new System.Windows.Forms.Label();
            XClose = new System.Windows.Forms.Button();
            TextBox1 = new System.Windows.Forms.TextBox();
            TabControl1 = new System.Windows.Forms.TabControl();
            TabPage1 = new System.Windows.Forms.TabPage();
            TabPage2 = new System.Windows.Forms.TabPage();
            TextBox2 = new System.Windows.Forms.TextBox();
            TabPage3 = new System.Windows.Forms.TabPage();
            TextBox3 = new System.Windows.Forms.TextBox();
            TabPage4 = new System.Windows.Forms.TabPage();
            TextBox4 = new System.Windows.Forms.TextBox();
            TabPage5 = new System.Windows.Forms.TabPage();
            TextBox5 = new System.Windows.Forms.TextBox();
            GroupBox1.SuspendLayout();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            TabPage4.SuspendLayout();
            TabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new System.Drawing.Point(14, 16);
            GroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GroupBox1.Size = new System.Drawing.Size(712, 155);
            GroupBox1.TabIndex = 9;
            GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(10, 18);
            Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(410, 105);
            Label1.TabIndex = 5;
            Label1.Text = resources.GetString("Label1.Text");
            // 
            // XClose
            // 
            XClose.Image = Properties.Resources.ExitToolStripMenuItem2_Image;
            XClose.Location = new System.Drawing.Point(623, 595);
            XClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            XClose.Name = "XClose";
            XClose.Size = new System.Drawing.Size(103, 40);
            XClose.TabIndex = 7;
            XClose.Text = "Close";
            XClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            XClose.UseVisualStyleBackColor = true;
            XClose.Click += XClose_Click;
            // 
            // TextBox1
            // 
            TextBox1.Location = new System.Drawing.Point(4, 8);
            TextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox1.Size = new System.Drawing.Size(696, 365);
            TextBox1.TabIndex = 3;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(TabPage2);
            TabControl1.Controls.Add(TabPage3);
            TabControl1.Controls.Add(TabPage4);
            TabControl1.Controls.Add(TabPage5);
            TabControl1.Location = new System.Drawing.Point(14, 178);
            TabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new System.Drawing.Size(713, 411);
            TabControl1.TabIndex = 8;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(TextBox1);
            TabPage1.Location = new System.Drawing.Point(4, 24);
            TabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage1.Size = new System.Drawing.Size(705, 383);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "xex options";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(TextBox2);
            TabPage2.Location = new System.Drawing.Point(4, 24);
            TabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage2.Size = new System.Drawing.Size(705, 383);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Examples";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBox2
            // 
            TextBox2.Location = new System.Drawing.Point(4, 8);
            TextBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBox2.Multiline = true;
            TextBox2.Name = "TextBox2";
            TextBox2.ReadOnly = true;
            TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox2.Size = new System.Drawing.Size(696, 365);
            TextBox2.TabIndex = 4;
            TextBox2.Text = resources.GetString("TextBox2.Text");
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(TextBox3);
            TabPage3.Location = new System.Drawing.Point(4, 24);
            TabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage3.Name = "TabPage3";
            TabPage3.Size = new System.Drawing.Size(705, 383);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Changelog xextool";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // TextBox3
            // 
            TextBox3.Location = new System.Drawing.Point(4, 8);
            TextBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBox3.Multiline = true;
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox3.Size = new System.Drawing.Size(696, 365);
            TextBox3.TabIndex = 4;
            TextBox3.Text = resources.GetString("TextBox3.Text");
            // 
            // TabPage4
            // 
            TabPage4.Controls.Add(TextBox4);
            TabPage4.Location = new System.Drawing.Point(4, 24);
            TabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage4.Name = "TabPage4";
            TabPage4.Size = new System.Drawing.Size(705, 383);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "Changelog xextoolGUI";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // TextBox4
            // 
            TextBox4.Location = new System.Drawing.Point(4, 8);
            TextBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBox4.Multiline = true;
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox4.Size = new System.Drawing.Size(696, 365);
            TextBox4.TabIndex = 5;
            TextBox4.Text = resources.GetString("TextBox4.Text");
            // 
            // TabPage5
            // 
            TabPage5.BackColor = System.Drawing.SystemColors.Control;
            TabPage5.Controls.Add(TextBox5);
            TabPage5.Location = new System.Drawing.Point(4, 24);
            TabPage5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPage5.Name = "TabPage5";
            TabPage5.Size = new System.Drawing.Size(705, 383);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Information";
            // 
            // TextBox5
            // 
            TextBox5.Location = new System.Drawing.Point(4, 8);
            TextBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextBox5.Multiline = true;
            TextBox5.Name = "TextBox5";
            TextBox5.ReadOnly = true;
            TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox5.Size = new System.Drawing.Size(696, 365);
            TextBox5.TabIndex = 6;
            TextBox5.Text = resources.GetString("TextBox5.Text");
            // 
            // info
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(741, 642);
            Controls.Add(GroupBox1);
            Controls.Add(XClose);
            Controls.Add(TabControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "info";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "info";
            FormClosing += info_FormClosing;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button XClose;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TabPage TabPage3;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TabPage TabPage4;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TabPage TabPage5;
        private System.Windows.Forms.TextBox TextBox5;
    }
}