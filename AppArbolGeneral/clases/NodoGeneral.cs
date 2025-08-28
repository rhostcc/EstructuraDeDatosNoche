using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArbolGeneral.clases
{
    internal class NodoGeneral<T>
    {
        public T Valor { get; set; }
        public List<NodoGeneral<T>> Hijos { get; set; }

        public NodoGeneral(T valor)
        {
            Valor = valor;
            Hijos = new List<NodoGeneral<T>>();
        }
    }
}
