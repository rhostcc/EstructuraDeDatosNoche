using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.interfaces;

namespace AppListaSimple.clases
{
    internal class ListaSimple<T> : IListaSimple<T>
    {
        private NodoSimple<T> _root;
        private int _count;
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void InsertAt(int index, T element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void UpdateAt(int index, T element)
        {
            throw new NotImplementedException();
        }
    }
}
