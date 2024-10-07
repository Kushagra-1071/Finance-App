using System.ComponentModel.DataAnnotations;

namespace Backend.DTO_s
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        

    }
}
