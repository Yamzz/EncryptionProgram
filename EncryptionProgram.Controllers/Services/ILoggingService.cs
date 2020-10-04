using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionProgram.Controllers.Services
{
    public interface ILoggingService
    {
        void SaveLogFile(string logText);
    }
}
