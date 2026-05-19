using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public string CreatedBy { get; set; }
    }
}
