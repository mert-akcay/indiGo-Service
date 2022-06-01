using indiGo.Core.ViewModels;
using indiGo.Data.Entities;

namespace indiGo.Web.ViewModels;

public class AddressPageViewModel
{
    public AddressViewModel? AddressViewModel { get; set; }
    public EditAddressViewModel? EditAddressViewModel { get; set; }
    public List<Address>? Addresses { get; set; }
}