using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class VomitEpisodeRepository : Repository<VomitEpisode>, IVomitEpisodeRepository
    {
        public VomitEpisodeRepository(DbContext context)
            : base(context)
        { }
    }
}
