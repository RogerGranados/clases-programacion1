using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un arreglo de números del 1 al 100
            int[] numeros = Enumerable.Range(1, 100).ToArray();

            // Usar LINQ para filtrar los números primos
            var numerosprimos = numeros.Where(IsPrime).ToArray();

            // Mostrar los números primos
            Console.WriteLine("Los números primos entre 1 y 100 son:");
            foreach (var prime in numerosprimos)
            {
                Console.Write(prime + " ");
            }

            // Pausa para que el usuario pueda leer el mensaje final
            Console.WriteLine("\nPresione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }

        // Método para determinar si un número es primo
        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
