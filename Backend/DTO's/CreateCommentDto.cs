
using System.ComponentModel.DataAnnotations;

namespace Backend.DTO_s
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5,ErrorMessage="Title must be 5 characters")]
        [MaxLength(280,ErrorMessage ="Title cannot be over 280 characters")]
        public string Title { get; set; } = "";
        [Required]
        public string Content { get; set; } = "";
    }
}
