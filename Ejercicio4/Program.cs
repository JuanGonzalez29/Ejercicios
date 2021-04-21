using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Velocidad;
            int Distancia;
            int Tiempo = 6;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingrese la distancia que desea viajar: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            Distancia = int.Parse(Console.ReadLine());

            Velocidad = Distancia / Tiempo;

            Console.WriteLine("Usted se desplazara a esta velocidad: " + Velocidad + (" Km" + "En estas horas: " + Tiempo + " Horas"));
            Console.WriteLine("-------------------------------------------------------------------------");

            if (Velocidad > 100)
            {
                Console.WriteLine("El vehículo debe circular a alta velocidad ");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El vehículo viajará a velocidad moderada");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
