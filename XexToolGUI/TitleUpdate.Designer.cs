using System;

namespace XexToolGUI
{
    partial class TitleUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleUpdate));
            this.Xclosetu = new System.Windows.Forms.Button();
            this.XUpdatexbuc = new System.Windows.Forms.Button();
            this.XUpdateJQE360 = new System.Windows.Forms.Button();
            this.XMediaID = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Xcleartu = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.XGamename = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Xclosetu
            // 
            this.Xclosetu.Image = ((System.Drawing.Image)(resources.GetObject("Xclosetu.Image")));
            this.Xclosetu.Location = new System.Drawing.Point(202, 121);
            this.Xclosetu.Name = "Xclosetu";
            this.Xclosetu.Size = new System.Drawing.Size(88, 34);
            this.Xclosetu.TabIndex = 7;
            this.Xclosetu.Text = "Cancel";
            this.Xclosetu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xclosetu.UseVisualStyleBackColor = true;
            this.Xclosetu.Click += new System.EventHandler(this.Xclosetu_Click);
            // 
            // XUpdatexbuc
            // 
            this.XUpdatexbuc.Image = ((System.Drawing.Image)(resources.GetObject("XUpdatexbuc.Image")));
            this.XUpdatexbuc.Location = new System.Drawing.Point(202, 37);
            this.XUpdatexbuc.Name = "XUpdatexbuc";
            this.XUpdatexbuc.Size = new System.Drawing.Size(88, 34);
            this.XUpdatexbuc.TabIndex = 0;
            this.XUpdatexbuc.Text = "xbuc";
            this.XUpdatexbuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.XUpdatexbuc, "http:\\\\www.xbuc.net");
            this.XUpdatexbuc.UseVisualStyleBackColor = true;
            this.XUpdatexbuc.Click += new System.EventHandler(this.XUpdatexbuc_Click);
            // 
            // XUpdateJQE360
            // 
            this.XUpdateJQE360.Image = ((System.Drawing.Image)(resources.GetObject("XUpdateJQE360.Image")));
            this.XUpdateJQE360.Location = new System.Drawing.Point(108, 37);
            this.XUpdateJQE360.Name = "XUpdateJQE360";
            this.XUpdateJQE360.Size = new System.Drawing.Size(88, 34);
            this.XUpdateJQE360.TabIndex = 1;
            this.XUpdateJQE360.Text = "JQE360";
            this.XUpdateJQE360.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ToolTip1.SetToolTip(this.XUpdateJQE360, "http:\\\\www.JQE360.com");
            this.XUpdateJQE360.UseVisualStyleBackColor = true;
            this.XUpdateJQE360.Click += new System.EventHandler(this.XUpdateJQE360_Click);
            // 
            // XMediaID
            // 
            this.XMediaID.Location = new System.Drawing.Point(9, 45);
            this.XMediaID.Name = "XMediaID";
            this.XMediaID.Size = new System.Drawing.Size(77, 20);
            this.XMediaID.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.XMediaID, "Only Media ID");
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 26);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "\r\nMedia ID";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Xcleartu);
            this.GroupBox1.Controls.Add(this.Xclosetu);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.XGamename);
            this.GroupBox1.Controls.Add(this.XUpdatexbuc);
            this.GroupBox1.Controls.Add(this.XUpdateJQE360);
            this.GroupBox1.Controls.Add(this.XMediaID);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(14, 14);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(299, 166);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Download Title Updates on the following pages";
            // 
            // Xcleartu
            // 
            this.Xcleartu.Image = ((System.Drawing.Image)(resources.GetObject("Xcleartu.Image")));
            this.Xcleartu.Location = new System.Drawing.Point(108, 121);
            this.Xcleartu.Name = "Xcleartu";
            this.Xcleartu.Size = new System.Drawing.Size(88, 34);
            this.Xcleartu.TabIndex = 8;
            this.Xcleartu.Text = "Clear";
            this.Xcleartu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xcleartu.UseVisualStyleBackColor = true;
            this.Xcleartu.Click += new System.EventHandler(this.Xcleartu_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Game Name";
            // 
            // XGamename
            // 
            this.XGamename.Location = new System.Drawing.Point(9, 95);
            this.XGamename.Name = "XGamename";
            this.XGamename.Size = new System.Drawing.Size(281, 20);
            this.XGamename.TabIndex = 4;
            this.ToolTip1.SetToolTip(this.XGamename, "Name of the Game");
            // 
            // TitleUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 193);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TitleUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search TitleUpdate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TitleUpdate_FormClosing);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        public System.Windows.Forms.Button Xclosetu;
        public System.Windows.Forms.Button XUpdatexbuc;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button XUpdateJQE360;
        public System.Windows.Forms.TextBox XMediaID;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.Button Xcleartu;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.TextBox XGamename;
    }
}