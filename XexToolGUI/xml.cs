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
                Program.Info = new About();
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
        private async void CreatexmlButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchxexTextBox.Text) || !System.IO.File.Exists(SearchxexTextBox.Text))
            {
                MessageBox.Show("Please select a valid XEX file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string outputPath = string.IsNullOrEmpty(SavexmlTextBox.Text)
                ? System.IO.Path.Combine(System.IO.Path.GetDirectoryName(SearchxexTextBox.Text) ?? ".", "game.xml")
                : SavexmlTextBox.Text;
            await CreateXmlWithOptionsAsync(outputPath, "a");
        }

        private async System.Threading.Tasks.Task CreateXmlWithOptionsAsync(string outputPath, string options)
        {
            xmlLogBox.Clear();
            try
            {
                var output = new System.Text.StringBuilder();
                using (var process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = "xextool.exe";
                    process.StartInfo.Arguments = $" -x {options} \"{SearchxexTextBox.Text}\"";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            output.AppendLine(e.Data);
                            Invoke((Delegate)new UpdateTextBoxTextDelegate(UpdateTextBoxText), e.Data);
                        }
                    };
                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            output.AppendLine("ERROR: " + e.Data);
                            Invoke((Delegate)new UpdateTextBoxTextDelegate(UpdateTextBoxText), "ERROR: " + e.Data);
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    await System.Threading.Tasks.Task.Run(() => process.WaitForExit());

                    System.IO.File.WriteAllText(outputPath, output.ToString(), System.Text.Encoding.UTF8);
                    UpdateTextBoxText($"XML saved to: {outputPath}");
                }
            }
            catch (Exception ex)
            {
                UpdateTextBoxText($"Error: {ex.Message}");
                Logger.Error($"XML export failed: {ex.Message}", ex);
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
