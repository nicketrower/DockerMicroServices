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
    [Produces("application/json")]
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
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                return Ok(await _friendService.GetFriends(id));
            } catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FriendList friend)
        {
            try
            {
                return Ok(await _friendService.AddFriend(friend));
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
