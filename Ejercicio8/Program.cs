using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int diadesemana;
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingresa un numero");
            Console.WriteLine("-------------------------------------------------------------------------");
            diadesemana = Convert.ToInt32(Console.ReadLine());
            switch (diadesemana)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Error al ingresar el numero");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
            }
            Console.ReadLine();
        }
    }
}
