using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class DogFoodBrandRepository : Repository<DogFoodBrand>, IDogFoodBrandRepository
    {
        public DogFoodBrandRepository(DbContext context)
            : base(context)
        { }
    }
}
