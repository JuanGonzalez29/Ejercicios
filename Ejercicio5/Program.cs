using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Cuantas notas desea promediar");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1 - 2 notas");
            Console.WriteLine("2 - 4 notas");
            Console.WriteLine("3 - 6 notas");
            Console.WriteLine("4 - 8 notas");
            Console.WriteLine("-------------------------------------------------------------------------");

            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2) / 2;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            if (seleccion == 2)
            {
                Console.WriteLine("Ingrese las dos notas que quiere promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");

                Double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            if (seleccion == 3)
            {
                Console.WriteLine("Ingrese las dos notas que quiera promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la quinta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la sexta nota");
                Console.WriteLine("-------------------------------------------------------------------------");

                Double nota6 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            if (seleccion == 4)
            {
                Console.WriteLine("Ingrese las dos notas que quiera promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la quinta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota5 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la sexta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota6 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la Septima nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota7 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la octava nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota8 = double.Parse(Console.ReadLine());

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6 + nota7 + nota8) / 8;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
