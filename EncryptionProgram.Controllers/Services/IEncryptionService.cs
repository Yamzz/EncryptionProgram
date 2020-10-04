using EncryptionProgram.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionProgram.Controllers.Services
{
    public interface IEncryptionService
    {
        void EncryptWithAES(EncryptionProcess encryptionProcess);
    }
}
