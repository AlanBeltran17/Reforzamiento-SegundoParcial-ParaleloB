using System.ComponentModel.DataAnnotations;

namespace AquaFree2.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(20)]
        public string? Marca { get; set; }
        [Required, MinLength(4), MaxLength(60)]
        public string? Nombre { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required, MinLength(3), MaxLength(20)]
        public string? Sabor { get; set; }
        [Required]
        public decimal Tamaño { get; set; }
    }
}
