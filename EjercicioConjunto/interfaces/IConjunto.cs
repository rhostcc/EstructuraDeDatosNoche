using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioConjunto.interfaces
{
    internal interface IConjunto<T>
    {
        void Agregar(T elemento);
        void Eliminar(T elemento);
        bool Contiene(T elemento);
    }
}
