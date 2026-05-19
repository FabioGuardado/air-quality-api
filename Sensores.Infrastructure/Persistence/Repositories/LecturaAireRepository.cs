using Sensores.Domain.Entities;
using Sensores.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Infrastructure.Persistence.Repositories
{
    public class LecturaAireRepository : BaseRepository<LecturaAire>, ILecturaAireRepository
    {
        public LecturaAireRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
