using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class AccountRepository:RepositoryBase<Account>,IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {        


        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId)).ToList();
        }
   

        public PagedList<Account> GetAccountsByOwner(Guid ownerId, AccountParameters accountParameters)
        {
            return PagedList<Account>.ToPagedList(FindByCondition(a => a.OwnerId.Equals(ownerId)).OrderBy(x=>x.DateCreated), accountParameters.PageNumber, accountParameters.PageSize);
        }
    }
}
