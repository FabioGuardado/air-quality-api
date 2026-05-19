using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public class SensorCalidadAire : BaseEntity
    {
        public string Ubicacion { get; set; }
        public string Estado { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public List<LecturaAire> Lecturas { get; set; }
        public List<AlertaAire> Alertas { get; set; }
    }
}
