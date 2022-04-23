using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
namespace XexToolGUI
{
    public partial class xexgui : Form
    {


        public xexgui()
        {
            InitializeComponent();
            if (!File.Exists("xextool.exe"))
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\xextool.exe", Properties.Resources.xextool);
                MessageBox.Show("GUI is Ready for Work !", "XexTool.exe Found !", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("GUI is Ready for Work !", "XexTool.exe Found !", MessageBoxButtons.OK);
            }
        }
        


        private void SelectxexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog1.ShowDialog();
            this.XeXFileTextBox.Text = this.OpenFileDialog1.FileName;
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog2.ShowDialog();
            this.XeXpFileTextBox.Text = this.OpenFileDialog2.FileName;
        }

        private void SavexexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = (int)this.SaveFileDialog1.ShowDialog();
            this.SavePatchTextBox.Text = this.SaveFileDialog1.FileName;
        }

        private void OpenxexButton_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog1.ShowDialog();
            this.XeXFileTextBox.Text = this.OpenFileDialog1.FileName;
        }

        private void OpenxexpButton_Click(object sender, EventArgs e)
        {
            int num = (int)this.OpenFileDialog2.ShowDialog();
            this.XeXpFileTextBox.Text = this.OpenFileDialog2.FileName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int num = (int)this.SaveFileDialog1.ShowDialog();
            this.SavePatchTextBox.Text = this.SaveFileDialog1.FileName;
        }


        private void ClearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.XeXFileTextBox.Text = "";
            this.XeXpFileTextBox.Text = "";
            this.SavePatchTextBox.Text = "";
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
        }

        private void ExitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteLog();
            Close();
            
        }
        private void ProcessOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;
            Invoke(new UpdateTextBoxTextDelegate(this.UpdateTextBoxText), (object)e.Data);
        }
        private void UpdateTextBoxText(string text)
        {
            Debug.WriteLine(text);
            if (CheckBox1.Checked)
            {
                XLogBox.AppendText(Environment.NewLine);
                XLogBox.AppendText(text + Environment.NewLine);
            }
            else
                XLogBox.Text = text;
        }
        private void BinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -c b  -o " + this.SavePatchTextBox.Text + "_binary.xex " + this.XeXFileTextBox.Text);
        }

        private void CompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -c c  -o " + this.SavePatchTextBox.Text + "_compressed.xex " + this.XeXFileTextBox.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(20);
            if (this.ProgressBar1.Value != this.ProgressBar1.Maximum)
                return;
            this.Timer1.Stop();
        }

        private void UncompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -c u  -o " + this.SavePatchTextBox.Text + "_uncompressed.xex " + this.XeXFileTextBox.Text);
        }

        private void EncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -e e  -o " + this.SavePatchTextBox.Text + "_encrypted.xex " + this.XeXFileTextBox.Text);
        }

        private void UncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -e u  -o " + this.SavePatchTextBox.Text + "_uncrypted.xex " + this.XeXFileTextBox.Text);
        }
        public delegate void UpdateTextBoxTextDelegate(string text);
        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void BackupxexToolStripButton_Click(object sender, EventArgs e)
        {
            string text = this.XeXFileTextBox.Text;
            string Destination = this.XeXFileTextBox.Text + ".BAK";
            if (!File.Exists(this.XeXFileTextBox.Text))
            {
                MessageBox.Show("No xex File selected !","Does not exist",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                OpenFileDialog1.ShowDialog();
                Application.Restart();
            }
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Stop();
            File.Copy(text, Destination);
            MessageBox.Show("Backup from *" + this.XeXFileTextBox.Text + "* Successfully !", "Successfully !",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void PatchxexToolStripButton_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -u -p " + this.XeXpFileTextBox.Text + " -o " + this.SavePatchTextBox.Text + " " + this.XeXFileTextBox.Text);
        }

        private void Clear2ToolStripButton_Click(object sender, EventArgs e)
        {
            this.XeXFileTextBox.Text = "";
            this.XeXpFileTextBox.Text = "";
            this.SavePatchTextBox.Text = "";
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
        }

        private void RegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  r " + this.XeXFileTextBox.Text);
        }

        private void MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  m " + this.XeXFileTextBox.Text);
        }

        private void DashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  l " + this.XeXFileTextBox.Text);
        }

        private void PathnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  b " + this.XeXFileTextBox.Text);
        }

        private void Process(string arg)
        {
                Program.process = new Process();
                Program.process.OutputDataReceived += new DataReceivedEventHandler(this.ProcessOutputDataReceived);
                Program.CurrentProcess(arg);
        }

        private void KeyvaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  k " + this.XeXFileTextBox.Text);
        }

        private void RequiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  c " + this.XeXFileTextBox.Text);
        }

        private void ZeroIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  z " + this.XeXFileTextBox.Text);
        }
        private void AP25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -r  a " + this.XeXFileTextBox.Text);
        }

        private void RetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -m  r " + this.XeXFileTextBox.Text);
        }

        private void DevkitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            Process(" -m  d " + this.XeXFileTextBox.Text);
        }

        private void InfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.Info == null)
            {
                Program.Info = new info();
            }
            Hide();
            Program.Info.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void XexBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("XeX Log");
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            this.XLogBox.Text = "Create Basic Info file with XeXTool GUI\r\n----------------------------------------------------\r\n";
            Process(this.XeXFileTextBox.Text);
            DeleteLog();
        }

        private void XexExtendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("XeX Log");
            this.XLogBox.Text = "";
            this.ProgressBar1.Value = this.ProgressBar1.Minimum;
            this.Timer1.Start();
            this.XLogBox.Text = "Create Extended Info file with XeXTool GUI\r\n----------------------------------------------------------\r\n"; 
            Process(" -l " + this.XeXFileTextBox.Text);
            DeleteLog();

        }

        private void DeleteLog()
        {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\XeX Log\"))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\XeX Log\");
            }
            else if (Directory.Exists(Directory.GetCurrentDirectory() + @"\XeX Log\"))
            {
                if (File.Exists("XeX Log\\xex_InfoLog.cfg"))
                {
                    File.Delete("XeX Log\\xex_InfoLog.cfg");
                }
            }
        }

        private void ReadInfoToolStripButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("XeX Log\\xex_InfoLog.cfg"))
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\XeX Log\"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\XeX Log\");
                }
                File.WriteAllText("XeX Log\\xex_InfoLog.cfg", this.XLogBox.Text);

            }
            Interaction.Shell("C:\\Windows\\Notepad.exe XeX Log\\xex_InfoLog.cfg", AppWinStyle.NormalFocus);
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
        private void CMDToolStripMenuItem_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("C:\\Windows\\System32\\cmd.exe");

        private void HxDToolStripMenuItem1_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Apps\\HxD.exe");

        private void WxPirsToolStripMenuItem_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Apps\\wxPirs.exe");

        private void TitleUpdatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.TitleUpdate == null)
            {
                Program.TitleUpdate = new TitleUpdate();
            }
            Hide();
            Program.TitleUpdate.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void IdcFileForIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.IDCScript == null)
            {
                Program.IDCScript = new IDCScript();
            }
            Hide();
            Program.IDCScript.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void DumbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Dump == null)
            {
                Program.Dump = new Dump();
            }
            Hide();
            Program.Dump.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }
        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.xml == null)
            {
                Program.xml = new xml();
            }
            Hide();
            Program.xml.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void HelpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(Directory.GetCurrentDirectory() + @"\help\howto\"))
            {
                System.Diagnostics.Process.Start(Directory.GetCurrentDirectory() + @"\help\howto\xexpatch.htm");
            }
            else
            {
                MessageBox.Show("Missing Assets: "+ @"\help\howto\xexpatch.htm");
            }
        }

        private void InfoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Program.Info == null)
            {
                Program.Info = new info();
            }
            Hide();
            Program.Info.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.About == null)
            {
                Program.About = new About();  //Add event Handler to cleanup after form closes
            }
            Hide();
            Program.About.ShowDialog(this);  //Show Form assigning this form as the forms owner
        }
    }
}
