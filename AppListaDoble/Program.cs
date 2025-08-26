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
            ListaDoble<int> ld = new ListaDoble<int>();
            ld.InsertAt(0, 1);
            ld.InsertAt(1, 2);
            ld.InsertAt(2, 3);
            ld.InsertAt(0, 4);
            ld.InsertAt(2, 5);
            // 4 1 5 2 3 
            ld.RemoveAt(0);
            ld.RemoveAt(2);
            ld.RemoveAt(ld.Count() - 1);
            // 1 5 
            Console.WriteLine(ld.ToString());
        }
    }
}
