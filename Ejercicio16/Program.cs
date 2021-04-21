using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingresa numero");
            Console.WriteLine("-------------------------------------------------------------------------");

            int min = int.Parse(Console.ReadLine());
            int horas = 0;

            while (min > 59)
            {
                horas++;
                min -= 60;
            }
            Console.WriteLine("horas {0} y minutos {1}", horas, min);
            Console.WriteLine("-------------------------------------------------------------------------");
        }
    }
}
