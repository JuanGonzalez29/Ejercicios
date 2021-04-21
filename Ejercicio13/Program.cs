using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Cuantas notas quiere promediar");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1 - 2 notas");
            Console.WriteLine("2 - 4 notas");
            Console.WriteLine("3 - 6 notas");
            Console.WriteLine("4 - 8 notas");
            Console.WriteLine("-------------------------------------------------------------------------");

            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());
                if (nota1 >= 1 && nota1 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());
                if (nota2 >= 1 && nota2 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Double Nota = (nota1 + nota2) / 2;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            if (seleccion == 2)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());
                if (nota1 >= 1 && nota1 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());
                if (nota2 >= 1 && nota2 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());
                if (nota3 >= 1 && nota3 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());
                if (nota4 >= 1 && nota4 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Double Nota = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            if (seleccion == 3)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());
                if (nota1 >= 1 && nota1 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());
                if (nota2 >= 1 && nota2 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());
                if (nota3 >= 1 && nota3 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());
                if (nota1 >= 4 && nota4 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la quinta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota5 = double.Parse(Console.ReadLine());
                if (nota5 >= 1 && nota5 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la sexta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota6 = double.Parse(Console.ReadLine());
                if (nota6 >= 1 && nota6 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }

            if (seleccion == 4)
            {
                Console.WriteLine("Ingrese las dos notas que desea promediar");
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Ingrese la primera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota1 = double.Parse(Console.ReadLine());
                if (nota1 >= 1 && nota1 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la segunda nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota2 = double.Parse(Console.ReadLine());
                if (nota2 >= 1 && nota2 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la tercera nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota3 = double.Parse(Console.ReadLine());
                if (nota3 >= 1 && nota3 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la cuarta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota4 = double.Parse(Console.ReadLine());
                if (nota4 >= 1 && nota4 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la quinta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota5 = double.Parse(Console.ReadLine());
                if (nota5 >= 1 && nota5 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la sexta nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota6 = double.Parse(Console.ReadLine());
                if (nota6 >= 1 && nota6 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la Septima nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota7 = double.Parse(Console.ReadLine());
                if (nota7 >= 1 && nota7 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                Console.WriteLine("Ingrese la octava nota");
                Console.WriteLine("-------------------------------------------------------------------------");
                Double nota8 = double.Parse(Console.ReadLine());
                if (nota8 >= 1 && nota8 <= 7)
                {
                    Console.WriteLine("La nota ingresada es correcta");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("La nota ingresada no esta en el rango (1-7)");
                    Console.WriteLine("-------------------------------------------------------------------------");
                }

                Double Nota = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6 + nota7 + nota8) / 8;

                Console.WriteLine("El promedio de las dos notas es: " + Nota);
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
