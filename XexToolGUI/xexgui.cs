using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XexToolGUI
{
    public partial class xexgui : Form
    {
        private CancellationTokenSource _cancellationTokenSource;

        Color DragBackColor { get; set; }
        string PatchedXEX { get; set; }
        string XeXFile { get; set; }
        string XeXUpdate { get; set; }

        string basePath = AppDomain.CurrentDomain.BaseDirectory;

        public xexgui()
        {
            InitializeComponent();
            DoesXexToolExists();
        }

        public delegate void UpdateTextBoxTextDelegate(string text);

        private void UpdateProgressBar(int value, string message = "")
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgressBar(value, message)));
                return;
            }

            ProgressBar1.Value = Math.Min(Math.Max(value, ProgressBar1.Minimum), ProgressBar1.Maximum);

            if (!string.IsNullOrEmpty(message))
            {
                LogMessage(message);
            }
        }

        private void SetProgressBarStyle(ProgressBarStyle style, int speed = 30)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SetProgressBarStyle(style, speed)));
                return;
            }

            ProgressBar1.Style = style;
            if (style == ProgressBarStyle.Marquee)
            {
                ProgressBar1.MarqueeAnimationSpeed = speed;
            }
        }

        private void LogMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => LogMessage(message)));
                return;
            }

            XLogBox.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
            XLogBox.SelectionStart = XLogBox.Text.Length;
            XLogBox.ScrollToCaret();
        }

        private async Task<bool> CopyFileAsync(string source, string destination, bool overwrite = false, IProgress<int> progress = null)
        {
            try
            {
                LogMessage($"Copying file: {Path.GetFileName(source)}");
                progress?.Report(10);

                await Task.Run(() =>
                {
                    File.Copy(source, destination, overwrite);
                });

                progress?.Report(100);
                LogMessage($"File copied successfully: {Path.GetFileName(destination)}");
                return true;
            }
            catch (Exception ex)
            {
                LogMessage($"Error copying file: {ex.Message}");
                MessageBox.Show($"Error copying file: {ex.Message}", "File Copy Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> DeleteFileAsync(string filePath, IProgress<int> progress = null)
        {
            try
            {
                LogMessage($"Deleting file: {Path.GetFileName(filePath)}");
                progress?.Report(50);

                await Task.Run(() => File.Delete(filePath));

                progress?.Report(100);
                LogMessage($"File deleted successfully: {Path.GetFileName(filePath)}");
                return true;
            }
            catch (Exception ex)
            {
                LogMessage($"Error deleting file: {ex.Message}");
                MessageBox.Show($"Error deleting file: {ex.Message}", "File Delete Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task<bool> MoveFileAsync(string source, string destination, IProgress<int> progress = null)
        {
            try
            {
                LogMessage($"Moving file: {Path.GetFileName(source)} to {Path.GetFileName(destination)}");
                progress?.Report(50);

                await Task.Run(() => File.Move(source, destination));

                progress?.Report(100);
                LogMessage($"File moved successfully to: {Path.GetFileName(destination)}");
                return true;
            }
            catch (Exception ex)
            {
                LogMessage($"Error moving file: {ex.Message}");
                MessageBox.Show($"Error moving file: {ex.Message}", "File Move Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task SetXeXFilePathAsync(string path)
        {
            var progress = new Progress<int>(value => UpdateProgressBar(value, "Preparing XEX file..."));

            XeXFileTextBox.Text = path;
            string fileName = Path.GetFileName(path);
            XeXFile = Path.Combine(basePath, fileName);

            await CopyFileAsync(path, XeXFile, true, progress);
        }

        private async Task SetXeXpFilePathAsync(string fileName)
        {
            var progress = new Progress<int>(value => UpdateProgressBar(value, "Preparing XEXP file..."));

            XeXpFileTextBox.Text = fileName;
            string fileNameOnly = Path.GetFileName(fileName);
            XeXUpdate = Path.Combine(basePath, fileNameOnly);

            await CopyFileAsync(fileName, XeXUpdate, true, progress);
        }

        private async Task SetFileTypeAsync(string filePath = "", string validExtension = ".xex")
        {
            LogMessage($"Setting file type: {validExtension}");

            switch (validExtension)
            {
                case ".xex":
                    XeXFileTextBox.Text = filePath;
                    await SetXeXFilePathAsync(filePath);
                    break;
                case ".xexp":
                    XeXpFileTextBox.Text = filePath;
                    await SetXeXpFilePathAsync(filePath);
                    break;
                default:
                    LogMessage($"Invalid file extension: {validExtension}");
                    return;
            }
        }

        private async Task<bool> WaitForCompleteFileAsync(string filePath, int timeoutSeconds = 30)
        {
            LogMessage($"Waiting for file completion: {Path.GetFileName(filePath)}");

            DateTime startTime = DateTime.Now;
            TimeSpan timeout = TimeSpan.FromSeconds(timeoutSeconds);
            int checkCount = 0;
            int maxChecks = timeoutSeconds * 4; // Check every 250ms

            while (DateTime.Now - startTime < timeout)
            {
                // Check for cancellation
                if (_cancellationTokenSource?.Token.IsCancellationRequested == true)
                {
                    LogMessage("File wait operation cancelled");
                    return false;
                }

                if (File.Exists(filePath))
                {
                    if (IsFileReady(filePath))
                    {
                        LogMessage($"File ready: {Path.GetFileName(filePath)}");
                        return true;
                    }
                }

                checkCount++;
                int progressValue = (int)((double)checkCount / maxChecks * 100);
                UpdateProgressBar(progressValue, $"Waiting for file... ({checkCount}/{maxChecks})");
                await Task.Delay(250, _cancellationTokenSource?.Token ?? CancellationToken.None);
            }

            LogMessage($"Timeout waiting for file: {Path.GetFileName(filePath)}");
            return false;
        }

        private async Task ExecuteCommandAsync(string arg)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                LogMessage($"Executing command: {arg}");
                SetProgressBarStyle(ProgressBarStyle.Marquee);

                // Create a TaskCompletionSource to properly handle process completion
                var tcs = new TaskCompletionSource<bool>();

                await Task.Run(() =>
                {
                    try
                    {
                        Program.process = new Process();
                        Program.process.OutputDataReceived += ProcessOutputDataReceived;
                        Program.process.ErrorDataReceived += ProcessErrorDataReceived;

                        // Exit handler that signals completion
                        Program.process.Exited += (s, e) =>
                        {
                            Process_Exited(s, e);
                            tcs.TrySetResult(true);
                        };

                        Program.process.EnableRaisingEvents = true;
                        Program.ExecuteProcess(arg);

                        // Wait for the process to actually start
                        Program.process.WaitForExit();
                    }
                    catch (Exception ex)
                    {
                        tcs.TrySetException(ex);
                    }
                }, _cancellationTokenSource.Token);

                // Wait for the process to complete
                await tcs.Task;
            }
            catch (OperationCanceledException)
            {
                LogMessage("Operation cancelled by user");
                CleanupProcess();
            }
            catch (Exception ex)
            {
                LogMessage($"Error executing command: {ex.Message}");
                CleanupProcess();
            }
        }

        private void CleanupProcess()
        {
            try
            {
                if (Program.process != null)
                {
                    Program.process.OutputDataReceived -= ProcessOutputDataReceived;
                    Program.process.ErrorDataReceived -= ProcessErrorDataReceived;
                    Program.process.Exited -= Process_Exited;

                    if (!Program.process.HasExited)
                    {
                        Program.process.Kill();
                    }
                    Program.process.Close();
                    Program.process.Dispose();
                    Program.process = null;
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error during cleanup: {ex.Message}");
            }
            finally
            {
                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void BackupxexToolStripButton_Click(object sender, EventArgs e)
        {
            string text = XeXFileTextBox.Text;
            if (!File.Exists(XeXFileTextBox.Text))
            {
                MessageBox.Show("No xex File selected!", "Does not exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OpenFileDialog1.ShowDialog();
                Application.Restart();
                return;
            }

            SaveFileDialog SaveFileDialog1 = new SaveFileDialog
            {
                FileName = Path.GetFileNameWithoutExtension(text) + ".BAK",
                Filter = "Backup Files (*.BAK)|*.BAK|All files (*.*)|*.*",
                InitialDirectory = Path.GetDirectoryName(text)
            };

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                UpdateProgressBar(0, "Starting backup operation...");

                var progress = new Progress<int>(value => UpdateProgressBar(value));

                try
                {
                    if (await CopyFileAsync(text, SaveFileDialog1.FileName, true, progress))
                    {
                        MessageBox.Show("Backup from *" + XeXFileTextBox.Text + "* Successfully!", "Successfully!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogMessage("Backup operation completed successfully");
                    }
                }
                finally
                {

                    UpdateProgressBar(0);
                }
            }
        }

        private async void PatchxexToolStripButton_Click(object sender, EventArgs e)
        {
            // Disable the button to prevent multiple clicks
            var button = sender as ToolStripButton;
            if (button != null) button.Enabled = false;

            try
            {
                XLogBox.Text = string.Empty;
                LogMessage("Starting patch operation...");
                UpdateProgressBar(0);

                // Step 1: Execute patching command
                UpdateProgressBar(10, "Executing patch command...");
                await ExecuteCommandAsync(" -u -p " + XeXUpdate + " -o " + PatchedXEX + " " + XeXFile);

                // Step 2: Wait for completion
                UpdateProgressBar(50, "Waiting for patch completion...");
                if (await WaitForCompleteFileAsync(PatchedXEX, 60))
                {
                    // Step 3: Cleanup
                    UpdateProgressBar(70, "Cleaning up temporary files...");
                    await DeleteFileAsync(XeXUpdate);
                    await DeleteFileAsync(XeXFile);

                    // Step 4: Move final file
                    UpdateProgressBar(90, "Moving patched file to destination...");
                    await MoveFileAsync(PatchedXEX, SavePatchTextBox.Text);

                    UpdateProgressBar(100, "Patch operation completed successfully!");
                }
                else
                {
                    MessageBox.Show("Timeout waiting for patched file to complete.", "Timeout",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LogMessage("Patch operation timed out");
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Patch operation failed: {ex.Message}");
                MessageBox.Show($"Patch operation failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);

                // Re-enable the button
                if (button != null) button.Enabled = true;
            }
        }

        private async void OpenXEX(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox textBox = XeXFileTextBox;
                string filePath = OpenFileDialog1.FileName;
                string Extension = Path.GetExtension(filePath);

                if (IsValidExtension(".xex", Extension))
                {

                    UpdateProgressBar(0, "Loading XEX file...");

                    try
                    {
                        await SetFileTypeAsync(OpenFileDialog1.FileName);
                        RestoreDragBackColor(textBox);
                        LogMessage($"XEX file loaded successfully: {Path.GetFileName(filePath)}");
                    }
                    finally
                    {

                        UpdateProgressBar(0);
                    }
                }
                else
                {
                    RestoreDragBackColor(textBox);
                }
            }
        }

        private async void OpenXEXP(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox textBox = XeXpFileTextBox;
                string filePath = OpenFileDialog1.FileName;
                string Extension = Path.GetExtension(filePath);

                if (IsValidExtension(".xexp", Extension))
                {

                    UpdateProgressBar(0, "Loading XEXP file...");

                    try
                    {
                        await SetFileTypeAsync(filePath, ".xexp");
                        RestoreDragBackColor(textBox);
                        LogMessage($"XEXP file loaded successfully: {Path.GetFileName(filePath)}");
                    }
                    finally
                    {

                        UpdateProgressBar(0);
                    }
                }
                else
                {
                    RestoreDragBackColor(textBox);
                }
            }
        }

        private async void AP25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting AP25 operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  a " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void BinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting binary conversion...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -c b  -o " + SavePatchTextBox.Text + "_binary.xex " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void CompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting compression...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -c c  -o " + SavePatchTextBox.Text + "_compressed.xex " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void DashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting dash operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  l " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void DevkitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting devkit operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -m  d " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void EncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting encryption...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -e e  -o " + SavePatchTextBox.Text + "_encrypted.xex " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void KeyvaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting keyvault operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  k " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void MediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting media operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  m " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void PathnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting pathname operation...");
            SetProgressBarStyle(ProgressBarStyle.Marquee, 30);


            try
            {
                await ExecuteCommandAsync(" -r  b " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void RegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting region operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  r " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void RequiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting required operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  c " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void RetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting retail operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -m  r " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void UncompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting uncompression...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -c u  -o " + SavePatchTextBox.Text + "_uncompressed.xex " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void UncryptedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting uncryption...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -e u  -o " + SavePatchTextBox.Text + "_uncrypted.xex " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void XexBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("XeX Log");
            XLogBox.Text = string.Empty;
            LogMessage("Creating basic info file...");
            UpdateProgressBar(0);


            try
            {
                XLogBox.Text = "Create Basic Info file with XeXTool GUI\r\n----------------------------------------------------\r\n";
                await ExecuteCommandAsync(XeXFileTextBox.Text);
                DeleteLog();
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void XexExtendedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("XeX Log");
            XLogBox.Text = string.Empty;
            LogMessage("Creating extended info file...");
            UpdateProgressBar(0);


            try
            {
                XLogBox.Text = "Create Extended Info file with XeXTool GUI\r\n----------------------------------------------------------\r\n";
                await ExecuteCommandAsync(" -l " + XeXFileTextBox.Text);
                DeleteLog();
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async void ZeroIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XLogBox.Text = string.Empty;
            LogMessage("Starting zero ID operation...");
            UpdateProgressBar(0);


            try
            {
                await ExecuteCommandAsync(" -r  z " + XeXFileTextBox.Text);
            }
            finally
            {

                SetProgressBarStyle(ProgressBarStyle.Continuous);
                UpdateProgressBar(0);
            }
        }

        private async Task ValidateAndSetFileAsync(object sender, DragEventArgs e, string ValidExtention = ".xex")
        {
            TextBox textBox = (TextBox)sender;
            string filePath = HandleFileDragDrop(e);
            string Extension = Path.GetExtension(filePath);

            if (IsValidExtension(ValidExtention, Extension))
            {
                UpdateProgressBar(0, $"Loading {ValidExtention} file...");

                try
                {
                    await SetFileTypeAsync(filePath, ValidExtention);
                    RestoreDragBackColor(textBox);
                    LogMessage($"File loaded successfully: {Path.GetFileName(filePath)}");
                }
                finally
                {
                    UpdateProgressBar(0);
                }
            }
            else
            {
                RestoreDragBackColor(textBox);
            }
        }

        // Fire-and-forget wrapper for drag-drop events
        private void ValidateAndSetFile(object sender, DragEventArgs e, string ValidExtention = ".xex")
        {
            _ = ValidateAndSetFileAsync(sender, e, ValidExtention);
        }

        // Add method to cancel operations
        private void CancelOperation()
        {
            try
            {
                _cancellationTokenSource?.Cancel();
                LogMessage("Cancelling current operation...");

                // Give a moment for cancellation to process
                Task.Delay(100).ContinueWith(_ => CleanupProcess());
            }
            catch (Exception ex)
            {
                LogMessage($"Error during cancellation: {ex.Message}");
            }
        }
        private void RestoreDragBackColor(TextBox textBox)
        {
            if (textBox != null)
            {
                textBox.BackColor = DragBackColor;
            }
        }
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ClearTool(object sender, EventArgs e)
        {
            XeXFileTextBox.Text = string.Empty;
            XeXpFileTextBox.Text = string.Empty;
            SavePatchTextBox.Text = string.Empty;
            XLogBox.Text = string.Empty;
            UpdateProgressBar(0);
        }

        private void CMDToolStripMenuItem_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\cmd.exe");

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

        private static void DoesXexToolExists()
        {
            if (!File.Exists("xextool.exe"))
            {
                File.WriteAllBytes(Directory.GetCurrentDirectory() + @"\xextool.exe", Properties.Resources.xextool);
                MessageBox.Show("GUI is Ready for Work!", "XexTool.exe Installed!", MessageBoxButtons.OK);
            }
        }

        private void ExitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CancelOperation();
            DeleteLog();
            Close();
        }

        private void HandleDragEnter(object sender, DragEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            DragBackColor = textBox.BackColor;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                textBox.BackColor = Color.LightBlue;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                textBox.BackColor = DragBackColor;
            }
        }

        private string HandleFileDragDrop(DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            return files[0];
        }

        private bool IsFileReady(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    bool isReady = stream.Length > 0;
                    return isReady;
                }
            }
            catch (IOException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsValidExtension(string Valid = ".xex", string extension = ".xex")
        {
            switch (Valid)
            {
                case ".xex":
                    if (extension != Valid)
                    {
                        MessageBox.Show("Invalid file type. Please drop a " + Valid + " file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return true;
                case ".xexp":
                    if (extension != Valid)
                    {
                        MessageBox.Show("Invalid file type. Please drop a " + Valid + " file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return true;
                default:
                    MessageBox.Show("Invalid file type. Please drop a " + Valid + " file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
        }

        private void ProcessOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;

            BeginInvoke((() =>
            {
                try
                {
                    XLogBox.AppendText(e.Data + Environment.NewLine);
                    XLogBox.SelectionStart = XLogBox.Text.Length;
                    XLogBox.SelectionStart = XLogBox.Text.Length;
                    XLogBox.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    // Handle any UI update errors silently
                    System.Diagnostics.Debug.WriteLine($"Error updating UI: {ex.Message}");
                }
            }));
        }

        private void ProcessErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data))
                return;

            // Use BeginInvoke to avoid blocking
            BeginInvoke((Action)(() =>
            {
                try
                {
                    XLogBox.AppendText("ERROR: " + e.Data + Environment.NewLine);
                    XLogBox.SelectionStart = XLogBox.Text.Length;
                    XLogBox.ScrollToCaret();
                }
                catch (Exception ex)
                {
                    // Handle any UI update errors silently
                    System.Diagnostics.Debug.WriteLine($"Error updating UI: {ex.Message}");
                }
            }));
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            // Use BeginInvoke instead of Invoke to avoid blocking
            BeginInvoke((Action)(() =>
            {
                try
                {
                    SetProgressBarStyle(ProgressBarStyle.Continuous);
                    UpdateProgressBar(100, "Process completed successfully");

                    if (Program.process != null)
                    {
                        // Unsubscribe from events first
                        Program.process.OutputDataReceived -= ProcessOutputDataReceived;
                        Program.process.ErrorDataReceived -= ProcessErrorDataReceived;
                        Program.process.Exited -= Process_Exited;

                        // Clean up the process
                        if (!Program.process.HasExited)
                        {
                            Program.process.Kill();
                        }
                        Program.process.Close();
                        Program.process.Dispose();
                        Program.process = null;
                    }
                }
                catch (Exception ex)
                {
                    LogMessage($"Error in Process_Exited: {ex.Message}");
                }
            }));
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
            try
            {
                LogMessage("Opening info log file...");
                Process.Start("C:\\Windows\\Notepad.exe", "\"XeX Log\\xex_InfoLog.cfg\"");
            }
            catch (Exception ex)
            {
                LogMessage($"Error opening file: {ex.Message}");
                MessageBox.Show($"Error opening file: {ex.Message}");
            }
        }

        private void SaveAS(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePatchTextBox.Text = SaveFileDialog1.FileName;
                string fileName = Path.GetFileName(SaveFileDialog1.FileName);
                PatchedXEX = Path.Combine(basePath, fileName);
                LogMessage($"Save path set: {SaveFileDialog1.FileName}");
            }
        }

        private void SelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenXEXP(sender, e);
        }

        private void SelectxexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenXEX(sender, e);
        }

        private void XeXFileTextBox_DragDrop(object sender, DragEventArgs e)
        {
            ValidateAndSetFile(sender, e);
        }

        private void XeXFileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            HandleDragEnter(sender, e);
        }

        private void XeXpFileTextBox_DragDrop(object sender, DragEventArgs e)
        {
            ValidateAndSetFile(sender, e, ".xexp");
        }

        private void XeXpFileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            HandleDragEnter(sender, e);
        }

        private void DumbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Dump == null)
            {
                Program.Dump = new Dump();
                Hide();
                Program.Dump.ShowDialog();
            }
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.HelpReverse == null)
            {
                Program.HelpReverse = new HelpReverse();
                Hide();
                Program.HelpReverse.ShowDialog();
            }
        }

        private void HelpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), @"help\howto")))
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"help\howto\xexpatch.htm");

                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Missing Assets: " + @"\help\howto\xexpatch.htm");
            }
        }

        private void HxDToolStripMenuItem1_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start("Apps\\HxD.exe");

        private void IdcFileForIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.IDCScript == null)
            {
                Program.IDCScript = new IDCScript();
            }
            Hide();
            Program.IDCScript.ShowDialog();
        }

        private void InfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.Info == null)
            {
                Program.Info = new About();
                Hide();
                Program.Info.ShowDialog();
            }
        }

        private void InfoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Program.Info == null)
            {
                Program.Info = new About();
                Hide();
                Program.Info.ShowDialog();
            }

        }

        private void TitleUpdatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.TitleUpdate == null)
            {
                Program.TitleUpdate = new TitleUpdate();
                Hide();
                Program.TitleUpdate.ShowDialog();
            }
        }

        private void WxPirsToolStripMenuItem_Click(object sender, EventArgs e) =>
            System.Diagnostics.Process.Start("Apps\\wxPirs.exe");

        private void XMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.xml == null)
            {
                Program.xml = new xml();
                Hide();
                Program.xml.ShowDialog();
            }
        }

        // Add a method to add a Cancel button (you would need to add this to your form design)
        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelOperation();
        }

        // Additional helper method for comprehensive error handling
        private void ShowErrorMessage(string message, string title = "Error")
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowErrorMessage(message, title)));
                return;
            }

            LogMessage($"Error: {message}");
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void XeXFileTextBox_DragLeave(object sender, EventArgs e)
        {
            XeXFileTextBox.BackColor = DragBackColor;
        }

        private void XeXpFileTextBox_DragLeave(object sender, EventArgs e)
        {
            XeXpFileTextBox.BackColor = DragBackColor;
        }

        private void HandleMouseDown(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RestoreDragBackColor(textBox);
        }

        private void HandleMouseEnter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.LightBlue;
        }

        private void HandleMouseLeave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            RestoreDragBackColor(textBox);
        }

        private void SavexexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAS(sender, e);
        }

    }
}