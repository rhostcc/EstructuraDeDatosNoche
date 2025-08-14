using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPila.interfaces;

namespace AppPila.clases
{
    internal class Navegador : INavegador
    {
        public string URL { get; set; }
        public SSL Certificado { get; set; }
        public string Contenido { get; set; }
        public Navegador(string url, string contenido)
        {
            this.URL = url;
            this.Certificado = null;
            this.Contenido = contenido;
        }
        public string MostrarInformacion()
        {
            throw new NotImplementedException();
        }
    }
}
