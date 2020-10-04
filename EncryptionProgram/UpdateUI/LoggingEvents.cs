namespace Encryption_Program.UpdateUI
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using EncryptionProgram.Model;
    using EncryptionProgram.UpdateUI;

    public class LoggingEvents : ILoggingEvents
    {
        private IEncryptionEvents encryptionEvents;

        public LoggingEvents(IEncryptionEvents encryptionEvents)
        {
            this.encryptionEvents = encryptionEvents;
        }

        public void LogTextToOutput(string logText)
        {
            this.encryptionEvents.UpdateLogTextOut(logText);
        }

        public void SaveLogFile(RichTextBox txtOutPutInfo)
        {
            try
            {
                if (txtOutPutInfo.Text != string.Empty)
                {
                    string dir = @"c:\\encryptionProgramLogs\\" + DateTime.Today.ToString("dd-MMM-yy");
                    string path = @"c:\\encryptionProgramLogs\\" + DateTime.Today.ToString("dd-MMM-yy") + "\\" + "encryption-log-".ToString() + "-" + DateTime.Now.ToString("HH.mm.ss") + ".log";
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    if (!File.Exists(path))
                    {
                        Constants.LogsFolderDirectory = path;
                        txtOutPutInfo.SaveFile(path, RichTextBoxStreamType.PlainText);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
