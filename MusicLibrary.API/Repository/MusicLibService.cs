using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MongoDB.Common;
using MongoDB.Driver;
using MusicLibrary.API.Models;

namespace MusicLibrary.API.Repository
{
    public class MusicLibService : IMusicLibService
    {
        private readonly IMongoCollection<MusicLibraryList> _music;
        private readonly IMapper _mapper;

        public MusicLibService(IGabDatabaseSettings settings, IMapper mapper)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _music = database.GetCollection<MusicLibraryList>(settings.GabCollectionName);
            _mapper = mapper;
        }
        public MusicLibraryList AddMusicLibrary(MusicLibraryListDto musicLibList)
        {
            var musicDto = _mapper.Map<MusicLibraryList>(musicLibList);
            _music.InsertOne(musicDto);
            return musicDto;
        }

        public MusicLibraryList DeleteMusicLibrarySegment(int id)
        {
            throw new NotImplementedException();
        }

        public MusicLibraryList GetMusicLibrary(int id)
        {
            throw new NotImplementedException();
        }

        public MusicLibraryList UpdateMusicLibrary(MusicLibraryList account)
        {
            throw new NotImplementedException();
        }
    }
}
