using Microsoft.AspNetCore.Identity;

namespace indiGo.Data.Identity;

public class ApplicationRole : IdentityRole
{
    public string? Description { get; set; }

}