namespace XexToolGUI
{
    partial class SpecialPatches
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialPatches));
            XexPathTextBox = new System.Windows.Forms.TextBox();
            OutputPathTextBox = new System.Windows.Forms.TextBox();
            PatchValueTextBox = new System.Windows.Forms.TextBox();
            LogTextBox = new System.Windows.Forms.TextBox();
            BrowseXexButton = new System.Windows.Forms.Button();
            BrowseOutputButton = new System.Windows.Forms.Button();
            ListPatchesButton = new System.Windows.Forms.Button();
            ApplyButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();

            // XexPathTextBox
            XexPathTextBox.Location = new System.Drawing.Point(12, 28);
            XexPathTextBox.Name = "XexPathTextBox";
            XexPathTextBox.Size = new System.Drawing.Size(350, 23);
            XexPathTextBox.TabIndex = 0;

            // OutputPathTextBox
            OutputPathTextBox.Location = new System.Drawing.Point(12, 72);
            OutputPathTextBox.Name = "OutputPathTextBox";
            OutputPathTextBox.Size = new System.Drawing.Size(350, 23);
            OutputPathTextBox.TabIndex = 1;

            // PatchValueTextBox
            PatchValueTextBox.Location = new System.Drawing.Point(12, 116);
            PatchValueTextBox.Name = "PatchValueTextBox";
            PatchValueTextBox.Size = new System.Drawing.Size(100, 23);
            PatchValueTextBox.TabIndex = 2;
            PatchValueTextBox.Text = "-1";

            // LogTextBox
            LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            LogTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            LogTextBox.ForeColor = System.Drawing.SystemColors.Window;
            LogTextBox.Location = new System.Drawing.Point(12, 155);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            LogTextBox.Size = new System.Drawing.Size(460, 200);
            LogTextBox.TabIndex = 3;

            // BrowseXexButton
            BrowseXexButton.Location = new System.Drawing.Point(368, 27);
            BrowseXexButton.Name = "BrowseXexButton";
            BrowseXexButton.Size = new System.Drawing.Size(75, 25);
            BrowseXexButton.TabIndex = 4;
            BrowseXexButton.Text = "Browse...";
            BrowseXexButton.UseVisualStyleBackColor = true;
            BrowseXexButton.Click += BrowseXexButton_Click;

            // BrowseOutputButton
            BrowseOutputButton.Location = new System.Drawing.Point(368, 71);
            BrowseOutputButton.Name = "BrowseOutputButton";
            BrowseOutputButton.Size = new System.Drawing.Size(75, 25);
            BrowseOutputButton.TabIndex = 5;
            BrowseOutputButton.Text = "Browse...";
            BrowseOutputButton.UseVisualStyleBackColor = true;
            BrowseOutputButton.Click += BrowseOutputButton_Click;

            // ListPatchesButton
            ListPatchesButton.Location = new System.Drawing.Point(118, 114);
            ListPatchesButton.Name = "ListPatchesButton";
            ListPatchesButton.Size = new System.Drawing.Size(100, 28);
            ListPatchesButton.TabIndex = 6;
            ListPatchesButton.Text = "List Patches (0)";
            ListPatchesButton.UseVisualStyleBackColor = true;
            ListPatchesButton.Click += ListPatchesButton_Click;

            // ApplyButton
            ApplyButton.Location = new System.Drawing.Point(224, 114);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new System.Drawing.Size(100, 28);
            ApplyButton.TabIndex = 7;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;

            // label1
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Text = "XEX File:";

            // label2
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 54);
            label2.Name = "label2";
            label2.Text = "Output (optional):";

            // label3
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 98);
            label3.Name = "label3";
            label3.Text = "Patch value (-1=all, 0=list):";

            // SpecialPatches
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 367);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(XexPathTextBox);
            Controls.Add(OutputPathTextBox);
            Controls.Add(PatchValueTextBox);
            Controls.Add(LogTextBox);
            Controls.Add(BrowseXexButton);
            Controls.Add(BrowseOutputButton);
            Controls.Add(ListPatchesButton);
            Controls.Add(ApplyButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpecialPatches";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Special XEX Patches";
            FormClosing += SpecialPatches_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox XexPathTextBox;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.TextBox PatchValueTextBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button BrowseXexButton;
        private System.Windows.Forms.Button BrowseOutputButton;
        private System.Windows.Forms.Button ListPatchesButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
