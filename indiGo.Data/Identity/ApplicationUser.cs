using System.ComponentModel.DataAnnotations;
using indiGo.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace indiGo.Data.Identity;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Address>? Addresses { get; set; }
    public DateTime RegisterDate { get; set; } = DateTime.UtcNow;

}