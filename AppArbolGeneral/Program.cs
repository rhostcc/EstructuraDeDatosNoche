using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppArbolGeneral.clases;

namespace AppArbolGeneral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral<string> arbol = new ArbolGeneral<string>("C");
            arbol.AgregarNodo("C", "Archivos del programa");
            arbol.AgregarNodo("Archivos del programa", "7zip");
            arbol.AgregarNodo("Archivos del programa", "Adobe");
            arbol.AgregarNodo("Archivos del programa", "Aimp");
            arbol.AgregarNodo("C", "Archivos del programa (x86)");
            arbol.AgregarNodo("Archivos del programa (x86)", "Microsoft");
            arbol.AgregarNodo("Archivos del programa (x86)", "Nero");
            arbol.AgregarNodo("Archivos del programa (x86)", "Nitro");
            arbol.AgregarNodo("C", "Usuarios");
            arbol.AgregarNodo("Usuarios", "Toshiba");
            arbol.AgregarNodo("Usuarios", "Roger");
            arbol.AgregarNodo("C", "Windows");
            arbol.MostrarArbol();
            arbol.MostrarPreorden();
        }
    }
}
