﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPila.interfaces
{
    internal interface IPila<T>
    {
        void Push(T element);
        T Pop();
        T Peek();
        int Size();
        bool IsEmpty();
        bool IsFull();
    }
}
