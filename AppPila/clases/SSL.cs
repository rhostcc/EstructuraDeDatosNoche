using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPila.interfaces;

namespace AppPila.clases
{
    internal class SSL : ISSL
    {
        public string EmitidoA { get; set; }
        public string EmitidoPor { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public SSL(string emitidoA)
        {
            this.EmitidoA = emitidoA;
            this.EmitidoPor = "";
            this.FechaInicio = DateTime.Now;
            this.FechaFin = DateTime.Now;
        }
        public string MostrarInformacion()
        {
            return $"A: {this.EmitidoA}, POR: {this.EmitidoPor}, " +
                $"Inicio: {this.FechaInicio}, FIN: {this.FechaFin}";
        }
    }
}
