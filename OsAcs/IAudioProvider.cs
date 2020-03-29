using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsAcs
{
    public interface IAudioProvider
    {
        Task<byte[]> RetrieveAudio(Guid sessionGuid);
        Task<string> RetrieveAudioPath(Guid sessionGuid);
    }
}
