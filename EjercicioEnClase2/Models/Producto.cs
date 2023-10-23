using System.ComponentModel.DataAnnotations;

namespace EjercicioEnClase2.Models
{

    //olapapus

    //ola Rama

    //ola rama 2
    //shakira god
    public class Producto
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public float Precio { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
