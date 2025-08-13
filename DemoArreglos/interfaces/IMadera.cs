using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArreglos.interfaces
{
    internal interface IMadera
    {
        string Color { get; set; }
        string Material { get; set; }
        double Depreciar();
    }
}
