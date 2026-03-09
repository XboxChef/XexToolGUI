using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    public partial class SpecialPatches : Form
    {
        public SpecialPatches()
        {
            InitializeComponent();
        }

        private async void ListPatchesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XexPathTextBox.Text) || !File.Exists(XexPathTextBox.Text))
            {
                MessageBox.Show("Please select a valid XEX file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LogTextBox.Clear();
            await RunXexTool($" -s 0 \"{XexPathTextBox.Text}\"");
        }

        private async void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(XexPathTextBox.Text) || !File.Exists(XexPathTextBox.Text))
            {
                MessageBox.Show("Please select a valid XEX file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(PatchValueTextBox.Text, out int value) && PatchValueTextBox.Text != "-1")
            {
                MessageBox.Show("Enter a valid patch value (0=list, -1=all, or bitflag like 1/2/4/8).", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LogTextBox.Clear();
            string outputArg = !string.IsNullOrEmpty(OutputPathTextBox.Text)
                ? $" -o \"{OutputPathTextBox.Text}\""
                : "";
            await RunXexTool($" -s {value}{outputArg} \"{XexPathTextBox.Text}\"");
        }

        private async Task RunXexTool(string args)
        {
            try
            {
                using (var process = new Process())
                {
                    process.StartInfo.FileName = "xextool.exe";
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.OutputDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                            AppendLog(e.Data);
                    };
                    process.ErrorDataReceived += (s, e) =>
                    {
                        if (!string.IsNullOrEmpty(e.Data))
                            AppendLog("ERROR: " + e.Data);
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    await Task.Run(() => process.WaitForExit());
                }
            }
            catch (Exception ex)
            {
                AppendLog($"Error: {ex.Message}");
                Logger.Error($"SpecialPatches: {ex.Message}", ex);
            }
        }

        private void AppendLog(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => AppendLog(text)));
                return;
            }
            LogTextBox.AppendText(text + Environment.NewLine);
            LogTextBox.SelectionStart = LogTextBox.Text.Length;
            LogTextBox.ScrollToCaret();
        }

        private void BrowseXexButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "XEX files (*.xex)|*.xex|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                    XexPathTextBox.Text = ofd.FileName;
            }
        }

        private void BrowseOutputButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "XEX files (*.xex)|*.xex|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                    OutputPathTextBox.Text = sfd.FileName;
            }
        }

        private void SpecialPatches_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.xexgui?.Show();
            Program.SpecialPatches = null;
        }
    }
}
