using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brindistrabajo111
{
    internal class Program
    {
        static void Main()
        {
            int[] arreglo = new int[10];
            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("ARREGLOS");
                Console.WriteLine("1.- leer arreglo");
                Console.WriteLine("2.- imprimir arreglo");
                Console.WriteLine("3.- imprimir el numero mayor");
                Console.WriteLine("4.- imprimir el numero menor");
                Console.WriteLine("5.- imprimir el promedio");
                Console.WriteLine("6.- salir");
                Console.Write("seleccionar una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                

                if (opcion == 1)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"elemento {i + 1}: ");
                        arreglo[i] = int.Parse(Console.ReadLine());
                    }
                }
                else if (opcion == 2)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(arreglo[i] + " ");
                    }
                    Console.WriteLine();
                }
                else if (opcion == 3)
                {
                    int mayor = arreglo[0];
                    for (int i = 1; i < 10; i++)
                    {
                        if (arreglo[i] > mayor) mayor = arreglo[i];
                    }
                    Console.WriteLine("el numero mayor es: " + mayor);
                }
                else if (opcion == 4)
                {
                    int menor = arreglo[0];
                    for (int i = 1; i < 10; i++)
                    {
                        if (arreglo[i] < menor) menor = arreglo[i];
                    }
                    Console.WriteLine("el numero menor es: " + menor);
                }
                else if (opcion == 5)
                {
                    int suma = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        suma += arreglo[i];
                    }
                    Console.WriteLine("el promedio es: " + (suma / 10.0));

                    Console.ReadKey();
                }
            }
        }
    }
}