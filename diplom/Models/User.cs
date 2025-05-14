using Microsoft.AspNetCore.Identity;

namespace diplom.Models
{
    public class User: IdentityUser
    {
        public string FullName { get; set; }
    }
}