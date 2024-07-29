using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de notas de evaluación
            List<int> notas = new List<int> { 7, 8, 9, 10, 6, 5, 8, 9, 7, 10 };

            // Usar LINQ para filtrar las notas sobresalientes (mayores o iguales a 8)
            var notasSobresalientes = notas.Where(nota => nota >= 8).ToList();

            // Mostrar las notas sobresalientes
            Console.WriteLine("Las notas sobresalientes (mayores o iguales a 8) son:");
            foreach (var nota in notasSobresalientes)
            {
                Console.Write(nota + " ");
            }

            // Pausa para que el usuario pueda leer el mensaje final
            Console.WriteLine("\nPresione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}