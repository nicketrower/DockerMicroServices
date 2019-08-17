using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Friends.API.Models;
using Microsoft.Azure.Cosmos;
using MongoDB.Common;
using MongoDB.Driver;

namespace Friends.API.Repository
{
    public class FriendService : IFriendService
    {
        private Container _container;

        public FriendService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task<FriendList> AddFriend(FriendList friendInfo)
        {
            friendInfo.Id = Guid.NewGuid().ToString();
            await this._container.CreateItemAsync<FriendList>(friendInfo, new PartitionKey(friendInfo.Id));
            return friendInfo;
        }

        public async Task<FriendList> GetFriends(string id)
        {
            ItemResponse<FriendList> response = await this._container.ReadItemAsync<FriendList>(id, new PartitionKey(id));
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            return response.Resource;
        }

        public bool RemoveFriend(string id)
        {
            //_friends.DeleteOne(f => f.FriendId == id);
            return true;
        }
    }
}
