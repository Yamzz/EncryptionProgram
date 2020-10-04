namespace EncryptionProgram.UpdateUI
{
    using System;
    using System.Collections.Generic;
    using EncryptionProgram.Model;

    public interface IEncryptionEvents
    {
        string BrowseFiles();

        void ClearFiles();

        void RemoveFile(object selectedFile);

        void OpenLogs();

        void UpdateListBox(string folderPath);

        void UpdateListBox(string[] files);

        void UpdateTotalsTextBox();

        void UpdateSelectedLabel();

        List<Document> GetAllFiles();

        void UpdateLogTextOut(string logText);

        void UpdateTotalFileSizeLeftToEncrypt();

        void UpdateTimeElasped(TimeSpan elapsedMilliseconds);
    }
}
