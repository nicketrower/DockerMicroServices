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
        MusicLibraryList UpdateMusicLibrary(MusicLibraryList account);
        MusicLibraryList DeleteMusicLibrarySegment(int id);
        Task<MusicLibraryList> AddMusicLibrary(MusicLibraryList musicLibList);
    }
}
