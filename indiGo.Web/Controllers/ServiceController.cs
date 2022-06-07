using indiGo.Business.Repositories.Abstract;
using indiGo.Core.Entities;
using indiGo.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace indiGo.Web.Controllers;

public class ServiceController : Controller
{
    private readonly IRepository<ServiceDemand,int> _serviceDemandRepository;
    private readonly UserManager<ApplicationUser> _userManager;
    public IActionResult Demands()
    {
        return View();
    }
}