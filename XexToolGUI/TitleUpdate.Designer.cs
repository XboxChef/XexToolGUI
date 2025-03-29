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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleUpdate));
            Xclosetu = new System.Windows.Forms.Button();
            XUpdatexbuc = new System.Windows.Forms.Button();
            XUpdateJQE360 = new System.Windows.Forms.Button();
            XMediaID = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            GroupBox1 = new System.Windows.Forms.GroupBox();
            Xcleartu = new System.Windows.Forms.Button();
            Label2 = new System.Windows.Forms.Label();
            XGamename = new System.Windows.Forms.TextBox();
            ToolTip1 = new System.Windows.Forms.ToolTip(components);
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Xclosetu
            // 
            Xclosetu.Image = ((System.Drawing.Image)(resources.GetObject("Xclosetu.Image")));
            Xclosetu.Location = new System.Drawing.Point(202, 121);
            Xclosetu.Name = "Xclosetu";
            Xclosetu.Size = new System.Drawing.Size(88, 34);
            Xclosetu.TabIndex = 7;
            Xclosetu.Text = "Cancel";
            Xclosetu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Xclosetu.UseVisualStyleBackColor = true;
            Xclosetu.Click += new System.EventHandler(Xclosetu_Click);
            // 
            // XUpdatexbuc
            // 
            XUpdatexbuc.Image = ((System.Drawing.Image)(resources.GetObject("XUpdatexbuc.Image")));
            XUpdatexbuc.Location = new System.Drawing.Point(202, 37);
            XUpdatexbuc.Name = "XUpdatexbuc";
            XUpdatexbuc.Size = new System.Drawing.Size(88, 34);
            XUpdatexbuc.TabIndex = 0;
            XUpdatexbuc.Text = "xbuc";
            XUpdatexbuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(XUpdatexbuc, "http:\\\\www.xbuc.net");
            XUpdatexbuc.UseVisualStyleBackColor = true;
            XUpdatexbuc.Click += new System.EventHandler(XUpdatexbuc_Click);
            // 
            // XUpdateJQE360
            // 
            XUpdateJQE360.Image = ((System.Drawing.Image)(resources.GetObject("XUpdateJQE360.Image")));
            XUpdateJQE360.Location = new System.Drawing.Point(108, 37);
            XUpdateJQE360.Name = "XUpdateJQE360";
            XUpdateJQE360.Size = new System.Drawing.Size(88, 34);
            XUpdateJQE360.TabIndex = 1;
            XUpdateJQE360.Text = "JQE360";
            XUpdateJQE360.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ToolTip1.SetToolTip(XUpdateJQE360, "http:\\\\www.JQE360.com");
            XUpdateJQE360.UseVisualStyleBackColor = true;
            XUpdateJQE360.Click += new System.EventHandler(XUpdateJQE360_Click);
            // 
            // XMediaID
            // 
            XMediaID.Location = new System.Drawing.Point(9, 45);
            XMediaID.Name = "XMediaID";
            XMediaID.Size = new System.Drawing.Size(77, 20);
            XMediaID.TabIndex = 2;
            ToolTip1.SetToolTip(XMediaID, "Only Media ID");
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(6, 16);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(50, 26);
            Label1.TabIndex = 3;
            Label1.Text = "\r\nMedia ID";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Xcleartu);
            GroupBox1.Controls.Add(Xclosetu);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(XGamename);
            GroupBox1.Controls.Add(XUpdatexbuc);
            GroupBox1.Controls.Add(XUpdateJQE360);
            GroupBox1.Controls.Add(XMediaID);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new System.Drawing.Point(14, 14);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new System.Drawing.Size(299, 166);
            GroupBox1.TabIndex = 7;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Download Title Updates on the following pages";
            // 
            // Xcleartu
            // 
            Xcleartu.Image = ((System.Drawing.Image)(resources.GetObject("Xcleartu.Image")));
            Xcleartu.Location = new System.Drawing.Point(108, 121);
            Xcleartu.Name = "Xcleartu";
            Xcleartu.Size = new System.Drawing.Size(88, 34);
            Xcleartu.TabIndex = 8;
            Xcleartu.Text = "Clear";
            Xcleartu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Xcleartu.UseVisualStyleBackColor = true;
            Xcleartu.Click += new System.EventHandler(Xcleartu_Click);
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new System.Drawing.Point(6, 79);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(66, 13);
            Label2.TabIndex = 5;
            Label2.Text = "Game Name";
            // 
            // XGamename
            // 
            XGamename.Location = new System.Drawing.Point(9, 95);
            XGamename.Name = "XGamename";
            XGamename.Size = new System.Drawing.Size(281, 20);
            XGamename.TabIndex = 4;
            ToolTip1.SetToolTip(XGamename, "Name of the Game");
            // 
            // TitleUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(330, 193);
            Controls.Add(GroupBox1);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "TitleUpdate";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Search TitleUpdate";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(TitleUpdate_FormClosing);
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);

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