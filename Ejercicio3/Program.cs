using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Velocidad;
            int Distancia;
            int Tiempo = 6;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingrese la distanciaa la cual desea recorrer: ");
            Console.WriteLine("-------------------------------------------------------------------------");

            Distancia = int.Parse(Console.ReadLine());

            Velocidad = Distancia / Tiempo;

            Console.WriteLine("Usted se estara desplazando a esta velocidad: " + Velocidad + (" Km"));
            Console.WriteLine("-------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
