using Friends.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.API.Repository
{
    public interface IFriendService
    {
        List<FriendList> GetFriends(int id);
        FriendList RemoveFriend(int id);
        FriendList AddFriend(FriendList friendInfo);
    }
}
