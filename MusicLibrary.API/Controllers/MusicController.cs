using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.API.Models;
using MusicLibrary.API.Repository;

namespace MusicLibrary.API.Controllers
{
    [Route("/music/v1")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicLibService _musicService;

        public MusicController(IMusicLibService musicService)
        {
            _musicService = musicService;
        }

        [HttpGet("{id}")]
        public MusicLibraryList Get(int id)
        {
            return _musicService.GetMusicLibrary(id);
        }


        [HttpPost]
        public MusicLibraryList Post([FromBody] MusicLibraryListDto music)
        {
            return _musicService.AddMusicLibrary(music);
        }

        [HttpPut]
        public MusicLibraryList Put([FromBody] MusicLibraryList music)
        {
            return _musicService.UpdateMusicLibrary(music);
        }


        [HttpDelete]
        public MusicLibraryList Delete(int id)
        {
            return _musicService.DeleteMusicLibrarySegment(id);
        }
    }
}
