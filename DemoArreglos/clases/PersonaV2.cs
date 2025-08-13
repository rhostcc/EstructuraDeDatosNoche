using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArreglos.clases
{
    internal sealed partial class Persona
    {
        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + this.Nombre + " " + this.Apellido);
        }
    }
}
