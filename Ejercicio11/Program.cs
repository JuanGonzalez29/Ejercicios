using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Anote el primer numero: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anote el segundo numero: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Anote el tercer numero: ");
            Console.WriteLine("-------------------------------------------------------------------------");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El Primer numero es par: " + num1);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El Primer numero es impar: " + num1);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("El Segundo numero es par: " + num2);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El Segundo numero es impar: " + num2);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            if (num3 % 2 == 0)
            {
                Console.WriteLine("El Tercer numero es par: " + num3);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("El Tercer numero es impar: " + num3);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
