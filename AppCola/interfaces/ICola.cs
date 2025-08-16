using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCola.interfaces
{
    public interface ICola<T>
    {
        void Enqueue(T elemento);
        T Dequeue();
        T Peek();
        bool IsEmpty();
        bool IsFull();
        int Count();
    }
}
