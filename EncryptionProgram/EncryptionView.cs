namespace EncryptionProgram
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using Encryption_Program.UpdateUI;
    using EncryptionProgram.Model;
    using EncryptionProgram.UpdateUI;

    public partial class EncryptionView : Form
    {
        private bool encryptionMode;
        private double percentageValue = 0;
        private bool encryptedFilesFound = false;
        private string password = string.Empty;
        private IEncryptionEvents encryptionEvents;
        private ILoggingEvents loggingEvents;
        private Controllers.EncryptionController encryptionController;
        private Stopwatch encryptionStopWatch = new Stopwatch();

        public EncryptionView()
        {
            this.InitializeComponent();

            this.encryptionEvents = new EncryptionEvents(this);
            this.encryptionController = new Controllers.EncryptionController(new Controllers.Services.EncryptionService());
            this.loggingEvents = new LoggingEvents(this.encryptionEvents);
            this.encryptionMode = true;
        }

        private void ChkMode_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chkMode.Checked)
            {
                this.chkMode.Text = "Encryption Mode Set";
                this.chkMode.ForeColor = Color.Green;
                this.encryptionMode = true;
            }
            else
            {
                this.chkMode.Text = "Decryption Mode Set";
                this.chkMode.ForeColor = Color.Red;
                this.encryptionMode = false;
            }
        }

        public ListBox EncryptionListBox
        {
            get { return this.encryptionListBox; }
        }

        public TextBox TotalFilesTextBox
        {
            get { return this.txtTotalFiles; }
        }

        public TextBox TotalFileSizeTextBox
        {
            get { return this.txtTotalFileSize; }
        }

        public TextBox BrowseFoldersTextBox
        {
            get { return this.txtBrowseFolders; }
        }

        public TextBox GeneratePasswordTextBox
        {
            get { return this.txtGeneratePasswordHash; }
        }

        public RichTextBox LogOutPutRichTextBox
        {
            get { return this.txtOutPutInfo;  }
        }

        public Label ErrorLabel
        {
            get { return this.lblError; }
        }

        public Label SelectedFileNameLabel
        {
            get { return this.lblSelectedFileName; }
        }

        public Label SelectedFileSizeLabel
        {
            get { return this.lblSelectedFileSize; }
        }

        public Label FileSizeLeftToEncryptLabel
        {
            get { return this.lblMbSizeLeftToEncrypt; }
        }

        public Label TimeElapsedLabel
        {
            get { return this.lblEncrptionSpeed; }
        }

        public Button EncryptionButton
        {
            get { return this.btnEncryptFiles; }
        }

        public Button DecryptionButton
        {
            get { return this.btnDecryptFiles; }
        }

        public Button StopEncryptionButton
        {
            get { return this.btnStopEncryption; }
        }

        public Button GeneratePasswordHashButton
        {
            get { return this.btnGeneratePasswordHash; }
        }

        public Button ResetButton
        {
            get { return this.btnReset; }
        }

        public void AddFilesToListBox(string folderPath)
        {
            this.encryptionEvents.ClearFiles();
            this.encryptionEvents.UpdateListBox(folderPath);
            this.encryptionEvents.UpdateTotalsTextBox();

            // checkForEnCryptedFiles();
        }

        public void AddSingleFileToListBox(string[] files)
        {
           this.encryptionEvents.UpdateListBox(files);
           this.encryptionEvents.UpdateTotalsTextBox();
        }

        public void ResetEncryptionButton()
        {
            this.btnEncryptFiles.BackColor = SystemColors.Control;
            this.btnEncryptFiles.UseVisualStyleBackColor = true;
            this.btnEncryptFiles.Enabled = false;
        }

        public void ResetDecryptionButton()
        {
            this.btnDecryptFiles.BackColor = SystemColors.Control;
            this.btnDecryptFiles.UseVisualStyleBackColor = true;
            this.btnDecryptFiles.Enabled = false;
        }

        public void ResetPasswordHashButton()
        {
            this.GeneratePasswordHashButton.BackColor = SystemColors.Control;
            this.GeneratePasswordHashButton.UseVisualStyleBackColor = true;
            this.GeneratePasswordHashButton.Enabled = false;
        }

        public void InitPasswordTextBox()
        {
            this.GeneratePasswordTextBox.Text = Constants.PasswordPlaceHolder;
            this.GeneratePasswordTextBox.GotFocus += new EventHandler(this.RemoveText);
            this.GeneratePasswordTextBox.LostFocus += new EventHandler(this.AddText);
            this.GeneratePasswordTextBox.Enabled = false;
        }

        public void ResetStopButton()
        {
            this.btnStopEncryption.BackColor = SystemColors.Control;
            this.btnStopEncryption.UseVisualStyleBackColor = true;
            this.btnStopEncryption.Enabled = false;
        }

        public void ChangeStopEncryptionButton()
        {
            this.btnStopEncryption.BackColor = Color.Red;
            this.btnStopEncryption.ForeColor = Color.White;
            this.btnStopEncryption.Enabled = true;
        }

        public void ChangeResetButton()
        {
            this.btnReset.BackColor = Color.Gold;
            this.btnReset.Enabled = true;
        }

        public void ChangeEncryptFilesButton()
        {
            this.btnEncryptFiles.BackColor = Color.Green;
            this.btnEncryptFiles.Enabled = true;
        }

        public void ChangeFormControlsWhileEncrypting()
        {
           this.ResetEncryptionButton();
           this.ResetDecryptionButton();
           this.ChangeStopEncryptionButton();
           this.txtGeneratePasswordHash.Enabled = false;
           this.btnBrowse.Enabled = false;
           this.btnRemove.Enabled = false;
           this.btnClearAll.Enabled = false;
           this.btnOpenLogFile.Enabled = false;
           this.btnReset.Enabled = false;
        }

        // Restore form controls after encruption process has finished
        public void RestoreFormControlsAfterEncryption()
        {
            this.ResetEncryptionButton();
            this.ResetDecryptionButton();
            this.ResetStopButton();
            this.ChangeResetButton();
            this.txtGeneratePasswordHash.Enabled = true;
            this.btnBrowse.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnClearAll.Enabled = true;
            this.btnOpenLogFile.Enabled = true;
        }

        public delegate void UpdateCheckBoxMode();

        public void UpdateDecryptionEncryptionCheckBox()
        {
            // disable the checkbox if listbox has items on it
            if (this.encryptionListBox.Items.Count > 0)
            {
                this.chkMode.Enabled = false;
            }

            if (this.encryptionListBox.Items.Count <= 0)
            {
                this.chkMode.Enabled = true;
            }
        }

        public delegate void UpdatePasswordTextBox();

        public void UpdateEnablePasswordTextBox()
        {
            this.txtGeneratePasswordHash.Enabled = true;
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        private delegate void SetTextCallback(string logText);

        public void UpdateTxtOutputInfor(string logText)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtOutPutInfo.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(this.UpdateTxtOutputInfor);
                this.Invoke(d, new object[] { logText });
            }
            else
            {
                this.txtOutPutInfo.AppendText(logText + Environment.NewLine);
            }
        }

        // delegates to placeholder
        public void RemoveText(object sender, EventArgs e)
        {
            this.GeneratePasswordTextBox.Text = string.Empty;
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.GeneratePasswordTextBox.Text))
            {
                this.GeneratePasswordTextBox.Text = "Enter Your Password Key";
            }
        }

        // start encryption BG worker thread
        private void EncryptionBGWorker_DoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            List<Document> files = this.encryptionEvents.GetAllFiles();
            Dictionary<string, byte[]> fileWithEncryptedBytes = new Dictionary<string, byte[]>();
            string mode = this.encryptionMode ? "Encrypt" : "Decrypt";

            this.loggingEvents.LogTextToOutput(string.Format("::Total Files To {0} :: {1}", mode, files.Count.ToString()));
            this.loggingEvents.LogTextToOutput("::Reading All Bytes Of Files ::");
            int progress = 0;
            int totalPercentageFrom = files.Count * 2;

            this.encryptionStopWatch.Start();

            if (this.encryptionMode)
            {
                foreach (var file in files)
                {
                    fileWithEncryptedBytes.Add(file.FullPath, this.encryptionController.Encrypt(file.Bytes, Encoding.UTF8.GetBytes(this.password)));

                    progress++;
                    string output = string.Format("{0} :: File :: {1} :: Bytes to be encrypted :: {2}", progress, file.Name, file.Bytes.Length.ToString());
                    this.loggingEvents.LogTextToOutput(output);
                    this.EncryptionBGWorker.ReportProgress(progress, totalPercentageFrom);
                }
            }
            else
            {
                foreach (var file in files)
                {
                    fileWithEncryptedBytes.Add(file.FullPath, this.encryptionController.Decrypt(file.Bytes, Encoding.UTF8.GetBytes(this.password)));

                    progress++;
                    string output = string.Format("{0} :: File :: {1} :: Bytes to be decrypted :: {2}", progress, file.Name, file.Bytes.Length.ToString());
                    this.loggingEvents.LogTextToOutput(output);
                    this.EncryptionBGWorker.ReportProgress(progress, totalPercentageFrom);
                }
            }

            // write encrypted bytes to file
            this.loggingEvents.LogTextToOutput("::Decrypting Files..........................");

            int numberOfFilesToWrite = 0;
            foreach (var encryptedFile in fileWithEncryptedBytes)
            {
                try
                {
                    numberOfFilesToWrite++;
                    progress++;
                    File.WriteAllBytes(encryptedFile.Key, encryptedFile.Value);
                }
                catch (UnauthorizedAccessException)
                {
                }
                finally
                {
                    // change the last string of file name to indicate it has been encrypted
                    string renamedEncryptedFile;
                    if (this.encryptionMode)
                    {
                        renamedEncryptedFile = this.encryptionController.RenameEncryptedFile(encryptedFile.Key);
                    }
                    else
                    {
                        renamedEncryptedFile = this.encryptionController.RemoveCryptExtension(encryptedFile.Key);
                    }

                    this.loggingEvents.LogTextToOutput(string.Format("{0} ::File Encrypted:: {1}", numberOfFilesToWrite, renamedEncryptedFile));

                    this.encryptionEvents.UpdateTotalFileSizeLeftToEncrypt();
                    this.encryptionEvents.UpdateTimeElasped(this.encryptionStopWatch.Elapsed);

                    this.EncryptionBGWorker.ReportProgress(progress, totalPercentageFrom);
                }

                // This is where we report to stop the thread if user has clicked stop and break out of the loop
                if (this.EncryptionBGWorker.CancellationPending)
                {
                    this.encryptionStopWatch.Stop();
                    doWorkEventArgs.Cancel = true;
                    return;
                }
            }

            this.encryptionStopWatch.Stop();
        }

        private void EncryptionBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                // set how many files we have as our 100 percent which was sent via our report progress method
                this.encryptionProgressBar.Maximum = Convert.ToInt32(e.UserState);
                this.ChangeFormControlsWhileEncrypting();
            }

            // now calculate percentage of value to the maximum so (value / maximum) * 100 = percentage value
            // first get the decimal value before later multiplying //do this calculation now to improve speed of program
            this.percentageValue = (double)e.ProgressPercentage / (double)this.encryptionProgressBar.Maximum;
            this.encryptionProgressBar.Value = e.ProgressPercentage;
            this.percentageValue = Math.Round(this.percentageValue * 100, 1);
            this.lblEncrptionPercentage.Text = string.Format("{0} % Completion", this.percentageValue.ToString());
        }

        private void EncryptionBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.ResetEncryptionButton();
                this.ResetDecryptionButton();
                this.ChangeResetButton();

                this.encryptionProgressBar.Value = 0;
                this.lblError.Text = "Progress cancelled";
                this.btnOpenLogFile.Enabled = true;
            }
            else
            {
                this.RestoreFormControlsAfterEncryption();
            }

            this.loggingEvents.LogTextToOutput("#############################-Encryption Process FINISHED-#################################");
            this.loggingEvents.LogTextToOutput("Date and Time : " + DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss").ToString());
            this.loggingEvents.LogTextToOutput("Percentage Complete : " + this.lblEncrptionPercentage.Text);
            this.loggingEvents.LogTextToOutput("Ecryption Duration : " + this.TimeElapsedLabel.Text);
            this.loggingEvents.LogTextToOutput("MB Difference : " + this.FileSizeLeftToEncryptLabel.Text);
            this.loggingEvents.LogTextToOutput("#############################-Encryption Process FINISHED-#################################");
            this.loggingEvents.SaveLogFile(this.LogOutPutRichTextBox);
        }

        /// <summary>
        /// clears files from the list box
        /// </summary>
        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.encryptionEvents.ClearFiles();
                this.InitPasswordTextBox();
                this.ResetPasswordHashButton();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Removes individual files from the list
        /// </summary>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                this.encryptionEvents.RemoveFile(this.EncryptionListBox.SelectedItem);

                this.encryptionEvents.UpdateTotalsTextBox();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedPath = this.encryptionEvents.BrowseFiles();

                if (!string.IsNullOrEmpty(selectedPath))
                {
                    this.txtBrowseFolders.Text = selectedPath;
                    ThreadStart startToRetreiveFiles = new ThreadStart(() => this.AddFilesToListBox(this.txtBrowseFolders.Text));
                    startToRetreiveFiles += () =>
                    {
                        Application.UseWaitCursor = false;
                    };

                    Thread retrievingFilesThread = new Thread(startToRetreiveFiles);
                    retrievingFilesThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Update the list box when an item is removed or added
        /// </summary>
        private void EncryptionListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
            {
                ThreadStart updateSelectedLabels = new ThreadStart(() => this.encryptionEvents.UpdateSelectedLabel());
                Thread updatedSelectedLabelThread = new Thread(updateSelectedLabels);
                updatedSelectedLabelThread.Start();
            }
        }

        private void Encryption_Form_Load(object sender, EventArgs e)
        {
            this.InitPasswordTextBox();

            this.chkMode.Checked = true;
            this.chkMode.Text = "Encryption Mode Set";
            this.chkMode.ForeColor = Color.Green;

            this.TotalFileSizeTextBox.Text = "0";
            this.TotalFilesTextBox.Text = "0";
            this.chkMode.CheckStateChanged += this.ChkMode_CheckStateChanged;

            this.EncryptionButton.Enabled = false;
            this.DecryptionButton.Enabled = false;
            this.StopEncryptionButton.Enabled = false;
            this.ResetButton.Enabled = true;
            this.ErrorLabel.Visible = false;

            this.GeneratePasswordHashButton.Enabled = false;
            this.GeneratePasswordTextBox.Enabled = false;
        }

        /// <summary>
        ///  Here we will encrypt all the files in the list box f
        ///  first we need to has the password that was given by the user
        /// </summary>
        private void BtnGeneratePasswordHash_Click(object sender, EventArgs e)
        {
            this.password = Encoding.UTF8.GetString(this.encryptionController.HashPassword(this.txtGeneratePasswordHash.Text));

            if (this.encryptionMode)
            {
                // now enable the encryption button with green color
                this.EncryptionButton.Enabled = true;
                this.EncryptionButton.BackColor = Color.Green;
                this.ResetPasswordHashButton();

                this.ErrorLabel.Text = "Click Password Field To Change Password again";
                this.ErrorLabel.Visible = true;
                return;
            }

            this.DecryptionButton.Enabled = true;
            this.DecryptionButton.BackColor = Color.Green;
            this.ResetPasswordHashButton();

            this.ErrorLabel.Text = "Click Password Field To Change Password again";
            this.ErrorLabel.Visible = true;
        }

        /// <summary>
        /// Begin encryption
        /// </summary>
        private void BtnEncryptFiles_Click(object sender, EventArgs e)
        {
            // check if backgroud worker is already running asynchronous operation
            if (!this.EncryptionBGWorker.IsBusy)
            {
                this.encryptionMode = true;
                this.EncryptionBGWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Begin decryption
        /// </summary>
        private void BtnDecryptFiles_Click(object sender, EventArgs e)
        {
            // if (!this.DecryptionBGWorker.IsBusy)
            // {
            //    this.DecryptionBGWorker.RunWorkerAsync();
            // }
            // check if backgroud worker is already running asynchronous operation
            if (!this.EncryptionBGWorker.IsBusy)
            {
                this.encryptionMode = false;
                this.EncryptionBGWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// This allows the scroll bar to scroll to the bottom of the page
        /// when new data is entred
        /// </summary>
        private void TxtOutPutInfo_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            this.txtOutPutInfo.SelectionStart = this.txtOutPutInfo.Text.Length;

            // scroll it automatically
            this.txtOutPutInfo.ScrollToCaret();
        }

        /// <summary>
        /// This is to exit the program
        /// </summary>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Enable password field when total textbox changes
        /// </summary>
        private void TxtTotalFiles_TextChanged(object sender, EventArgs e)
        {
            if (this.txtTotalFiles.Text != string.Empty)
            {
                if (!this.encryptedFilesFound)
                {
                    this.txtGeneratePasswordHash.Enabled = true;
                }
                else
                {
                    this.txtGeneratePasswordHash.Enabled = false;
                }
            }

            if (this.txtTotalFiles.Text == string.Empty)
            {
                this.txtGeneratePasswordHash.Enabled = false;
            }
        }

        /// <summary>
        /// Reset password button when password is being entred
        /// </summary>
        private void TxtGeneratePasswordHash_TextChanged(object sender, EventArgs e)
        {
            if (this.txtGeneratePasswordHash.Focused)
            {
                if (this.encryptionMode == true)
                {
                    this.txtGeneratePasswordHash.PasswordChar = '*';
                    this.lblError.Visible = true;
                    this.ResetPasswordHashButton();
                    this.ResetEncryptionButton();
                    this.lblError.Text = "Password Length must be greater than 8";

                    if (this.txtGeneratePasswordHash.TextLength > 8)
                    {
                        this.lblError.Visible = false;
                        this.btnGeneratePasswordHash.Enabled = true;
                        this.btnGeneratePasswordHash.BackColor = Color.Green;
                    }
                }
                else
                {
                    this.txtGeneratePasswordHash.PasswordChar = '*';
                    this.lblError.Visible = true;
                    this.ResetPasswordHashButton();
                    this.ResetEncryptionButton();
                    this.lblError.Text = "Please enter your encryption password to allow your files to be decrypted";

                    if (this.txtGeneratePasswordHash.TextLength > 8)
                    {
                        this.lblError.Visible = false;
                        this.btnGeneratePasswordHash.Enabled = true;
                        this.btnGeneratePasswordHash.BackColor = Color.Green;
                    }
                }
            }
        }

        /// <summary>
        /// Reseting controlsto normal state
        /// </summary>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.BtnClearAll_Click(sender, e);
            this.ResetEncryptionButton();
            this.ResetDecryptionButton();
            this.ResetStopButton();
            this.lblEncrptionSpeed.Text = "Speed of Encryption";
            this.lblEncrptionPercentage.Text = "Completion %";
            this.lblMbSizeLeftToEncrypt.Text = "Size Left to encrypt Progress";

            this.encryptionProgressBar.Value = 0;
            this.txtOutPutInfo.Text = string.Empty;
            this.btnBrowse.Enabled = true;
            this.btnClearAll.Enabled = true;
            this.btnRemove.Enabled = true;
            this.btnReset.BackColor = SystemColors.Control;
            this.btnReset.UseVisualStyleBackColor = true;
            this.chkMode.Enabled = true;
        }

        /// <summary>
        /// Open Logs
        /// </summary>
        private void BtnOpenLogFile_Click(object sender, EventArgs e)
        {
            try
            {
                this.encryptionEvents.OpenLogs();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnStopEncryption_Click(object sender, EventArgs e)
        {
            if (this.EncryptionBGWorker.IsBusy)
            {
                this.EncryptionBGWorker.CancelAsync();
            }
        }
    }
}
