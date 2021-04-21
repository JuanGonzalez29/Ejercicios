using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Escriba una nota entre este rango (1-7)");
            Console.WriteLine("-------------------------------------------------------------------------");
            double num = double.Parse(Console.ReadLine());

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine("La nota que ingreso es correcta");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
