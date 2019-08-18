using Microsoft.Azure.Cosmos;
using MusicLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.API.Repository
{
    public interface IMusicLibService
    {
        MusicLibraryList GetMusicLibrary(int id);
        Task<ItemResponse<MusicLibraryList>> UpdateMusicLibrary(MusicLibraryList musicLibList);
        Task<ItemResponse<MusicLibraryList>> DeleteMusicLibrarySegment(string id);
        Task<ItemResponse<MusicLibraryList>> AddMusicLibrary(MusicLibraryList musicLibList);
    }
}
