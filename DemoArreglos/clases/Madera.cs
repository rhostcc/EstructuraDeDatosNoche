using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoArreglos.interfaces;

namespace DemoArreglos.clases
{
    internal class Madera
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public Madera()
        {

        }
        public Madera(string color)
        {
            this.Color = color;
        }
        public Madera(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
        public double Depreciar()
        {
            return 0;
        }

        ~Madera()
        {
            this.Color = "";
            this.Material = "";
        }
    }
}
