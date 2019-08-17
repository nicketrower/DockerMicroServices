using Friends.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.API.Repository
{
    public interface IFriendService
    {
        Task<FriendList> GetFriends(string id);
        bool RemoveFriend(string id);
        Task<FriendList> AddFriend(FriendList friendInfo);
    }
}
