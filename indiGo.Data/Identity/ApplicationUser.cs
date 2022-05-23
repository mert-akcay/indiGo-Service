using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace indiGo.Data.Identity;

public class ApplicationUser : IdentityUser
{
    [Required]
    [Display(Name = "Ad")]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Soyad")]
    [MaxLength(50)]
    public string LastName { get; set; }
    public DateTime RegisterDate { get; set; } = DateTime.UtcNow;

}