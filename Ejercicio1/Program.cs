using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Insertar una nota del 1 al 7");
            Console.WriteLine("-------------------------------------------------------------------------");
            int nota = 0;
            nota = int.Parse(Console.ReadLine());
            if (nota < 1)
            {   
                Console.WriteLine("La nota esta incorrecta");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("La nota esta incorrecta");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else if (nota >= 1 && nota <= 7)
            {
                Console.WriteLine("La nota no es correcta");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}
