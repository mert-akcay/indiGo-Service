using indiGo.Data.Entites;
using indiGo.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace indiGo.Web.ViewModels;

public class ServiceDemandPageViewModel
{
    public ServiceDemandViewModel? ServiceDemand { get; set; }
    public List<SelectListItem>? Addresses { get; set; } = new List<SelectListItem>();
}
