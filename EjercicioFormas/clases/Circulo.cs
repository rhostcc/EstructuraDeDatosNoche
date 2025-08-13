using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFormas.interfaces;

namespace EjercicioFormas.clases
{
    internal class Circulo : Figura, IDibujable
    {
        public float Radio { get; set; }
        public Circulo()
        {
            this.Nombre = "circulo";
            this.Radio = 0;
        }
        public Circulo(float radio)
        {
            this.Nombre = "circulo";
            this.Radio = radio;
        }
        public override float CalcularArea()
        {
            // Pi * (radio^2)
            return (float)Math.PI * (this.Radio * this.Radio);
            //return (float)Math.PI * Math.Pow(this.Radio, 2);
        }

        public void Dibujar()
        {
            Console.WriteLine($"La figura es: {Nombre}");
        }
    }
}
