using System;
using System.Collections.Generic;
using System.Text;

namespace Sensores.Domain.Entities
{
    public class SensorCalidadAire : BaseEntity
    {
        public string Ubicacion { get; set; }
        public string Estado { get; set; } = "Activo";
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public virtual ICollection<LecturaAire> Lecturas { get; set; } = new List<LecturaAire>();
        public virtual ICollection<AlertaAire> Alertas { get; set; } = new List<AlertaAire>();
    }
}
