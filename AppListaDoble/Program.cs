using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using AppListaDoble.clases;

namespace AppListaDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaDobleCircular<int> ldc = new ListaDobleCircular<int>();
            ldc.InsertAt(0, 1);
            ldc.InsertAt(1, 2);
            ldc.InsertAt(2, 3);
            ldc.InsertAt(3, 4);
            ldc.InsertAt(0, 5);
            ldc.InsertAt(2, 6);
            // 5 1 6 2 3 4
            Console.WriteLine(ldc.ToString());
        }
    }
}
