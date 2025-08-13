using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPila.interfaces;

namespace AppPila.clases
{
    internal class Pila<T> : IPila<T>
    {
        private T[] _elementos;
        private int _longitud;
        private int _tope;
        public Pila(int longitud)
        {
            this._elementos = new T[longitud];
            this._longitud = 0;
            this._tope = -1;
        }
        public bool IsEmpty()
        {
            return this._longitud == 0;
        }

        public bool IsFull()
        {
            return this._tope == this._longitud - 1;
        }

        public T Peek()
        {
            return this._elementos[this._tope];
        }

        public T Pop()
        {
            throw new NotImplementedException();
        }

        public void Push(T element)
        {
            if(IsFull())
            {
                throw new IndexOutOfRangeException("La pila esta llena," +
                    "no se pueden agregar elementos");
            }
            this._tope++;
            this._elementos[this._tope] = element;
            this._longitud++;
        }

        public int Size()
        {
            return this._longitud;
        }
    }
}
