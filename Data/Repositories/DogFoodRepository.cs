using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class DogFoodRepository : Repository<DogFood>, IDogFoodRepository
    {
        public DogFoodRepository(DbContext context)
            : base(context)
        { }
    }
}
