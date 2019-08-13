using Account.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Repository
{
    public interface IAccountService
    {
        AccountInfo GetAccountInfo(string id);
        AccountInfo UpdateAccountInfo(string id, AccountInfoDto accountData);
        AccountInfo AddAccount(AccountInfoDto account);
    }
}
