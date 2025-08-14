using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace AppPila.interfaces
{
    internal interface ISSL
    {
        string EmitidoA { get; set; }
        string EmitidoPor { get; set; }
        DateTime FechaInicio { get; set; }
        DateTime FechaFin { get; set; }
        string MostrarInformacion();
    }
}
