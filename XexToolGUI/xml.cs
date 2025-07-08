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
            if (CheckBox1.Checked)
            {
                xmlLogBox.AppendText(Environment.NewLine);
                xmlLogBox.AppendText(text + Environment.NewLine);
            }
            else
                xmlLogBox.Text = text;
        }

        private void ProcessOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;
            Invoke((Delegate)new xml.UpdateTextBoxTextDelegate(UpdateTextBoxText), (object)e.Data);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlLogBox.Text = "";
            SearchxexTextBox.Text = "";
            SavexmlTextBox.Text = "";
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
            OpenFileDialog1.ShowDialog();
            SearchxexTextBox.Text = OpenFileDialog1.FileName;
        }

        private void savexmlButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.ShowDialog();
            SavexmlTextBox.Text = SaveFileDialog1.FileName;
        }
        private void CreatexmlButton_Click(object sender, EventArgs e)
        {
            Process(" -x " + SavexmlTextBox.Text + " " + SearchxexTextBox.Text + " >game.xml");
        }
        private void Process(string arg)
        {
                Program.process = new Process();
                Program.process.OutputDataReceived += new DataReceivedEventHandler(ProcessOutputDataReceived);
                Program.ExecuteProcess(arg);
        }
        public delegate void UpdateTextBoxTextDelegate(string text);

        private void xml_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui.Show();
            Program.xml = null;
        }
    }
}
