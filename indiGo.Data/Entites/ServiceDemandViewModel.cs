using System.ComponentModel.DataAnnotations;
using indiGo.Core.ViewModels;

namespace indiGo.Data.Entites;

public class ServiceDemandViewModel
{
    [Display(Name = "Ad")]
    [Required]
    public string FirstName { get; set; }

    [Display(Name = "Soyad")]
    [Required]
    public string LastName { get; set; }

    [Display(Name = "TC Kimlik No")]
    [Required]
    [StringLength(11, MinimumLength = 11,ErrorMessage = "Lütfen geçerli bir TC Kimlik No giriniz.")]
    public string TCKN { get; set; }

    [Display(Name = "Adres")]
    [Required(ErrorMessage = "Lütfen geçerli bir adres seçiniz.")]
    public int AddressId { get; set; }

    [Display(Name = "Telefon Numarası")]
    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    [Display(Name = "Probleminiz nedir?")]
    [Required]
    public string Problem { get; set; }

}