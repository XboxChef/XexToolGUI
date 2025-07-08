namespace XexToolGUI
{
    partial class HelpReverse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpReverse));
            PictureBox1 = new System.Windows.Forms.PictureBox();
            TextBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // PictureBox1
            // 
            PictureBox1.Image = XexToolGUI.Properties.Resources.Dumb;
            PictureBox1.Location = new System.Drawing.Point(12, 12);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new System.Drawing.Size(24, 24);
            PictureBox1.TabIndex = 5;
            PictureBox1.TabStop = false;
            // 
            // TextBox1
            // 
            TextBox1.Location = new System.Drawing.Point(42, 12);
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            TextBox1.Size = new System.Drawing.Size(397, 172);
            TextBox1.TabIndex = 4;
            TextBox1.Text = resources.GetString("TextBox1.Text");
            // 
            // HelpReverse
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(451, 196);
            Controls.Add(PictureBox1);
            Controls.Add(TextBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "HelpReverse";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Help Reverse";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(HelpReverse_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox TextBox1;
    }
}