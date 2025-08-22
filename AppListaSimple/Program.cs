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
            ListaCircular<int> miLista = new ListaCircular<int>();
            miLista.InsertAt(0, 1);
            miLista.InsertAt(1, 2);
            miLista.InsertAt(2, 3);
            miLista.InsertAt(3, 4);
            miLista.InsertAt(4, 5);
            miLista.InsertAt(5, 10);
            Console.WriteLine(miLista.ToString());

            miLista.RemoveAt(2); // Eliminando el primero
            Console.WriteLine(miLista.ToString());
            //miLista.RemoveAt(miLista.Count() - 1); // Eliminando el ultimo
            //miLista.RemoveAt(1); // Eliminando el segundo
            //Console.WriteLine(miLista.ToString());

        }
    }
}
