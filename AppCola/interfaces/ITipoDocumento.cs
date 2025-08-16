using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCola.interfaces
{
    public interface ITipoDocumento
    {
        string Nombre { get; set; }
        string Extension { get; set; }
        string Programa { get; set; }
    }
}
