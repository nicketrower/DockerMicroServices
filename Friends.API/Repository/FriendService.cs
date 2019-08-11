using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.API.Models;

namespace Friends.API.Repository
{
    public class FriendService : IFriendService
    {
        public FriendList AddFriend(FriendList friendInfo)
        {
            return friendInfo;
        }

        public List<FriendList> GetFriends(int id)
        {
            List<FriendList> friendList = new List<FriendList>();
            friendList.Add(new FriendList { FriendId = 1, FriendMusicId = 23 });
            friendList.Add(new FriendList { FriendId = 2, FriendMusicId = 24 });
            friendList.Add(new FriendList { FriendId = 3, FriendMusicId = 25 });

            return friendList;
        }

        public FriendList RemoveFriend(int id)
        {
            return new FriendList { FriendId = 3, FriendMusicId = 23 };
        }
    }
}
