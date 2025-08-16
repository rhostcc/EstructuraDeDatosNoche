using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCola.interfaces
{
    public interface IDocumento
    {
        string Nombre { get; set; }
        int CantidadPaginas { get; set; }
        ITipoDocumento Tipo { get; set; }
        DateTime FechaInicio { get; set; }
        int Tamano { get; set; }
    }
}
