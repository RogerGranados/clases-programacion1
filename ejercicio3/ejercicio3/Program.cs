using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            // Bucle para que se ejecute hasta que se ingrese un número negativo o cero
            do
            {
                Console.Write("Ingrese un número positivo (negativo o 0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;  // Para agregar el número ingresado a la suma total
                    Console.WriteLine($"La suma actual es: {suma}");
                }
                else if (numero <= 0)
                {
                    Console.WriteLine("Ha ingresado un número negativo o 0. El programa ha terminado.");
                }

            } while (numero > 0);

            // Aqui se mostrara la suma final
            Console.WriteLine($"La suma en  total de todos  los números positivos ingresados es: {suma}");

            // Pausa para que el usuario pueda leer el mensaje final
            Console.WriteLine("Presione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}
