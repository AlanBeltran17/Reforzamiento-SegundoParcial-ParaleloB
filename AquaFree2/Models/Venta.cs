using System.ComponentModel.DataAnnotations;

namespace AquaFree2.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(10)]
        public DateTime Fecha { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public decimal Total { get; set; }
    }
}
