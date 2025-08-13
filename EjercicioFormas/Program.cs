using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioFormas.clases;
using EjercicioFormas.interfaces;

namespace EjercicioFormas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(5);
            Circulo c2 = new Circulo(8);
            Cuadrado cu1 = new Cuadrado(5);
            Cuadrado cu2 = new Cuadrado(6);
            Triangulo t1 = new Triangulo(2, 4);
            Triangulo t2 = new Triangulo(6, 5);
            List<Figura> figuras = new List<Figura>();
            figuras.Add(c1);
            figuras.Add(c2);
            figuras.Add(cu1);
            figuras.Add(cu2);
            figuras.Add(t1);
            figuras.Add(t2);

            foreach (var item in figuras)
            {
                //item.Dibujar();
                Console.WriteLine(item.CalcularArea());
            }
        }
        public static List<int> Generar(int cantidad)
        {
            List<int> resp = new List<int>();
            for (int i = 1; i <= cantidad; i++)
            {
                resp.Add(new Random().Next(100, 200));
            }
            return resp;
        }
    }
}
