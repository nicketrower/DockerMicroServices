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
    [Produces("applicaiton/json")]
    [Route("/account/v1")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _userService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
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
        public async Task<IActionResult> Post([FromBody] AccountInfoDto account)
        {

            try
            {
                return Ok(await _userService.AddAccount(_mapper.Map<AccountInfo>(account)));
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
