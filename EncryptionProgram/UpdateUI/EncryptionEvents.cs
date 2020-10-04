namespace EncryptionProgram.UpdateUI
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using EncryptionProgram.Delegates;
    using EncryptionProgram.Model;
    using static EncryptionProgram.Delegates.EventDelegates;

    public class EncryptionEvents : IEncryptionEvents
    {
        private EncryptionView EncryptionView { get; set; }

        private Dictionary<int, Document> Documents { get; set; }

        private DelegateInvokes DelegateInvokes { get; set; }

        private string RootFolder { get; set; }

        public EncryptionEvents(EncryptionView encryptionView)
        {
            this.EncryptionView = encryptionView;
            this.Documents = new Dictionary<int, Document>();
            this.DelegateInvokes = new DelegateInvokes(this.EncryptionView);
        }

        public string BrowseFiles()
        {
            var openFolder = new FolderBrowserDialog();
            if (!Directory.Exists(Constants.CDrive))
            {
                return string.Empty;
            }

            openFolder.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult userClick = openFolder.ShowDialog();

            return (userClick == DialogResult.OK) ? openFolder.SelectedPath : string.Empty;
       }

        public void ClearFiles()
        {
            if (this.EncryptionView.EncryptionListBox.Items.Count > 0)
            {
                if (this.EncryptionView.EncryptionListBox.InvokeRequired)
                {
                    this.Documents = new Dictionary<int, Document>();
                    this.EncryptionView.EncryptionListBox.Invoke(new UpdateListBox(this.DelegateInvokes.ClearAllFiles));
                    return;
                }

                this.Documents = new Dictionary<int, Document>();
                this.DelegateInvokes.ClearAllFiles();
            }
        }

        public void OpenLogs()
        {
            if (!Directory.Exists(Constants.LogsFolderDirectory))
            {
                Directory.CreateDirectory(Constants.LogsFolderDirectory);
            }

            Process.Start(Constants.LogsFolderDirectory);
        }

        public void UpdateListBox(string folderPath)
        {
            this.RootFolder = folderPath;
            DirectoryInfo specifiedDirectory = new DirectoryInfo(folderPath);
            var index = 0;
            foreach (var file in specifiedDirectory.GetFiles(Constants.AllFiles, SearchOption.AllDirectories))
            {
                var document = new Document()
                {
                    Id = index++,
                    Name = file.Name,
                    Size = file.Length,
                    Bytes = File.ReadAllBytes(file.FullName),
                    FullPath = file.FullName,
                    Extension = Path.GetExtension(file.FullName),
                };

                // check thread Id so that they dont match to avoid confusion between threads
                if (this.EncryptionView.EncryptionListBox.InvokeRequired)
                {
                    this.Documents[document.Id] = document;
                    this.EncryptionView.EncryptionListBox.Invoke(new UpdateListBox(() => this.DelegateInvokes.AddingFilesListBox(document)));
                }
            }
        }

        public void UpdateSelectedLabel()
        {
            if (this.EncryptionView.SelectedFileNameLabel.InvokeRequired &&
                this.EncryptionView.SelectedFileSizeLabel.InvokeRequired)
            {
                this.EncryptionView.SelectedFileNameLabel.Invoke(new UpdateFileNameLabel(this.DelegateInvokes.SelectedFileName));
                this.EncryptionView.SelectedFileSizeLabel.Invoke(new UpdateFileSizeLabel(() => this.DelegateInvokes.SelectedFileSize(this.Documents)));
                return;
            }

            this.DelegateInvokes.SelectedFileName();
            this.DelegateInvokes.SelectedFileSize(this.Documents);
        }

        public void UpdateListBox(string[] files)
        {
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                Random rnd = new Random();
                var document = new Document()
                {
                    Id = rnd.Next(10000),
                    Name = fileInfo.Name,
                    Size = file.Length,
                    FullPath = fileInfo.FullName,
                    Bytes = File.ReadAllBytes(fileInfo.FullName),
                    Extension = Path.GetExtension(fileInfo.FullName),
                };

                // check thread Id so that they dont match to avoid confusion between threads
                if (this.EncryptionView.EncryptionListBox.InvokeRequired)
                {
                    this.Documents[document.Id] = document;
                    this.EncryptionView.EncryptionListBox.Invoke(new UpdateListBox(() => this.DelegateInvokes.AddingFilesListBox(document)));
                }
            }
        }

        public void UpdateTotalsTextBox()
        {
            if (this.EncryptionView.TotalFilesTextBox.InvokeRequired &&
                this.EncryptionView.TotalFileSizeTextBox.InvokeRequired)
            {
                this.EncryptionView.TotalFilesTextBox.Invoke(new UpdateTotalFilesTextBox(this.DelegateInvokes.TotalNumberOfFiles));
                this.EncryptionView.TotalFileSizeTextBox.Invoke(new UpdateTotalFileSizeTextBox(() => this.DelegateInvokes.TotalFilesSize(this.Documents)));
                return;
            }

            this.DelegateInvokes.TotalNumberOfFiles();
            this.DelegateInvokes.TotalFilesSize(this.Documents);
        }

        public void UpdateLogTextOut(string logText)
        {
            if (this.EncryptionView.LogOutPutRichTextBox.InvokeRequired)
            {
                this.EncryptionView.LogOutPutRichTextBox.Invoke(new UpdateLogOutPutRichTextBox(() => this.DelegateInvokes.LogTextToOutPutWindow(logText)));
                return;
            }

            this.DelegateInvokes.LogTextToOutPutWindow(logText);
        }

        public void UpdateTotalFileSizeLeftToEncrypt()
        {
            if (this.EncryptionView.FileSizeLeftToEncryptLabel.InvokeRequired)
            {
                this.EncryptionView.FileSizeLeftToEncryptLabel.Invoke(new UpdateFileSizeLeftToEncrypt(() => this.DelegateInvokes.FileSizeLeftToEncrypt(this.RootFolder)));
                return;
            }

            this.DelegateInvokes.FileSizeLeftToEncrypt(this.RootFolder);
        }

        public void UpdateTimeElasped(TimeSpan timeSpan)
        {
            if (this.EncryptionView.TimeElapsedLabel.InvokeRequired)
            {
                this.EncryptionView.TimeElapsedLabel.Invoke(new UpdateTimeElasped(() => this.DelegateInvokes.UpdateTimeElapsed(timeSpan)));
            }

            this.DelegateInvokes.UpdateTimeElapsed(timeSpan);
        }

        public void RemoveFile(object selectedFile)
        {
            this.EncryptionView.EncryptionListBox.Items.Remove(selectedFile);

            var key = this.Documents.FirstOrDefault(x => x.Value.Name.ToString() == selectedFile.ToString()).Key;
            if (key >= 0)
            {
                this.Documents.Remove(key);
            }
        }

        public List<Document> GetAllFiles()
        {
            return this.Documents.Select(docs => docs.Value).ToList();
        }
    }
}
