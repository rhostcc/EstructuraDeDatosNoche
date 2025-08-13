using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioConjunto.interfaces;

namespace EjercicioConjunto.clases
{
    internal class Conjunto<T> : IConjunto<T>
    {
        private HashSet<T> _valores;
        public Conjunto()
        {
            this._valores = new HashSet<T>();
        }
        public void Agregar(T elemento)
        {
            if(!this.Contiene(elemento))
            {
                this._valores.Add(elemento);
            }
        }

        public bool Contiene(T elemento)
        {
            return this._valores.Contains(elemento);
        }

        public void Eliminar(T elemento)
        {
            if(this.Contiene(elemento))
            {
                this._valores.Remove(elemento);
            }
        }
    }
}
