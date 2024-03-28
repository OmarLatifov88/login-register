using Microsoft.AspNetCore.Identity;

namespace UserLoginRegister.Models;

public class appUser : IdentityUser
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string FullName { get; set; }

    public String Password { get; set; }
}
