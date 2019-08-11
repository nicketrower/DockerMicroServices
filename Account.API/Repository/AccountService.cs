using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Models;
using MongoDB.Driver;

namespace Account.API.Repository
{
    public class AccountService : IAccountService
    {
        private readonly IMongoCollection<AccountInfo> _accounts;

        public AccountService(IGabDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _accounts = database.GetCollection<AccountInfo>(settings.GabCollectionName);
        }

        public AccountInfo AddAccount(AccountInfo account)
        {
            _accounts.InsertOne(account);
            return account;
        }

        public bool DisableAccount(int id)
        {
            return true;
        }

        public AccountInfo GetAccountInfo(int id)
        {
            throw new NotImplementedException();
        }

        public AccountInfo UpdateAccountInfo(AccountInfo account)
        {
            throw new NotImplementedException();
        }
    }
}
