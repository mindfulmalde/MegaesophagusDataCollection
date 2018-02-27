using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class BreedRepository : Repository<Breed>, IBreedRepository
    {
        public BreedRepository(DbContext context)
            : base(context)
        { }
    }
}
