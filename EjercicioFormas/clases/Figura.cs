using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFormas.clases
{
    internal abstract class Figura
    {
        public string Nombre { get; set; }
        public abstract float CalcularArea();
    }
}
