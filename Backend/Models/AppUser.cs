using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
namespace Backend.Models
{
    public class AppUser : IdentityUser
    {
        public List<Portfolio> Portfolios { get; set; }=new List<Portfolio>();

    }
}
