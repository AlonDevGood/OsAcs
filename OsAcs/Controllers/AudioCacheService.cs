using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharpCifs;
using SharpCifs.Smb;

namespace OsAcs.Controllers
{
    [Route("")]
    [ApiController]
    public class AudioCacheService : ControllerBase
    {
        // GET api/values
        [HttpGet("GetAudioPath")]
        public async Task<ActionResult<string>> GetAudioPath(Guid sessionGuid)
        {
            var folder = new SmbFile("smb://Alon Amrani:alon1023@DESKTOP-AQLIK4S/Users/Efrat/Desktop/Hackathon/AlonShare");
            
            return folder.Length().ToString(); 
        }
        // GET api/values/5
        [HttpGet("GetAudio")]
        public async Task<ActionResult<byte[]>> GetAudio(Guid sessionGuid)
        {
            return new byte[] { };
        }
    }
}
