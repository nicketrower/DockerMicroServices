using Account.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Repository
{
    public interface IAccountService
    {
        Task<AccountInfo> GetAccountInfo(string id);
        Task<AccountInfo> UpdateAccountInfo(string id, AccountInfo accountData);
        Task<AccountInfo> AddAccount(AccountInfo account);
    }
}
