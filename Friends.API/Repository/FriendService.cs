using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Friends.API.Models;
using MongoDB.Common;
using MongoDB.Driver;

namespace Friends.API.Repository
{
    public class FriendService : IFriendService
    {
        private readonly IMongoCollection<FriendList> _friends;
        private readonly IMapper _mapper;

        public FriendService(IGabDatabaseSettings settings, IMapper mapper)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _friends = database.GetCollection<FriendList>(settings.GabCollectionName);
            _mapper = mapper;
        }

        public FriendList AddFriend(FriendListDto friendInfo)
        {
            var friendDto = _mapper.Map<FriendList>(friendInfo);
            _friends.InsertOne(friendDto);
            return friendDto;
        }

        public List<FriendList> GetFriends(string id)
        {
            return _friends.Find<FriendList>(a => a.AccountId == id).ToList();
        }

        public bool RemoveFriend(string id)
        {
            _friends.DeleteOne(f => f.FriendId == id);
            return true;
        }
    }
}
