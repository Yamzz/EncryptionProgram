namespace EncryptionProgram
{
    partial class EncryptionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        { 
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.encryptionProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblEncrptionPercentage = new System.Windows.Forms.Label();
            this.lblMbSizeLeftToEncrypt = new System.Windows.Forms.Label();
            this.lblEncrptionSpeed = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOpenLogFile = new System.Windows.Forms.Button();
            this.btnStopEncryption = new System.Windows.Forms.Button();
            this.btnDecryptFiles = new System.Windows.Forms.Button();
            this.btnEncryptFiles = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGeneratePasswordHash = new System.Windows.Forms.Button();
            this.txtGeneratePasswordHash = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtBrowseFolders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.encryptionListBox = new System.Windows.Forms.ListBox();
            this.txtTotalFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalFileSize = new System.Windows.Forms.TextBox();
            this.lblSelectedFileName = new System.Windows.Forms.Label();
            this.lblSelectedFileSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOutPutInfo = new System.Windows.Forms.RichTextBox();
            this.chkMode = new System.Windows.Forms.CheckBox();
            this.lblEncryptionTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptionBGWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.lblEncryptionTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.tabPage1.Size = new System.Drawing.Size(948, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encryption + Decryption Program";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOutPutInfo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkMode, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.encryptionProgressBar, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblEncrptionPercentage, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblMbSizeLeftToEncrypt, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.lblEncrptionSpeed, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(1, 278);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(945, 171);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // encryptionProgressBar
            // 
            this.encryptionProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionProgressBar.Location = new System.Drawing.Point(1, 44);
            this.encryptionProgressBar.Margin = new System.Windows.Forms.Padding(1);
            this.encryptionProgressBar.Name = "encryptionProgressBar";
            this.encryptionProgressBar.Size = new System.Drawing.Size(943, 30);
            this.encryptionProgressBar.TabIndex = 1;
            // 
            // lblEncrptionPercentage
            // 
            this.lblEncrptionPercentage.AutoSize = true;
            this.lblEncrptionPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrptionPercentage.Location = new System.Drawing.Point(1, 75);
            this.lblEncrptionPercentage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEncrptionPercentage.Name = "lblEncrptionPercentage";
            this.lblEncrptionPercentage.Size = new System.Drawing.Size(96, 15);
            this.lblEncrptionPercentage.TabIndex = 2;
            this.lblEncrptionPercentage.Text = "Completion %";
            // 
            // lblMbSizeLeftToEncrypt
            // 
            this.lblMbSizeLeftToEncrypt.AutoSize = true;
            this.lblMbSizeLeftToEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMbSizeLeftToEncrypt.Location = new System.Drawing.Point(1, 103);
            this.lblMbSizeLeftToEncrypt.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMbSizeLeftToEncrypt.Name = "lblMbSizeLeftToEncrypt";
            this.lblMbSizeLeftToEncrypt.Size = new System.Drawing.Size(190, 15);
            this.lblMbSizeLeftToEncrypt.TabIndex = 3;
            this.lblMbSizeLeftToEncrypt.Text = "Size Left to encrypt Progress";
            // 
            // lblEncrptionSpeed
            // 
            this.lblEncrptionSpeed.AutoSize = true;
            this.lblEncrptionSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrptionSpeed.Location = new System.Drawing.Point(1, 132);
            this.lblEncrptionSpeed.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEncrptionSpeed.Name = "lblEncrptionSpeed";
            this.lblEncrptionSpeed.Size = new System.Drawing.Size(135, 15);
            this.lblEncrptionSpeed.TabIndex = 4;
            this.lblEncrptionSpeed.Text = "Speed of Encryption";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.87379F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.12621F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpenLogFile, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStopEncryption, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnDecryptFiles, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnEncryptFiles, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(938, 37);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(808, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 31);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnOpenLogFile
            // 
            this.btnOpenLogFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLogFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLogFile.Location = new System.Drawing.Point(680, 3);
            this.btnOpenLogFile.Name = "btnOpenLogFile";
            this.btnOpenLogFile.Size = new System.Drawing.Size(122, 31);
            this.btnOpenLogFile.TabIndex = 3;
            this.btnOpenLogFile.Text = "Open Logs";
            this.btnOpenLogFile.UseVisualStyleBackColor = true;
            this.btnOpenLogFile.Click += new System.EventHandler(this.BtnOpenLogFile_Click);
            // 
            // btnStopEncryption
            // 
            this.btnStopEncryption.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopEncryption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopEncryption.ForeColor = System.Drawing.Color.Black;
            this.btnStopEncryption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopEncryption.Location = new System.Drawing.Point(585, 3);
            this.btnStopEncryption.Name = "btnStopEncryption";
            this.btnStopEncryption.Size = new System.Drawing.Size(89, 31);
            this.btnStopEncryption.TabIndex = 1;
            this.btnStopEncryption.Text = "Stop ";
            this.btnStopEncryption.UseVisualStyleBackColor = true;
            this.btnStopEncryption.Click += new System.EventHandler(this.BtnStopEncryption_Click);
            // 
            // btnDecryptFiles
            // 
            this.btnDecryptFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDecryptFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecryptFiles.Location = new System.Drawing.Point(328, 3);
            this.btnDecryptFiles.Name = "btnDecryptFiles";
            this.btnDecryptFiles.Size = new System.Drawing.Size(210, 31);
            this.btnDecryptFiles.TabIndex = 5;
            this.btnDecryptFiles.Text = "Decrypt Files";
            this.btnDecryptFiles.UseVisualStyleBackColor = true;
            this.btnDecryptFiles.Click += new System.EventHandler(this.BtnDecryptFiles_Click);
            // 
            // btnEncryptFiles
            // 
            this.btnEncryptFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEncryptFiles.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncryptFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFiles.ForeColor = System.Drawing.Color.Black;
            this.btnEncryptFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncryptFiles.Location = new System.Drawing.Point(37, 3);
            this.btnEncryptFiles.Name = "btnEncryptFiles";
            this.btnEncryptFiles.Size = new System.Drawing.Size(217, 31);
            this.btnEncryptFiles.TabIndex = 0;
            this.btnEncryptFiles.Text = "Encrypt Files";
            this.btnEncryptFiles.UseVisualStyleBackColor = true;
            this.btnEncryptFiles.Click += new System.EventHandler(this.BtnEncryptFiles_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.68322F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.31678F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel7.Controls.Add(this.btnGeneratePasswordHash, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtGeneratePasswordHash, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblError, 0, 1);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1, 224);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.40678F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.59322F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(804, 52);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // btnGeneratePasswordHash
            // 
            this.btnGeneratePasswordHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGeneratePasswordHash.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeneratePasswordHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePasswordHash.ForeColor = System.Drawing.Color.Black;
            this.btnGeneratePasswordHash.Location = new System.Drawing.Point(367, 1);
            this.btnGeneratePasswordHash.Margin = new System.Windows.Forms.Padding(1);
            this.btnGeneratePasswordHash.Name = "btnGeneratePasswordHash";
            this.btnGeneratePasswordHash.Size = new System.Drawing.Size(267, 31);
            this.btnGeneratePasswordHash.TabIndex = 2;
            this.btnGeneratePasswordHash.Text = "Hash and Salt your Password";
            this.btnGeneratePasswordHash.UseVisualStyleBackColor = true;
            this.btnGeneratePasswordHash.Click += new System.EventHandler(this.BtnGeneratePasswordHash_Click);
            // 
            // txtGeneratePasswordHash
            // 
            this.txtGeneratePasswordHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGeneratePasswordHash.Location = new System.Drawing.Point(1, 1);
            this.txtGeneratePasswordHash.Margin = new System.Windows.Forms.Padding(1);
            this.txtGeneratePasswordHash.Multiline = true;
            this.txtGeneratePasswordHash.Name = "txtGeneratePasswordHash";
            this.txtGeneratePasswordHash.Size = new System.Drawing.Size(364, 31);
            this.txtGeneratePasswordHash.TabIndex = 0;
            this.txtGeneratePasswordHash.TextChanged += new System.EventHandler(this.TxtGeneratePasswordHash_TextChanged);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(3, 35);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 15);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.34625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.65375F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBrowseFolders, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.encryptionListBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalFiles, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTotalFileSize, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedFileName, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSelectedFileSize, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 34);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.375F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.625F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(945, 188);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnRemove, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClearAll, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(611, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.42719F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.57281F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(116, 53);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(1, 4);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 22);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Location = new System.Drawing.Point(1, 28);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(114, 24);
            this.btnClearAll.TabIndex = 1;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // txtBrowseFolders
            // 
            this.txtBrowseFolders.BackColor = System.Drawing.Color.White;
            this.txtBrowseFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBrowseFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowseFolders.Location = new System.Drawing.Point(113, 1);
            this.txtBrowseFolders.Margin = new System.Windows.Forms.Padding(1);
            this.txtBrowseFolders.Multiline = true;
            this.txtBrowseFolders.Name = "txtBrowseFolders";
            this.txtBrowseFolders.ReadOnly = true;
            this.txtBrowseFolders.Size = new System.Drawing.Size(496, 27);
            this.txtBrowseFolders.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Browse Folders:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Files to be Encrypted:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Location = new System.Drawing.Point(611, 1);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(116, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // encryptionListBox
            // 
            this.encryptionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionListBox.FormattingEnabled = true;
            this.encryptionListBox.ItemHeight = 15;
            this.encryptionListBox.Location = new System.Drawing.Point(113, 30);
            this.encryptionListBox.Margin = new System.Windows.Forms.Padding(1);
            this.encryptionListBox.Name = "encryptionListBox";
            this.encryptionListBox.Size = new System.Drawing.Size(496, 90);
            this.encryptionListBox.TabIndex = 2;
            this.encryptionListBox.SelectedValueChanged += new System.EventHandler(this.EncryptionListBox_SelectedValueChanged);
            // 
            // txtTotalFiles
            // 
            this.txtTotalFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalFiles.BackColor = System.Drawing.Color.White;
            this.txtTotalFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFiles.Location = new System.Drawing.Point(757, 122);
            this.txtTotalFiles.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotalFiles.Multiline = true;
            this.txtTotalFiles.Name = "txtTotalFiles";
            this.txtTotalFiles.ReadOnly = true;
            this.txtTotalFiles.Size = new System.Drawing.Size(144, 32);
            this.txtTotalFiles.TabIndex = 9;
            this.txtTotalFiles.TextChanged += new System.EventHandler(this.TxtTotalFiles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(2, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Files in List:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total File Size MB:";
            // 
            // txtTotalFileSize
            // 
            this.txtTotalFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalFileSize.BackColor = System.Drawing.Color.White;
            this.txtTotalFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFileSize.Location = new System.Drawing.Point(757, 156);
            this.txtTotalFileSize.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotalFileSize.Multiline = true;
            this.txtTotalFileSize.Name = "txtTotalFileSize";
            this.txtTotalFileSize.ReadOnly = true;
            this.txtTotalFileSize.Size = new System.Drawing.Size(144, 31);
            this.txtTotalFileSize.TabIndex = 10;
            // 
            // lblSelectedFileName
            // 
            this.lblSelectedFileName.AutoSize = true;
            this.lblSelectedFileName.Location = new System.Drawing.Point(114, 121);
            this.lblSelectedFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFileName.Name = "lblSelectedFileName";
            this.lblSelectedFileName.Size = new System.Drawing.Size(27, 16);
            this.lblSelectedFileName.TabIndex = 12;
            this.lblSelectedFileName.Text = "n/a";
            // 
            // lblSelectedFileSize
            // 
            this.lblSelectedFileSize.AutoSize = true;
            this.lblSelectedFileSize.Location = new System.Drawing.Point(114, 155);
            this.lblSelectedFileSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedFileSize.Name = "lblSelectedFileSize";
            this.lblSelectedFileSize.Size = new System.Drawing.Size(27, 16);
            this.lblSelectedFileSize.TabIndex = 13;
            this.lblSelectedFileSize.Text = "n/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label8.Location = new System.Drawing.Point(2, 155);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "File Size:";
            // 
            // txtOutPutInfo
            // 
            this.txtOutPutInfo.BackColor = System.Drawing.Color.White;
            this.txtOutPutInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutPutInfo.Location = new System.Drawing.Point(1, 451);
            this.txtOutPutInfo.Margin = new System.Windows.Forms.Padding(1);
            this.txtOutPutInfo.Name = "txtOutPutInfo";
            this.txtOutPutInfo.ReadOnly = true;
            this.txtOutPutInfo.Size = new System.Drawing.Size(944, 87);
            this.txtOutPutInfo.TabIndex = 6;
            this.txtOutPutInfo.Text = "";
            this.txtOutPutInfo.TextChanged += new System.EventHandler(this.TxtOutPutInfo_TextChanged);
            // 
            // chkMode
            // 
            this.chkMode.AutoSize = true;
            this.chkMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMode.Location = new System.Drawing.Point(3, 3);
            this.chkMode.Name = "chkMode";
            this.chkMode.Size = new System.Drawing.Size(110, 22);
            this.chkMode.TabIndex = 7;
            this.chkMode.Text = "checkBox1";
            this.chkMode.UseVisualStyleBackColor = true;
            // 
            // lblEncryptionTitle
            // 
            this.lblEncryptionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEncryptionTitle.AutoSize = true;
            this.lblEncryptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptionTitle.ForeColor = System.Drawing.Color.Green;
            this.lblEncryptionTitle.Location = new System.Drawing.Point(307, 1);
            this.lblEncryptionTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEncryptionTitle.Name = "lblEncryptionTitle";
            this.lblEncryptionTitle.Size = new System.Drawing.Size(342, 24);
            this.lblEncryptionTitle.TabIndex = 0;
            this.lblEncryptionTitle.Text = "Encryption and Decryption Program";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EncryptionBGWorker
            // 
            this.EncryptionBGWorker.WorkerReportsProgress = true;
            this.EncryptionBGWorker.WorkerSupportsCancellation = true;
            this.EncryptionBGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.EncryptionBGWorker_DoWork);
            this.EncryptionBGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.EncryptionBGWorker_ProgressChanged);
            this.EncryptionBGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EncryptionBGWorker_RunWorkerCompleted);
            // 
            // EncryptionView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(956, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(974, 653);
            this.MinimumSize = new System.Drawing.Size(914, 493);
            this.Name = "EncryptionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption v1.1";
            this.Load += new System.EventHandler(this.Encryption_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEncryptionTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox encryptionListBox;
        private System.Windows.Forms.TextBox txtBrowseFolders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalFiles;
        private System.Windows.Forms.TextBox txtTotalFileSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnGeneratePasswordHash;
        private System.Windows.Forms.TextBox txtGeneratePasswordHash;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnEncryptFiles;
        private System.Windows.Forms.ProgressBar encryptionProgressBar;
        private System.Windows.Forms.Label lblEncrptionPercentage;
        private System.Windows.Forms.Label lblMbSizeLeftToEncrypt;
        private System.Windows.Forms.Label lblEncrptionSpeed;
        private System.Windows.Forms.RichTextBox txtOutPutInfo;
        private System.Windows.Forms.Label lblError;
        private System.ComponentModel.BackgroundWorker EncryptionBGWorker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOpenLogFile;
        private System.Windows.Forms.Button btnStopEncryption;
        private System.Windows.Forms.Button btnDecryptFiles;
        private System.Windows.Forms.CheckBox chkMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedFileName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSelectedFileSize;
    }
}

