using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Models;
using MongoDB.Driver;
using MongoDB.Common;
using AutoMapper;

namespace Account.API.Repository
{
    public class AccountService : IAccountService
    {
        private readonly IMongoCollection<AccountInfo> _accounts;
        private readonly IMapper _mapper;

        public AccountService(IGabDatabaseSettings settings, IMapper mapper)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _accounts = database.GetCollection<AccountInfo>(settings.GabCollectionName);
            _mapper = mapper;
        }

        public AccountInfo AddAccount(AccountInfoDto account)
        {
            var accountDto = _mapper.Map<AccountInfo>(account);
            _accounts.InsertOne(accountDto);
            return accountDto;
        }

        public AccountInfo GetAccountInfo(string id)
        {
           return _accounts.Find<AccountInfo>(account => account.Id == id).FirstOrDefault();
        }

        public AccountInfo UpdateAccountInfo(string id, AccountInfoDto accountData)
        {
            var accountDto = _mapper.Map<AccountInfo>(accountData);
            _accounts.ReplaceOne(account => account.Id == id, accountDto);
            return accountDto;
        }
    }
}
