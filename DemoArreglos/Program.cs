using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DemoArreglos.clases;

namespace DemoArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma("4.0f", "3.1f"));
            Console.WriteLine(Suma(4.0f, 3.1f));
            Console.WriteLine(Suma(4.7, 3.2));
            Console.WriteLine(Suma(4, 3));
        }
        public static T Suma<T>(T v1, T v2)
        {
            dynamic a = v1;
            dynamic b = v2;
            return a + b;
        }
    }
}
