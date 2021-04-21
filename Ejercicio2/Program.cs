using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingrese un numero");
            Console.WriteLine("-------------------------------------------------------------------------");

            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 2)
            {
                Console.WriteLine("Este numero es par");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Este numero es impar");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
