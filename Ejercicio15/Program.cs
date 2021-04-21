using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {

            int Resultado;

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingresa tu nombre");
            Console.WriteLine("-------------------------------------------------------------------------");

            string nombre1 = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
            Console.WriteLine("-------------------------------------------------------------------------");

            int edad1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa otro nombre");
            Console.WriteLine("-------------------------------------------------------------------------");

            string nombre2 = Console.ReadLine();

            Console.WriteLine("Ingresa otra edad");
            Console.WriteLine("-------------------------------------------------------------------------");

            int edad2 = int.Parse(Console.ReadLine());

            if (edad1 > edad2)
            {
                Console.WriteLine("El nombre con la edad más avanzada es: " + nombre1);
                Console.WriteLine("-------------------------------------------------------------------------");

                Resultado = edad1 - edad2;

                Console.WriteLine("Y la diferencia entre sus edades es: " + Resultado);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El nombre con la edad menor es: " + nombre1);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            if (edad1 < edad2)
            {
                Console.WriteLine("El nombre con la edad más avanzada es: " + nombre2);
                Console.WriteLine("-------------------------------------------------------------------------");

                Resultado = edad2 - edad1;

                Console.WriteLine("Y la diferencia entre sus edades es: " + Resultado);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El nombre con la edad menor es: " + nombre2);
                Console.WriteLine("-------------------------------------------------------------------------");

            }


            Console.ReadLine();
        }
    }
}
