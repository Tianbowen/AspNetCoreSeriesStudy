﻿using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IOwnerRepository:IRepositoryBase<Owner>
    {
        PagedList<Owner> GetOwners(OwnerParameters ownerParameters);

        IEnumerable<Owner> GetAllOwners();

        Owner GetOwnerById(Guid ownerId);

        Owner GetOwnerWithDetails(Guid ownerId);

        void CreateOwner(Owner owner);

        void UpdateOwner(Owner owner);

        void DeleteOwner(Owner owner);
    }
}
