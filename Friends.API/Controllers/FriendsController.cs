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
    [Route("/friends/v1")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private readonly IFriendService _friendService;

        public FriendsController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return Ok(_friendService.GetFriends(id));
            } catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] FriendListDto friend)
        {
            try
            {
                return Ok(_friendService.AddFriend(friend));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete("id")]
        public IActionResult Delete(string id)
        {
            try
            {
                return Ok(_friendService.RemoveFriend(id));
            } catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
