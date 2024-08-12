using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductTestApi.Domain
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public Guid IdProduct { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100")]
        [Required(ErrorMessage = "O nome do Campo é obrigatório")]
        public string? NameProduct { get; set; }

        [Column(TypeName = "DECIMAL")]
        [Required(ErrorMessage = "O nome do Campo é obrigatório")]
        public decimal? PriceProduct { get; set; }
    }
}
