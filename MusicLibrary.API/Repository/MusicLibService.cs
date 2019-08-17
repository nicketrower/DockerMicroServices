using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Azure.Cosmos;
using MongoDB.Common;
using MongoDB.Driver;
using MusicLibrary.API.Models;

namespace MusicLibrary.API.Repository
{
    public class MusicLibService : IMusicLibService
    {
        private Container _container;

        public MusicLibService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        public async Task<MusicLibraryList> AddMusicLibrary(MusicLibraryList musicLibList)
        {
            musicLibList.Id = Guid.NewGuid().ToString();
            await this._container.CreateItemAsync<MusicLibraryList>(musicLibList, new PartitionKey(musicLibList.Id));
            return musicLibList;
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
