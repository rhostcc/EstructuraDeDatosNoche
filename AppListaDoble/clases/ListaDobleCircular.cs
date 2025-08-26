using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaDoble.interfaces;

namespace AppListaDoble.clases
{
    internal class ListaDobleCircular<T> : IListaDoble<T>
    {
        private NodoDobleCircular<T> _first;
        private int _count;
        public ListaDobleCircular()
        {
            Clear();
        }
        public void Clear()
        {
            this._first = null;
            this._count = 0;
        }

        public int Count()
        {
            return this._count;
        }

        public void InsertAt(int index, T element)
        {
            NodoDobleCircular<T> newNodo = new NodoDobleCircular<T>(element);
            if (index < 0 || index > Count())
                throw new IndexOutOfRangeException("Indice incorrecto");

            if(IsEmpty())
            {
                this._first = newNodo;
                this._count++;
                return;
            }

            // Insertar al inicio
            if(index == 0)
            {
                this._first.Preview.Next = newNodo;
                newNodo.Preview = this._first.Preview;
                newNodo.Next = this._first;
                this._first.Preview = newNodo;
                this._first = newNodo;
                this._count++;
                return;
            }

            // Insertar en medio
            if (index < Count() - 1)
            {
                NodoDobleCircular<T> temp = this._first;
                int currentIndex = 0;
                while (currentIndex != index)
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
            this._first.Preview.Next = newNodo;
            newNodo.Preview = this._first.Preview;
            newNodo.Next = this._first;
            this._first.Preview = newNodo;
            this._count++;
        }
        public override string ToString()
        {
            string result = "";
            NodoDobleCircular<T> temp = this._first;
            for (int i = 0; i < Count(); i++)
            {
                result += $"({temp.Value})<=>";
                temp = temp.Next;
            }

            return result + "inicio";
        }

        public bool IsEmpty()
        {
            return this._first == null;
        }

        public T RemoveAt(int index)
        {
            T value;
            if (index < 0 || index >= Count())
                throw new IndexOutOfRangeException("Indice incorrecto");

            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Lista vacia");
            }

            if(Count() == 1)
            {
                value = this._first.Value;
                Clear();
                return value;
            }
            if(index == 0)
            {
                value = this._first.Value;
                this._first.Preview.Next = this._first.Next;
                this._first.Next.Preview = this._first.Preview;
                this._first = this._first.Next;
                this._count--;
                return value;
            }

            // Eliminiar en medio
            if(index > 0 && index < Count() - 1)
            {
                int currentIndex = 0;
                NodoDobleCircular<T> temp = this._first;
                while (currentIndex != index)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                temp.Preview.Next = temp.Next;
                temp.Next.Preview = temp.Preview;
                this._count--;
                return temp.Value;
            }

            value = this._first.Value;
            this._first.Preview.Next = this._first.Next;
            this._first.Next.Preview = this._first.Preview;
            this._count--;
            return value;
        }

        public void UpdateAt(int index, T element)
        {
            throw new NotImplementedException();
        }
    }
}
