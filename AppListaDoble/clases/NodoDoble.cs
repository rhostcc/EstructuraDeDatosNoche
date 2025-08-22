using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDoble.clases
{
    internal class NodoDoble<T>
    {
        public T Value { get; set; }
        public NodoDoble<T> Next;
        public NodoDoble<T> Preview;
        public NodoDoble(T value)
        {
            this.Value = value;
            this.Next = null;
            this.Preview = null;
        }
    }
}
