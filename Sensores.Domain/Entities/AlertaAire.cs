using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public class AlertaAire : BaseEntity
    {
        public string SensorId { get; set; }
        public SensorCalidadAire Sensor { get; set; }
        public string Nivel { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
