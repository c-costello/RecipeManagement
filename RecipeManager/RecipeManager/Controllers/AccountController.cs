﻿using System;
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
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly SignInManager<ApplicationUser> _SignInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login() => View();

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

        [HttpGet]
        public IActionResult Register() => View();

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
                    return RedirectToAction("Home", "Index");

                }
                return View();
            }
            return View();
        }
    }
}