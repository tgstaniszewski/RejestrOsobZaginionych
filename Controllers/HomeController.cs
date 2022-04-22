using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RejestrOsobZaginionych.Areas.Identity.Data;
using RejestrOsobZaginionych.Data;
using RejestrOsobZaginionych.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RejestrOsobZaginionych.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RejestrOsobZaginionychContext _context;
        private readonly UserManager<RejestrOsobZaginionychUser> _userManager;
        private SignInManager<RejestrOsobZaginionychUser> _signInManager;


        public HomeController(ILogger<HomeController> logger, RejestrOsobZaginionychContext context, UserManager<RejestrOsobZaginionychUser> userManager, SignInManager<RejestrOsobZaginionychUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User)) 
            {
                var tt = User.IsInRole("Admin");
              //  _signInManager.UserManager.AddToRoleAsync(User.,"Admin");
            }

                //var roleStore = new RoleStore<IdentityRole>(_context);
                //var roleMngr = new RoleManager<IdentityRole>(roleStore);

                //var roles = roleMngr.Roles.ToList();
                //var user = _userManager.FindByEmailAsync("Garwat@gmail.com");
                //_userManager.AddToRoleAsync(user.Result, "Admin");
                //var user2 = _userManager.FindByEmailAsync("Garwat@gmail.com");
                var list = _context.Zaginieni.ToList();
            //_context.SaveChanges();
            return View(list);
        }

        //public IActionResult Index(string orderBy, string OrderField)
        //{

        //    var list = _context.Zaginieni.OrderBy<NameSort> ToList();

        //    return View(list);
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
