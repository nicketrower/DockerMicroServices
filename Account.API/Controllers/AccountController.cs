using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Models;
using Account.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Account.API.Controllers
{
    [Route("account/v1")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _userService;

        public AccountController(IAccountService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public AccountInfo Get(int id)
        {
            return _userService.GetAccountInfo(id);
        }

       
        [HttpPost]
        public AccountInfo Post([FromBody] AccountInfo account)
        {
            return _userService.AddAccount(account);
        }

        [HttpPut]
        public AccountInfo Put([FromBody] AccountInfo account)
        {
            return _userService.UpdateAccountInfo(account);
        }


        [HttpDelete]
        public AccountInfo Delete(int id)
        {
            return _userService.DisableAccount(id);
        }
    }
}
