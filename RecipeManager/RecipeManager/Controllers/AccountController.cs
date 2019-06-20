using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models;
using RecipeManager.Models.ViewModels;

namespace RecipeManager.Controllers.Account
{
    public class AccountController : Controller
    {
        //Properties - importing UserManager and SignInManager from Identity
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly SignInManager<ApplicationUser> _SignInManager;

        /// <summary>
        /// Account controller, bringing in UserManager and SignInManager from Identity
        /// </summary>
        /// <param name="userManager">UserManager</param>
        /// <param name="signInManager">SignInManager</param>
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        /// <summary>
        /// Get's login view
        /// </summary>
        /// <returns>Login View</returns>
        [HttpGet]
        public IActionResult Login() => View();

        /// <summary>
        /// Post's login in data, checks data from the LoginViewModel (username and password), and attempts a sign in. If success, redirects to homepage, if not, returns login view. 
        /// </summary>
        /// <param name="lvm">Login View Model</param>
        /// <returns>View</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _SignInManager.PasswordSignInAsync(lvm.Username, lvm.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        /// <summary>
        /// Get's Register View
        /// </summary>
        /// <returns>Register View</returns>
        [HttpGet]
        public IActionResult Register() => View();

        /// <summary>
        /// Takes in Register View Model from form and creates a new user. That user is then signed in.
        /// </summary>
        /// <param name="rvm">Register View Model</param>
        /// <returns>View</returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new ApplicationUser()
                {
                    Email = rvm.Email,
                    UserName = rvm.Username,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName
                };
                var result = await _UserManager.CreateAsync(applicationUser, rvm.Password);
                if (result.Succeeded)
                {
                    await _SignInManager.PasswordSignInAsync(rvm.Username, rvm.Password, false, false);
                    return RedirectToAction("Index", "Home");

                }
                return View();
            }
            return View();
        }
    }
}