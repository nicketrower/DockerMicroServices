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
        public async Task<ItemResponse<MusicLibraryList>> AddMusicLibrary(MusicLibraryList musicLibList)
        {
            musicLibList.Id = Guid.NewGuid().ToString();
            return await this._container.CreateItemAsync<MusicLibraryList>(musicLibList, new PartitionKey(musicLibList.Id));
            
        }

        public async Task<ItemResponse<MusicLibraryList>> DeleteMusicLibrarySegment(string id)
        {
            return await this._container.DeleteItemAsync<MusicLibraryList>(id, new PartitionKey(id));
        }

        public MusicLibraryList GetMusicLibrary(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ItemResponse<MusicLibraryList>> UpdateMusicLibrary(MusicLibraryList musicLibList)
        {   
           return await this._container.UpsertItemAsync<MusicLibraryList>(musicLibList, new PartitionKey(musicLibList.Id));
        }
    }
}
