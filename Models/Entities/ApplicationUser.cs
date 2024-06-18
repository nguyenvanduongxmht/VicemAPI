using Microsoft.AspNetCore.Identity;

namespace VicemAPI.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string FullName { get; set; }
    }
}