using EncryptionProgram.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace EncryptionProgram.Controllers.Services
{
    public class EncryptionEvents : IEncryptionEvents
    {
        public void BrowseFiles(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        public void ClearAllFilesToBeEncrypted(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        public void RemoveSingleFileToBeEncrypted(object sender, EventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        public void OpenLogs()
        {
            if (!Directory.Exists(Constants.LogsFolderDirectory))
            {
                Directory.CreateDirectory(Constants.LogsFolderDirectory);
            }

            Process.Start(Constants.LogsFolderDirectory);
        }
    }
}
