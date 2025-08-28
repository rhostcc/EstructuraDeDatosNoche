using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppArbolGeneral.clases;

namespace AppArbolGeneral.interfaces
{
    internal interface IArbolGeneral<T>
    {
        NodoGeneral<T> BuscarNodo(NodoGeneral<T> nodo, T valor);
        bool AgregarNodo(T valorPadre, T nuevoValor);
        void Mostrar(NodoGeneral<T> nodo, string indent = "");
        bool EliminarNodo(T valor);
        bool EliminarRecursivo(NodoGeneral<T> nodo, T valor);
        void RecorridoPreorden(NodoGeneral<T> nodo);
        void RecorridoPostorden(NodoGeneral<T> nodo);
    }
}
