using indiGo.Business.Repositories.Abstract;
using indiGo.Core.Categories;
using indiGo.Core.Entities;
using indiGo.Data.Entites;
using indiGo.Data.Entities;
using indiGo.Data.Identity;
using indiGo.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace indiGo.Web.Controllers;

public class ServiceDemandController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IRepository<Address,int> _addressRepository;
    private readonly IRepository<ServiceDemand, int> _serviceDemandRepository;

    public ServiceDemandController(IRepository<Address, int> addressRepository, UserManager<ApplicationUser> userManager, IRepository<ServiceDemand, int> serviceDemandRepository)
    {
        _addressRepository = addressRepository;
        _userManager = userManager;
        _serviceDemandRepository = serviceDemandRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> ElectricalServiceDemand()
    {
        _addressRepository.Get().ToList();
        var name = HttpContext.User.Identity.Name;
        var user = await _userManager.FindByNameAsync(name);
        var model = new ServiceDemandPageViewModel();
       
        user.Addresses.ForEach(x =>
        {
            model.Addresses.Add(new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.AddressName

            });
        });

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ElectricalServiceDemand(ServiceDemandPageViewModel model)
    {
        _addressRepository.Get().ToList();
        var name = HttpContext.User.Identity.Name;
        var user = await _userManager.FindByNameAsync(name);
        
        user.Addresses.ForEach(x =>
        {
            model.Addresses.Add(new SelectListItem()
            {
                Value = x.Id.ToString(),
                Text = x.AddressName
            });
        });

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var serviceDemand = new ServiceDemand()
        {
            FirstName = model.ServiceDemand.FirstName,
            LastName = model.ServiceDemand.LastName,
            PhoneNumber = model.ServiceDemand.PhoneNumber,
            Problem = model.ServiceDemand.Problem,
            TCKN = model.ServiceDemand.TCKN,
            AddressId = model.ServiceDemand.AddressId,
            Category = Categories.Electric
        };

        _serviceDemandRepository.Insert(serviceDemand);
        _serviceDemandRepository.Save();

        TempData["status"] = "success";
        return RedirectToAction("Index");
    }
}