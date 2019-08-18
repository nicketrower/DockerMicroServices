using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using MusicLibrary.API.Models;
using MusicLibrary.API.Repository;

namespace MusicLibrary.API.Controllers
{
    [Produces("application/json")]
    [Route("/music/v1")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private readonly IMusicLibService _musicService;
        private readonly IMapper _mapper;


        public MusicController(IMusicLibService musicService, IMapper mapper)
        {
            _musicService = musicService;
        }

        [HttpGet("{id}")]
        public MusicLibraryList Get(int id)
        {
            return _musicService.GetMusicLibrary(id);
        }


        [HttpPost]
        public async Task<ItemResponse<MusicLibraryList>> Post([FromBody] MusicLibraryListDto music)
        {
            return await _musicService.AddMusicLibrary(_mapper.Map<MusicLibraryList>(music));
        }

        [HttpPut("{id}")]
        public async Task<ItemResponse<MusicLibraryList>> Put([FromBody] MusicLibraryList musicLibList, string id)
        {
            return await _musicService.UpdateMusicLibrary(musicLibList);
        }


        [HttpDelete]
        public async Task<ItemResponse<MusicLibraryList>> Delete(string id)
        {
           return  await _musicService.DeleteMusicLibrarySegment(id);
        }
    }
}
