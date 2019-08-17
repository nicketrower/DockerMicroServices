using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Account.API.Models;
using AutoMapper;
using Microsoft.Azure.Cosmos;

namespace Account.API.Repository
{
    public class AccountService : IAccountService
    {
        
        private Container _container;

        public AccountService(CosmosClient dbClient,string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task<AccountInfo> AddAccount(AccountInfo account)
        {
            account.Id = Guid.NewGuid().ToString();
            await this._container.CreateItemAsync<AccountInfo>(account, new PartitionKey(account.Id));
            return account;
        }

        public async Task<AccountInfo> GetAccountInfo(string id)
        {
            ItemResponse<AccountInfo> response = await this._container.ReadItemAsync<AccountInfo>(id, new PartitionKey(id));
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            return response.Resource;
        }

        public async Task<AccountInfo> UpdateAccountInfo(string id, AccountInfo accountData)
        {
            accountData.Id = Guid.NewGuid().ToString();
            await this._container.UpsertItemAsync<AccountInfo>(accountData, new PartitionKey(id));
            return accountData;
        }

    }
}
