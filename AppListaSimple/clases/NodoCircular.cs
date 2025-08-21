using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.clases
{
    internal class NodoCircular<T>
    {
        public T Value { get; set; }
        public NodoCircular<T> Next;
        public NodoCircular(T Value)
        {
            this.Value = Value;
            this.Next = this;
        }
    }
}
