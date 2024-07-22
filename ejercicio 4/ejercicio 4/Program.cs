using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número para determinar si es o no un número primo: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 2)
            {
                Console.WriteLine($"{numero} no es un número primo. ");
            }
            else
            {
                bool esprimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    { esprimo = false; break; }
                }
                if (esprimo)
                { Console.WriteLine($"{numero} es un número primo. ");
                }
                else
                {
                    Console.WriteLine($"{numero} no es un número primo");
                }

            }
            Console.WriteLine("Presione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}
