using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionProgram.Controllers.Services
{
    public interface IEncryptionEvents
    {
        void BrowseFiles(object sender, EventArgs eventArgs);
        void ClearAllFilesToBeEncrypted(object sender, EventArgs eventArgs);
        void RemoveSingleFileToBeEncrypted(object sender, EventArgs eventArgs);
        void OpenLogs();

    }
}
