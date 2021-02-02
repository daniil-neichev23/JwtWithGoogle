using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controllers
{
    public class HomeController :Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(
            UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        } 
        
        public IActionResult Login(string email, string password)
        {
            // login functionality
            return RedirectToAction("Index");
        }

        public IActionResult Register()
        {
            return View();
        }
        
        public async Task<IActionResult> Register(string email,string password)
        {

            //register functionality
            var user = new IdentityUser
            {
                Email = $"{email}",

            };

            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                //sign user here    
            }

            return RedirectToAction("Index");
        }
    }
}
