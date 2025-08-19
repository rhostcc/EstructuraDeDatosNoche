using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.clases
{
    internal class NodoSimple<T>
    {
        public T Value { get; set; }
        public NodoSimple<T> Next;
        public NodoSimple(T Value)
        {
            this.Value = Value;
            this.Next = null;
        }
    }
}
