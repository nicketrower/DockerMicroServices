using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Models;
using Account.API.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.API.Controllers
{
    [Route("/account/v1")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _userService;

        public AccountController(IAccountService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                return Ok(await _userService.GetAccountInfo(id));
            } catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

       
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountInfo account)
        {
         
            try
            {
                return Ok(await _userService.AddAccount(account));
            } catch (Exception ex) {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] AccountInfo accountData)
        {
            try
            {
                return Ok(await _userService.UpdateAccountInfo(id, accountData));
            } catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
