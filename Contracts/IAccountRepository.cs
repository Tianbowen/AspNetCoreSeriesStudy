using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IAccountRepository:IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);

        PagedList<Account> GetAccountsByOwner(Guid ownerId, AccountParameters accountParameters);
    }
}
