using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.API.Models;
using Friends.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Friends.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private readonly IFriendService _friendService;

        public FriendsController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        [HttpGet("{id}")]
        public FriendList Get(int id)
        {
            return _friendService.GetFriends(id);
        }


        [HttpPost]
        public FriendList Post([FromBody] FriendList friend)
        {
            return _friendService.AddFriend(friend);
        }


        [HttpDelete]
        public FriendList Delete(int id)
        {
            return _friendService.RemoveFriend(id);
        }
    }
}
