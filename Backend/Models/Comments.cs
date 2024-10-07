using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
    [Table("Comments")]
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; }="";
        public string Content { get; set; } = "";
        public DateTime CreatedOn  { get; set; }=DateTime.Now;
        public int? StockId { get; set; }
        public Stock?  Stock { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
