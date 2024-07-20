using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablas_de_multiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            do
            {
                Console.Write("Ingrese un número entre 1 y 10 (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= 10)
                {
                    Console.WriteLine($"Tabla de multiplicar del {numero}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
                else if (numero == 0)
                {
                    Console.WriteLine("Ha ingresado el número 0. El programa ha terminado.");
                }
                else
                {
                    Console.WriteLine("Número inválido. Por favor ingrese un número entre 1 y 10.");
                }

            } while (numero != 0);

            // Pausa para poder leer el mensaje final
            Console.WriteLine("Presione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}
