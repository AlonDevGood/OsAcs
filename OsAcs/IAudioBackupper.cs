using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsAcs
{
    public interface IAudioBackupper
    {
        Task<byte[]> RetrieveAudio();
    }
}
