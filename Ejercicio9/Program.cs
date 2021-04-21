using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Ingresa un numero");
            Console.WriteLine("-------------------------------------------------------------------------");
            dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Enero");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Error al ingresar numero");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    break;
            }
            Console.ReadLine();
        }
    }
}
