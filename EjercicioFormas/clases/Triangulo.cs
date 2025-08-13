using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFormas.interfaces;

namespace EjercicioFormas.clases
{
    internal class Triangulo : Figura, IDibujable
    {
        public float Base { get; set; }
        public float Altura { get; set; }
        public Triangulo(float b, float h)
        {
            this.Nombre = "triangulo";
            this.Base = b;
            this.Altura = h;
        }
        public override float CalcularArea()
        {
            return (this.Base * this.Altura) / 2;
        }

        public void Dibujar()
        {
            Console.WriteLine($"La figura es: {Nombre}");
        }
    }
}
