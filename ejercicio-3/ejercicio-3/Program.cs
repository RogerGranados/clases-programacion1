using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    class Venta
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un conjunto de datos de ventas
            List<Venta> ventas = new List<Venta>
        {
            new Venta { Id = 1, Cliente = "Juan", Producto = "Laptop", Cantidad = 1, Fecha = new DateTime(2023, 7, 1) },
            new Venta { Id = 2, Cliente = "Maria", Producto = "Mouse", Cantidad = 2, Fecha = new DateTime(2023, 7, 1) },
            new Venta { Id = 3, Cliente = "Juan", Producto = "Teclado", Cantidad = 1, Fecha = new DateTime(2023, 7, 2) },
            new Venta { Id = 4, Cliente = "Ana", Producto = "Monitor", Cantidad = 1, Fecha = new DateTime(2023, 7, 2) },
            new Venta { Id = 5, Cliente = "Maria", Producto = "Laptop", Cantidad = 1, Fecha = new DateTime(2023, 7, 3) },
            new Venta { Id = 6, Cliente = "Ana", Producto = "Mouse", Cantidad = 2, Fecha = new DateTime(2023, 7, 3) },
            new Venta { Id = 7, Cliente = "Juan", Producto = "Monitor", Cantidad = 1, Fecha = new DateTime(2023, 7, 3) },
            new Venta { Id = 8, Cliente = "Maria", Producto = "Teclado", Cantidad = 1, Fecha = new DateTime(2023, 7, 4) },
            new Venta { Id = 9, Cliente = "Juan", Producto = "Laptop", Cantidad = 1, Fecha = new DateTime(2023, 7, 4) },
            new Venta { Id = 10, Cliente = "Ana", Producto = "Teclado", Cantidad = 1, Fecha = new DateTime(2023, 7, 4) },
        };

            // Determinar cantidad de ventas por cliente
            var ventasPorCliente = ventas.GroupBy(v => v.Cliente)
                                         .Select(g => new { Cliente = g.Key, CantidadTotal = g.Sum(v => v.Cantidad) });

            // Determinar cantidad de ventas por producto
            var ventasPorProducto = ventas.GroupBy(v => v.Producto)
                                          .Select(g => new { Producto = g.Key, CantidadTotal = g.Sum(v => v.Cantidad) });

            // Determinar el día con más ventas
            var diaConMasVentas = ventas.GroupBy(v => v.Fecha)
                                        .Select(g => new { Fecha = g.Key, CantidadTotal = g.Sum(v => v.Cantidad) })
                                        .OrderByDescending(g => g.CantidadTotal)
                                        .FirstOrDefault();

            // Mostrar cantidad de ventas por cliente
            Console.WriteLine("Cantidad de ventas por cliente:");
            foreach (var vc in ventasPorCliente)
            {
                Console.WriteLine($"Cliente: {vc.Cliente}, Cantidad Total: {vc.CantidadTotal}");
            }

            // Mostrar cantidad de ventas por producto
            Console.WriteLine("\nCantidad de ventas por producto:");
            foreach (var vp in ventasPorProducto)
            {
                Console.WriteLine($"Producto: {vp.Producto}, Cantidad Total: {vp.CantidadTotal}");
            }

            // Mostrar el día con más ventas
            if (diaConMasVentas != null)
            {
                Console.WriteLine($"\nEl día con más ventas es: {diaConMasVentas.Fecha.ToShortDateString()}, con una cantidad total de: {diaConMasVentas.CantidadTotal}");
            }

            // Pausa para que el usuario pueda leer el mensaje final
            Console.WriteLine("\nPresione cualquier tecla para cerrar el programa...");
            Console.ReadKey();
        }
    }
}
