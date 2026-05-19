using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public class LecturaAire : BaseEntity
    {
        public int SensorId { get; set; }
        public virtual SensorCalidadAire Sensor { get; set; } = null!;
        public string TipoGas { get; set; }
        public float? PM25 { get; set; }
        public float? PM10 { get; set; }
        public float? CO2 { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
