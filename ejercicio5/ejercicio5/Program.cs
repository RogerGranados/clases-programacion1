using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            int conta = 0;

            Console.WriteLine("Ingrese una serie de número (0 para finalizar)");

            //bucle para que se ejecute hasta agregar 0.
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero != 0) 
                {
                    suma += numero; //para sumar el número ingresado al total.
                    conta++; // incrementar el contador de números ingresados
                }
            } while (numero != 0);

            if (conta > 0)
            {
                double average = (double)suma / conta;
                Console.WriteLine($"El promedio es: {average}");
            }
            else
            {
                Console.WriteLine("No se han ingresado números para calcular el promedio.");
            }

            Console.WriteLine("Presione cualquier tecla para cerrar el programa..");
            Console.ReadKey();
        }
    }
}
