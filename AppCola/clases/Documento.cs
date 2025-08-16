using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCola.interfaces;

namespace AppCola.clases
{
    public class Documento : IDocumento
    {
        public string Nombre { get; set; }
        public int CantidadPaginas { get; set; }
        public ITipoDocumento Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public int Tamano { get; set; }

        public Documento()
        {
            this.FechaInicio = DateTime.Now;
        }
    }
}
