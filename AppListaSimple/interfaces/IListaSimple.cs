using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppListaSimple.interfaces
{
    internal interface IListaSimple<T>
    {
        void InsertAt(int index, T element);
        T RemoveAt(int index);
        void UpdateAt(int index, T element);
        bool IsEmpty();
        int Count();
        void Clear();
    }
}
