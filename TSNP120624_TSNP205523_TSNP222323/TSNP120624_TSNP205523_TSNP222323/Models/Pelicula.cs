using System.ComponentModel.DataAnnotations;

namespace TSNP120624_TSNP205523_TSNP222323.Models
{
    public class Pelicula
    {
        [Key]
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }
        
    }
}
