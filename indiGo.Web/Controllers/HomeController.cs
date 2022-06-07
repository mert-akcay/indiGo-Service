using indiGo.Core.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace indiGo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public HomeController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async void addRoles()
        {
            foreach (var role in Roles.RoleList)
            {
                await _roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ServiceDemand()
        {
            return View();
        }
    }
}
