using Account.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.API.Repository
{
    public interface IAccountService
    {
        AccountInfo GetAccountInfo(int id);
        AccountInfo UpdateAccountInfo(AccountInfo account);
        bool DisableAccount(int id);
        AccountInfo AddAccount(AccountInfo account);
    }
}
