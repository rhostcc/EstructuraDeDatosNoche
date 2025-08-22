using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.interfaces;

namespace AppListaSimple.clases
{
    internal class ListaCircular<T> : IListaSimple<T>
    {
        private NodoCircular<T> _last; // Ultimo nodo
        private int _count;
        public ListaCircular()
        {
            Clear();
        }
        public void Clear()
        {
            this._last = null;
            this._count = 0;
        }

        public int Count()
        {
            return this._count;
        }

        public void InsertAt(int index, T element)
        {
            NodoCircular<T> newNodo = new NodoCircular<T>(element);
            if (index < 0 || index > this._count)
                throw new IndexOutOfRangeException("Indice incorrecto");

            if (IsEmpty())
            {
                this._last = newNodo;
                this._count++;
                return;
            }

            if(index == 0) // Insertar al inicio
            {
                newNodo.Next = this._last.Next;
                this._last.Next = newNodo;
                this._count++;
                return;
            }
            // Insertar en medio
            if (index > 0 && index < this._count)
            {
                int currentIndex = 0;
                NodoCircular<T> temp = this._last.Next;
                while (currentIndex < index - 1)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                newNodo.Next = temp.Next;
                temp.Next = newNodo;
                this._count++;
                return;
            }

            if (index == this._count)
            {
                newNodo.Next = this._last.Next;
                this._last.Next = newNodo;
                this._last = newNodo;
                this._count++;
                return;
            }

        }
        public override string ToString()
        {
            string result = "";
            NodoCircular<T> temp = this._last.Next;
            while(temp != this._last)
            {
                result += $"({temp.Value})->";
                temp = temp.Next;
            }
            result += $"({temp.Value})->Inicio";
            return result;
        }
        public bool IsEmpty()
        {
            return this._last == null;
        }

        public T RemoveAt(int index)
        {
            T value;
            NodoCircular<T> temp;
            if (index < 0 || index >= this._count)
                throw new IndexOutOfRangeException("Indice incorrecto");

            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("Lista vacia");
            }

            if (Count() == 1)
            {
                value = this._last.Value;
                Clear();
                return value;
            }

            // Eliminar al inicio
            if(index == 0)
            {
                value = this._last.Next.Value;
                this._last.Next = this._last.Next.Next;
                this._count--;
                return value;
            }

            // Eliminar en medio
            if(index < Count() - 1)
            {
                temp = this._last.Next;
                int currentIndex = 0;
                while (currentIndex < index - 1)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                value = temp.Next.Value;
                temp.Next = temp.Next.Next;
                this._count--;
                return value;
            }



            // Eliminar al final
            value = this._last.Value;
            temp = this._last.Next;
            while (temp.Next != this._last)
            {
                temp = temp.Next;
            }
            temp.Next = temp.Next.Next;
            this._last = temp;
            this._count--;
            return value;
        }

        public void UpdateAt(int index, T element)
        {
            throw new NotImplementedException();
        }
    }
}
