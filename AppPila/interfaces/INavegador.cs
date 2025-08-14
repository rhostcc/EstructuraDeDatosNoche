using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPila.clases;

namespace AppPila.interfaces
{
    internal interface INavegador
    {
        string URL { get; set; }
        SSL Certificado { get; set; }
        string Contenido { get; set; }
        string MostrarInformacion();
    }
}
