using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioConjunto.clases;

namespace EjercicioConjunto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conjunto<int> conjunto = new Conjunto<int>();
            conjunto.Agregar(2);
            conjunto.Agregar(4);
            conjunto.Agregar(6);
            conjunto.Eliminar(2);
            Console.WriteLine($"Existe 5?: {conjunto.Contiene(5)}");
        }
    }
}
