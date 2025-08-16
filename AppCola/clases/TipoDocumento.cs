using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCola.interfaces;

namespace AppCola.clases
{
    internal class TipoDocumento : ITipoDocumento
    {
        public string Nombre { get; set; }
        public string Extension { get; set; }
        public string Programa { get; set; }
        public TipoDocumento() 
        {
            this.Nombre = "Desconocido";
            this.Extension = "Desconocido";
            this.Programa = "Desconocido";
        }
    }
}
