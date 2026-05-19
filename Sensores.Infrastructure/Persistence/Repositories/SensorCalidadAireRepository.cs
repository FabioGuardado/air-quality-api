using Sensores.Domain.Entities;
using Sensores.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Infrastructure.Persistence.Repositories
{
    public class SensorCalidadAireRepository : BaseRepository<SensorCalidadAire>, ISensorCalidadAireRepository
    {
        public SensorCalidadAireRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
