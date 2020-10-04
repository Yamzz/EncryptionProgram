// <copyright file="DelegateInvokes.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace EncryptionProgram.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using EncryptionProgram.Model;

    /// <summary>
    /// Class to hold functions called by delegates.
    /// </summary>
    public class DelegateInvokes
    {
        private EncryptionView EncryptionView { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateInvokes"/> class.
        /// </summary>
        public DelegateInvokes(EncryptionView encryptionView)
        {
            this.EncryptionView = encryptionView;
        }

        public static double ConvertBytesToMegabytes(double bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        /// <summary>
        /// Clear all Files.
        /// </summary>
        public void ClearAllFiles()
        {
            this.EncryptionView.BrowseFoldersTextBox.Text = string.Empty;
            this.EncryptionView.TotalFileSizeTextBox.Text = string.Empty;
            this.EncryptionView.TotalFilesTextBox.Text = string.Empty;
            this.EncryptionView.ErrorLabel.Visible = false;
            this.EncryptionView.ErrorLabel.Text = string.Empty;
            this.EncryptionView.EncryptionListBox.Items.Clear();
            this.EncryptionView.SelectedFileSizeLabel.Text = "n/a";
            this.EncryptionView.SelectedFileNameLabel.Text = "n/a";
        }

        public void AddingFilesListBox(Document document)
        {
            this.EncryptionView.EncryptionListBox.Items.Add(document.Name);
        }

        public void SelectedFileName()
        {
            this.EncryptionView.SelectedFileNameLabel.Text = this.EncryptionView.EncryptionListBox.SelectedItem.ToString();
        }

        public void SelectedFileSize(Dictionary<int, Document> documents)
        {
            this.EncryptionView.SelectedFileSizeLabel.Text = this.GetFileSize(this.EncryptionView.EncryptionListBox.SelectedItem.ToString(), documents);
        }

        public string GetFileSize(string selectedFile, Dictionary<int, Document> documents)
        {
            return ConvertBytesToMegabytes(documents.Values.FirstOrDefault(doc => doc.Name == selectedFile).Size).ToString("0.00") + " MB";
        }

        public void LogTextToOutPutWindow(string logText)
        {
            this.EncryptionView.LogOutPutRichTextBox.AppendText(logText + Environment.NewLine);
        }

        public void TotalNumberOfFiles()
        {
            this.EncryptionView.TotalFilesTextBox.Text = this.EncryptionView.EncryptionListBox.Items.Count.ToString();
        }

        public void TotalFilesSize(Dictionary<int, Document> documents)
        {
            double totalSize = 0;
            float totalFileSize = 0;
            if (this.EncryptionView.EncryptionListBox.Items.Count > 0)
            {
                foreach (var file in documents.Values)
                {
                    totalSize += file.Size;
                }

                totalFileSize = Convert.ToSingle(ConvertBytesToMegabytes(totalSize));
            }

            this.EncryptionView.TotalFileSizeTextBox.Text = totalFileSize.ToString("0.00") + " MB";
        }

        public void FileSizeLeftToEncrypt(string rootFolder)
        {
            this.EncryptionView.FileSizeLeftToEncryptLabel.Text = string.Format(
                "Original MB : {0} / NEW MB : {1}",
                this.EncryptionView.TotalFileSizeTextBox.Text,
                this.GetRemainingBytes(rootFolder).ToString("0.00") + " MB");
        }

        public void UpdateTimeElapsed(TimeSpan timeSpan)
        {
            this.EncryptionView.TimeElapsedLabel.Text = string.Format("Duration {0:0} second{1}", timeSpan.Seconds, timeSpan.Seconds == 1 ? string.Empty : "s");
        }

        private double GetRemainingBytes(string folderPath)
        {
            float totalSizeMB = 0;
            DirectoryInfo specifiedDirectory = new DirectoryInfo(folderPath);
            foreach (var file in specifiedDirectory.GetFiles(Constants.AllFiles, SearchOption.AllDirectories))
            {
                totalSizeMB += file.Length;
            }

            return ConvertBytesToMegabytes(totalSizeMB);
        }
    }
}
