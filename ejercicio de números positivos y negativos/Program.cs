using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_números_positivos_y_negativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            // Bucle que se ejecuta hasta que se ingrese el número 0
            do
            {
                Console.Write("Ingrese un número (0 para salir): ");
                number = int.Parse(Console.ReadLine());

                if (number > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (number < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }
                else
                {
                    Console.WriteLine("Ha ingresado 0. El programa ha terminado.");
                }

            } while (number != 0);
            // codigo para que muestre el mensaje del finalizacion
            Console.WriteLine("Presione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}
