using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoALaEmpresa { get; set; }
        public List<String> Telefonos = new List<String>();
        public int EmpresaId { get; set; }

    }
}
