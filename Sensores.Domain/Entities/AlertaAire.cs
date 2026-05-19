using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public class AlertaAire : BaseEntity
    {
        public int SensorId { get; set; }
        public virtual SensorCalidadAire Sensor { get; set; } = null!;
        public string Nivel { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
