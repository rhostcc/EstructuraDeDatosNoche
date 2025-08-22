using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaDoble.interfaces;

namespace AppListaDoble.clases
{
    internal class ListaDoble<T> : IListaDoble<T>
    {
        private NodoDoble<T> _first;
        private NodoDoble<T> _last;
        private int _count;
        public ListaDoble()
        {
            Clear();
        }
        public void Clear()
        {
            this._count = 0;
            this._first = null;
            this._last = null;
        }

        public int Count()
        {
            return this._count;
        }

        public void InsertAt(int index, T element)
        {
            NodoDoble<T> newNodo = new NodoDoble<T>(element);
            if (index < 0 || index > this._count)
                throw new IndexOutOfRangeException("Indice incorrecto");

            // Insertar en lista vacia
            if (IsEmpty())
            {
                this._first = newNodo;
                this._last = newNodo;
                this._count++;
                return;
            }

            // Insertar al inicio
            if(index == 0)
            {
                this._first.Preview = newNodo;
                newNodo.Next = this._first;
                this._first = newNodo;
                this._count++;
                return;
            }

            // Insertar en medio
            if(index < Count() - 1)
            {
                NodoDoble<T> temp = this._first;
                int currentIndex = 0;
                while(currentIndex != index)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                temp.Preview.Next = newNodo;
                newNodo.Preview = temp.Preview;
                newNodo.Next = temp;
                temp.Preview = newNodo;
                this._count++;
                return;
            }

            // Insertar al final
            if(index == Count())
            {
                this._last.Next = newNodo;
                newNodo.Preview = this._last;
                this._last = newNodo;
                this._count++;
                return;
            }
        }
        public override string ToString()
        {
            string result = "";
            NodoDoble<T> temp = this._first;
            while(temp != null)
            {
                result += $"<=>({temp.Value})<=>";
                temp = temp.Next;
            }
            return result;
        }

        public bool IsEmpty()
        {
            return this._first == null;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > this._count - 1)
                throw new IndexOutOfRangeException("Indice incorrecto");

            // Eliminar en lista vacia
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Lista vacia");
            }

            // Eliminar Inicio
            if(Count() == 1)
            {
                T value = this._first.Value;
                Clear();
                return value;
            }
        }

        public void UpdateAt(int index, T element)
        {
            throw new NotImplementedException();
        }
    }
}
