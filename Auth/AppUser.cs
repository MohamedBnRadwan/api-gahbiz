using Microsoft.AspNetCore.Identity;

namespace GahbizWepApi.Auth
{
    public class AppUser: IdentityUser
    {
        public UserType Type { get; set; }
    }
}
