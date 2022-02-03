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
    public partial class xml : Form
    {
        public xml()
        {
            InitializeComponent();
        }


        private void UpdateTextBoxText(string text)
        {
            Debug.WriteLine(text);
            if (this.CheckBox1.Checked)
            {
                this.xmlLogBox.AppendText(Environment.NewLine);
                this.xmlLogBox.AppendText(text + Environment.NewLine);
            }
            else
                this.xmlLogBox.Text = text;
        }

        private void ProcessOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;
            this.Invoke((Delegate)new xml.UpdateTextBoxTextDelegate(this.UpdateTextBoxText), (object)e.Data);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.xmlLogBox.Text = "";
            this.SearchxexTextBox.Text = "";
            this.SavexmlTextBox.Text = "";
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

        private void openxexButton1_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog1.ShowDialog();
            this.SearchxexTextBox.Text = this.OpenFileDialog1.FileName;
        }

        private void savexmlButton2_Click(object sender, EventArgs e)
        {
            int num = (int)this.SaveFileDialog1.ShowDialog();
            this.SavexmlTextBox.Text = this.SaveFileDialog1.FileName;
        }
        private void CreatexmlButton_Click(object sender, EventArgs e)
        {
            Process(" -x " + this.SavexmlTextBox.Text + " " + this.SearchxexTextBox.Text + " >game.xml");
        }
        private void Process(string arg)
        {
            if (Program.process == null)
            {
                Program.process = new Process();
                Program.process.OutputDataReceived += new DataReceivedEventHandler(this.ProcessOutputDataReceived);
                Program.CurrentProcess(arg);
            }
            else
            {
                Program.process.OutputDataReceived += new DataReceivedEventHandler(this.ProcessOutputDataReceived);
                Program.CurrentProcess(arg);
            }
        }
        public delegate void UpdateTextBoxTextDelegate(string text);

        private void xml_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui.Show();
            Program.xml = null;
        }
    }
}
