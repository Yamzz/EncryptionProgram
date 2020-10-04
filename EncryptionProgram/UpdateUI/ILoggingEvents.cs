namespace Encryption_Program.UpdateUI
{
    using System.Windows.Forms;

    public interface ILoggingEvents
    {
        void SaveLogFile(RichTextBox txtOutPutInfo);

        void LogTextToOutput(string logText);
    }
}
