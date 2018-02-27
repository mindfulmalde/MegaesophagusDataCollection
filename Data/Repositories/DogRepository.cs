using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class DogRepository : Repository<Dog>, IDogRepository
    {
        public DogRepository(DbContext context)
            : base(context)
        { }
    }
}
