using System.Text;
using System.Text.Encodings.Web;
using indiGo.Core.Emails;
using indiGo.Core.Extensions;
using indiGo.Core.Identity;
using indiGo.Core.Services;
using indiGo.Core.ViewModels;
using indiGo.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

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

    }
}
