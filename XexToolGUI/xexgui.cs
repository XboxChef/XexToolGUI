using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace XexToolGUI
{
    public partial class xexgui : Form
    {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string XeXFile { get; set; }
        string XeXUpdate { get; set; }
        string PatchedXEX { get; set; }
        bool TaskFinished { get; set; }

        public xexgui()
        {
            InitializeComponent();
            DoesXexToolExists();
        }

        private static void DoesXexToolExists()
        {
            if (!File.Exists("xextool.exe"))
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\xextool.exe", Properties.Resources.xextool);
                MessageBox.Show("GUI is Ready for Work !", "XexTool.exe Installed !", MessageBoxButtons.OK);

            }
        }


        private void SelectxexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog1.ShowDialog();
            XeXFileTextBox.Text = OpenFileDialog1.FileName;
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog2.ShowDialog();
            XeXpFileTextBox.Text = OpenFileDialog2.FileName;
        }

        private void SavexexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.ShowDialog();
            SavePatchTextBox.Text = SaveFileDialog1.FileName;
        }

        private void OpenxexButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XeXFileTextBox.Text = OpenFileDialog1.FileName;
                string fileName = Path.GetFileName(OpenFileDialog1.FileName);
                XeXFile = Path.Combine(basePath, fileName);
                File.Copy(OpenFileDialog1.FileName, XeXFile, true);
            }
        }

        private void OpenxexpButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                XeXpFileTextBox.Text = OpenFileDialog2.FileName;
                string fileName = Path.GetFileName(OpenFileDialog2.FileName);
                XeXUpdate = Path.Combine(basePath, fileName);
                File.Copy(OpenFileDialog2.FileName, XeXUpdate, true);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePatchTextBox.Text = SaveFileDialog1.FileName;
                string fileName = Path.GetFileName(SaveFileDialog1.FileName);
                PatchedXEX = Path.Combine(basePath, fileName);
            }

        }


        private void ClearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XeXFileTextBox.Text = "";
            XeXpFileTextBox.Text = "";
            SavePatchTextBox.Text = "";
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
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
            Invoke(new UpdateTextBoxTextDelegate(UpdateTextBoxText), e.Data);
        }
        private void UpdateTextBoxText(string text)
        {
            Debug.WriteLine(text);
            if (CheckBox1.Checked)
            {
                XLogBox.AppendText(Environment.NewLine);
                XLogBox.AppendText(text + Environment.NewLine);
                TaskFinished = true;
            }
            else
                XLogBox.Text = text;
        }
        private void BinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -c b  -o " + SavePatchTextBox.Text + "_binary.xex " + XeXFileTextBox.Text);
        }

        private void CompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -c c  -o " + SavePatchTextBox.Text + "_compressed.xex " + XeXFileTextBox.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar1.Increment(20);
            if (ProgressBar1.Value != ProgressBar1.Maximum)
                return;
            Timer1.Stop();
        }

        private void UncompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -c u  -o " + SavePatchTextBox.Text + "_uncompressed.xex " + XeXFileTextBox.Text);
        }

        private void EncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -e e  -o " + SavePatchTextBox.Text + "_encrypted.xex " + XeXFileTextBox.Text);
        }

        private void UncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -e u  -o " + SavePatchTextBox.Text + "_uncrypted.xex " + XeXFileTextBox.Text);
        }
        public delegate void UpdateTextBoxTextDelegate(string text);
        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void BackupxexToolStripButton_Click(object sender, EventArgs e)
        {
            string text = XeXFileTextBox.Text;
            string Destination = XeXFileTextBox.Text + ".BAK";
            if (!File.Exists(XeXFileTextBox.Text))
            {
                MessageBox.Show("No xex File selected !","Does not exist",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                OpenFileDialog1.ShowDialog();
                Application.Restart();
            }
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Stop();
            File.Copy(text, Destination);
            MessageBox.Show("Backup from *" + XeXFileTextBox.Text + "* Successfully !", "Successfully !",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private bool IsFileReady(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return stream.Length > 0;
                }
            }
            catch (IOException)
            {
                return false; // File is locked or doesn't exist
            }
            catch (Exception)
            {
                return false; // Other error
            }
        }
        private bool WaitForCompleteFile(string filePath, int timeoutSeconds = 30)
        {
            DateTime startTime = DateTime.Now;
            TimeSpan timeout = TimeSpan.FromSeconds(timeoutSeconds);

            while (DateTime.Now - startTime < timeout)
            {
                if (File.Exists(filePath))
                {
                    if (IsFileReady(filePath))
                    {
                        return true; // File is ready and has bytes
                    }
                }

                Thread.Sleep(250); // Wait 250ms before checking again
            }

            return false; // Timeout reached
        }
        private void PatchxexToolStripButton_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -u -p " + XeXUpdate + " -o " + PatchedXEX + " " + XeXFile);

            // Wait for the patched file to be created and completed
            if (WaitForCompleteFile(PatchedXEX, 60)) // Wait up to 60 seconds
            {
                try
                {
                    File.Delete(XeXUpdate);
                    File.Delete(XeXFile);
                    string UserFilename = Path.GetFileName(SavePatchTextBox.Text);
                    string SavePath = Path.GetDirectoryName(SavePatchTextBox.Text);
                    File.Move(PatchedXEX, SavePatchTextBox.Text);

                    MessageBox.Show("Patching completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during file operations: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Timeout waiting for patched file to complete.", "Timeout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear2ToolStripButton_Click(object sender, EventArgs e)
        {
            XeXFileTextBox.Text = "";
            XeXpFileTextBox.Text = "";
            SavePatchTextBox.Text = "";
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
        }

        private void RegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  r " + XeXFileTextBox.Text);
        }

        private void MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  m " + XeXFileTextBox.Text);
        }

        private void DashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  l " + XeXFileTextBox.Text);
        }

        private void PathnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  b " + XeXFileTextBox.Text);
        }

        private void Process(string arg)
        {
                Program.process = new Process();
                Program.process.OutputDataReceived += new DataReceivedEventHandler(ProcessOutputDataReceived);
                Program.CurrentProcess(arg);
        }

        private void KeyvaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  k " + XeXFileTextBox.Text);
        }

        private void RequiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  c " + XeXFileTextBox.Text);
        }

        private void ZeroIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  z " + XeXFileTextBox.Text);
        }
        private void AP25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -r  a " + XeXFileTextBox.Text);
        }

        private void RetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -m  r " + XeXFileTextBox.Text);
        }

        private void DevkitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            Process(" -m  d " + XeXFileTextBox.Text);
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
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            XLogBox.Text = "Create Basic Info file with XeXTool GUI\r\n----------------------------------------------------\r\n";
            Process(XeXFileTextBox.Text);
            DeleteLog();
        }

        private void XexExtendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("XeX Log");
            XLogBox.Text = "";
            ProgressBar1.Value = ProgressBar1.Minimum;
            Timer1.Start();
            XLogBox.Text = "Create Extended Info file with XeXTool GUI\r\n----------------------------------------------------------\r\n"; 
            Process(" -l " + XeXFileTextBox.Text);
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
                File.WriteAllText("XeX Log\\xex_InfoLog.cfg", XLogBox.Text);

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

        private void SavexexToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
