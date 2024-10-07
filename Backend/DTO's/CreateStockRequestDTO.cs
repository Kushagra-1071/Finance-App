using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.DTO_s
{
    public class CreateStockRequestDTO
    {
        [Required]
        [MaxLength(10,ErrorMessage ="Symbol cannot be over 10 characters")]
        public string Symbol { get; set; } = "";
        [Required]
        [MaxLength(50, ErrorMessage = "Company cannot be over 50 characters")]
        public string CompanyName { get; set; } = "";

        [Required]
        [Range(1,100000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001,100)]
        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = "";

        public long MarketCap { get; set; }
    }
}
