using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class MealRepository : Repository<Meal>, IMealRepository
    {
        public MealRepository(DbContext context)
            : base(context)
        { }
    }
}
