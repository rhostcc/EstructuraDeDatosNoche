using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppListaSimple.clases;

namespace AppListaSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple<int> miLista = new ListaSimple<int>();
            miLista.InsertAt(0, 1);
            miLista.InsertAt(1, 2);
            miLista.InsertAt(2, 3);
            miLista.InsertAt(3, 4);
            miLista.InsertAt(4, 5);
            miLista.InsertAt(5, 6);

            miLista.InsertAt(1, 7);
            miLista.InsertAt(5, 8);
            Console.WriteLine(miLista.ToString());

        }
    }
}
