using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models;
using RecipeManager.Models.Interfaces;

namespace RecipeManager.Controllers
{
    public class SavedRecipesController : Controller
    {
        private readonly ISavedRecipe _Context;
        private readonly UserManager<ApplicationUser> _UserManager;

        public SavedRecipesController(ISavedRecipe savedRecipe, UserManager<ApplicationUser> userManager)
        {
            _Context = savedRecipe;
            _UserManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}