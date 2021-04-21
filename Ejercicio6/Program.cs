using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingrese un numero: ");
            Console.WriteLine("-------------------------------------------------------------------------");

            int Num = int.Parse(Console.ReadLine());

            for (int contador = 1; contador < Num; contador += 2)
            {
                Console.WriteLine(contador);
            }
            Console.WriteLine("Los numeros son impares");
            Console.WriteLine("-------------------------------------------------------------------------");
        }
    }
}
