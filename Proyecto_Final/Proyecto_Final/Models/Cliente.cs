using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string DUI { get; set; }
    }
    }
