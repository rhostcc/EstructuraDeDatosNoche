using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppListaSimple.interfaces;

namespace AppListaSimple.clases
{
    internal class ListaSimple<T> : IListaSimple<T>
    {
        private NodoSimple<T> _root;
        private int _count;
        public ListaSimple()
        {
            Clear();
        }
        public void Clear()
        {
            this._root = null;
            this._count = 0;
        }
        public int Count()
        {
            return this._count;
        }
        public void InsertAt(int index, T element)
        {
            NodoSimple<T> newNodo = new NodoSimple<T>(element);
            if (index < 0 || index > this._count)
                throw new IndexOutOfRangeException("Indice incorrecto");

            // Insertar en lista vacia
            if(IsEmpty())
            {
                this._root = newNodo;
                this._count++;
                return;
            }

            // Insertar al Inicio
            if(index == 0)
            {
                newNodo.Next = this._root;
                this._root = newNodo;
                this._count++;
                return;
            }
            // Insertar en medio
            if(index > 0 && index < this._count)
            {
                int currentIndex = 0;
                NodoSimple<T> temp = this._root;
                while(currentIndex < index - 1)
                {
                    temp = temp.Next;
                    currentIndex++;
                }
                newNodo.Next = temp.Next;
                temp.Next = newNodo;
                this._count++;
                return;
            }

            // Insertar al final
            if (index == this._count)
            {
                NodoSimple<T> temp = this._root;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNodo;
                this._count++;
                return;
            }
        }
        public override string ToString()
        {
            string result = "";
            NodoSimple<T> temp = this._root;
            while (temp.Next != null)
            {
                result = result + $"({temp.Value})->";
                temp = temp.Next;
            }
            result = result + $"({temp.Value})->null";
            return result;
        }
        public bool IsEmpty()
        {
            return this._root == null;
        }
        public T RemoveAt(int index)
        {
            T value;
            if (index < 0 || index > this._count - 1)
                throw new IndexOutOfRangeException("Indice incorrecto");

            // Eliminar en lista vacia
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("La lista esta vacia");
            }

            // Eliminar al Inicio
            if (index == 0)
            {
                value = this._root.Value;
                this._root = this._root.Next;
                this._count--;
                return value;
            }
           
            int currentIndex = 0;
            NodoSimple<T> temp = this._root;
            while (currentIndex != index - 1)
            {
                temp = temp.Next;
                currentIndex++;
            }
            value = temp.Next.Value;
            temp.Next = temp.Next.Next;
            this._count--;
            return value;
        }
        public void UpdateAt(int index, T element)
        {
            if (index < 0 || index > this._count - 1)
                throw new IndexOutOfRangeException("Indice incorrecto");

            NodoSimple<T> temp = this._root;
            int currentIndex = 0;
            while(currentIndex != index)
            {
                temp = temp.Next;
                currentIndex++;
            }
            temp.Value = element;
        }
    }
}
