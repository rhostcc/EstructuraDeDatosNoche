using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFormas.interfaces;

namespace EjercicioFormas.clases
{
    internal class Cuadrado : Figura, IDibujable
    {
        public float Lado { get; set; }
        public Cuadrado(float l)
        {
            this.Nombre = "cuadrado";
            this.Lado = l;
        }
        public override float CalcularArea()
        {
            return this.Lado * this.Lado;
        }

        public void Dibujar()
        {
            Console.WriteLine($"La figura es: {Nombre}");
        }
    }
}
