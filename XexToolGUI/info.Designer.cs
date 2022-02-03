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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.XClose = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(610, 134);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(366, 91);
            this.Label1.TabIndex = 5;
            this.Label1.Text = resources.GetString("Label1.Text");
            // 
            // XClose
            // 
            this.XClose.Image = global::XexToolGUI.Properties.Resources.ExitToolStripMenuItem2_Image;
            this.XClose.Location = new System.Drawing.Point(534, 516);
            this.XClose.Name = "XClose";
            this.XClose.Size = new System.Drawing.Size(88, 35);
            this.XClose.TabIndex = 7;
            this.XClose.Text = "Close";
            this.XClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XClose.UseVisualStyleBackColor = true;
            this.XClose.Click += new System.EventHandler(this.XClose_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(3, 7);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.Size = new System.Drawing.Size(597, 317);
            this.TextBox1.TabIndex = 3;
            this.TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(12, 154);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(611, 356);
            this.TabControl1.TabIndex = 8;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TextBox1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(603, 330);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "xex options";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.TextBox2);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(603, 330);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Examples";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(3, 7);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox2.Size = new System.Drawing.Size(597, 317);
            this.TextBox2.TabIndex = 4;
            this.TextBox2.Text = resources.GetString("TextBox2.Text");
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.TextBox3);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(603, 330);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Changelog xextool";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(3, 7);
            this.TextBox3.Multiline = true;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox3.Size = new System.Drawing.Size(597, 317);
            this.TextBox3.TabIndex = 4;
            this.TextBox3.Text = resources.GetString("TextBox3.Text");
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.TextBox4);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(603, 330);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Changelog xextoolGUI";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(3, 7);
            this.TextBox4.Multiline = true;
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox4.Size = new System.Drawing.Size(597, 317);
            this.TextBox4.TabIndex = 5;
            this.TextBox4.Text = resources.GetString("TextBox4.Text");
            // 
            // TabPage5
            // 
            this.TabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.TabPage5.Controls.Add(this.TextBox5);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(603, 330);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Information";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(3, 7);
            this.TextBox5.Multiline = true;
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox5.Size = new System.Drawing.Size(597, 317);
            this.TextBox5.TabIndex = 6;
            this.TextBox5.Text = resources.GetString("TextBox5.Text");
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 556);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.XClose);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.info_FormClosing);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

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