using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    public partial class Dump : Form
    {
        public Dump()
        {
            InitializeComponent();
        }
        private void Process(string arg)
        {
            Program.process = new Process();
            Program.process.OutputDataReceived += new DataReceivedEventHandler(this.ProcessOutputDataReceived);
            Program.CurrentProcess(arg);
        }
        private void Dumpbase_Click(object sender, EventArgs e)
        {
            this.dumpLogBox.Text = "";
            Process(" -b " + this.SavedumpTextBox.Text + " " + this.SearchxexTextBox.Text);

        }

        private void Dumpall_Click(object sender, EventArgs e)
        {
            this.dumpLogBox.Text = "";
            Process(" -d " + this.XFolder.Text + " " + this.SearchxexTextBox.Text);
        }

        private void openxexButton1_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog1.ShowDialog();
            this.SearchxexTextBox.Text = this.OpenFileDialog1.FileName;
        }

        private void saveidcButton2_Click(object sender, EventArgs e)
        {
            int num = (int)this.SaveFileDialog1.ShowDialog();
            this.SavedumpTextBox.Text = this.SaveFileDialog1.FileName;
        }

        private void dumpfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                XFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.HelpReverse == null)
            {
                Program.HelpReverse = new HelpReverse();
            }
            Hide();
            Program.HelpReverse.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Info == null)
            {
                Program.Info = new info();
            }
            Hide();
            Program.Info.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dumpLogBox.Text = "";
            this.SearchxexTextBox.Text = "";
            this.SavedumpTextBox.Text = "";
            this.XFolder.Text = "";
        }
        private void UpdateTextBoxText(string text)
        {
            Debug.WriteLine(text);
            if (this.CheckBox1.Checked)
            {
                this.dumpLogBox.AppendText(Environment.NewLine);
                this.dumpLogBox.AppendText(text + Environment.NewLine);
            }
            else
                this.dumpLogBox.Text = text;
        }

        private void ProcessOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;
            this.Invoke((Delegate)new Dump.UpdateTextBoxTextDelegate(this.UpdateTextBoxText), (object)e.Data);
        }
        public delegate void UpdateTextBoxTextDelegate(string text);

        private void Dump_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui.Show();
            Program.Dump = null;
        }
    }
}
