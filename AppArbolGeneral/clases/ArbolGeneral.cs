using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppArbolGeneral.interfaces;

namespace AppArbolGeneral.clases
{
    internal class ArbolGeneral<T> : IArbolGeneral<T>
    {
        private NodoGeneral<T> _root;
        public ArbolGeneral(T value)
        {
            this._root = new NodoGeneral<T>(value);
        }
        public bool AgregarNodo(T valorPadre, T nuevoValor)
        {
            NodoGeneral<T> padre = BuscarNodo(this._root, valorPadre);
            if(padre == null) return false;
            padre.Hijos.Add(new NodoGeneral<T>(nuevoValor));
            return true;
        }

        public NodoGeneral<T> BuscarNodo(NodoGeneral<T> nodo, T valor)
        {
            if (nodo == null) return null;
            if (nodo.Valor.Equals(valor)) return nodo;
            foreach (NodoGeneral<T> hijo in nodo.Hijos)
            {
                NodoGeneral<T> encontrado = BuscarNodo(hijo, valor);
                if (encontrado != null) return encontrado;
            }
            return null;
        }

        public bool EliminarNodo(T valor)
        {
            if(this._root.Equals(valor))
            {
                this._root = null;
                return true;
            }
            return EliminarRecursivo(this._root, valor);
        }

        public bool EliminarRecursivo(NodoGeneral<T> nodo, T valor)
        {
            foreach (NodoGeneral<T> hijo in nodo.Hijos)
            {
                if (hijo.Valor.Equals(valor))
                {
                    nodo.Hijos.Remove(hijo);
                    return true;
                }
                if (EliminarRecursivo(hijo, valor))
                    return true;
            }
            return false;
        }

        public void MostrarArbol()
        {
            Mostrar(this._root);
        }
        public void Mostrar(NodoGeneral<T> nodo, string indent = "")
        {
            if (nodo == null) return;
            Console.WriteLine($"{indent}- {nodo.Valor}");
            foreach (NodoGeneral<T> hijo in nodo.Hijos)
                Mostrar(hijo, $"{indent}  ");
        }

        public void RecorridoPostorden(NodoGeneral<T> nodo)
        {
            throw new NotImplementedException();
        }
        public void MostrarPreorden()
        {
            RecorridoPreorden(this._root);
        }

        public void RecorridoPreorden(NodoGeneral<T> nodo)
        {
            if(nodo == null) return;
            Console.Write($" {nodo.Valor} ");
            foreach (NodoGeneral<T> hijo in nodo.Hijos)
            {
                RecorridoPreorden(hijo);
            }
        }
    }
}
