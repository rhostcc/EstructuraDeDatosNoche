using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCola.interfaces;

namespace AppCola.clases
{
    public class Cola<T> : ICola<T>
    {
        private T[] _elementos;
        private int _inicio;
        private int _fin;
        private int _cantidad; // Elementos actuales
        private int _total; // Tamano de arreglo
        public Cola(int total)
        {
            this._elementos = new T[total];
            this._inicio = 0;
            this._fin = 0;
            this._cantidad = 0;
            this._total = total;
        }
        public int Count()
        {
            return this._cantidad;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Estructura vacia, no se puede quitar");
            }
            this._cantidad--;
            T aux = this._elementos[this._inicio];
            this._inicio++;
            if (this._inicio > this._total)
            {
                this._inicio = 0;
            }
            return aux;
        }

        public void Enqueue(T elemento)
        {
            if(IsFull())
            {
                throw new IndexOutOfRangeException("No se puede encolar, cola llena.");
            }
            this._elementos[this._fin] = elemento;
            this._fin++;
            if(this._fin > this._total)
            {
                this._fin = 0;
            }
            this._cantidad++;
        }

        public bool IsEmpty()
        {
            return this.Count() == 0;
        }

        public bool IsFull()
        {
            return this.Count() == this._total;
        }

        public T Peek()
        {
            if(IsEmpty())
            {
                throw new IndexOutOfRangeException("La cola no tiene elementos");
            }
            return this._elementos[this._inicio];
        }
    }
}
