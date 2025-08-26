using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaDoble.clases
{
    internal class NodoDobleCircular<T>
    {
        public T Value { get; set; }
        public NodoDobleCircular<T> Next;
        public NodoDobleCircular<T> Preview;
        public NodoDobleCircular(T value)
        {
            this.Value = value;
            this.Next = this;
            this.Preview = this;
        }
    }
}
