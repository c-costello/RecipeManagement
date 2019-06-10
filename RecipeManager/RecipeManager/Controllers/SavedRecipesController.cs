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
        private readonly IRecipe _RecipeContext;

        public SavedRecipesController(ISavedRecipe savedRecipe, UserManager<ApplicationUser> userManager, IRecipe recipe, IInstruction instruction, IIngredient ingredient)
        {
            _Context = savedRecipe;
            _UserManager = userManager;
            _RecipeContext = recipe;
        }
        [HttpGet]
        public async Task<IActionResult> ViewAll()
        {
            List<Recipe> recipes = new List<Recipe>();
            string user = User.Identity.Name;
            IEnumerable<SavedRecipe> savedRecipes = await _Context.GetSavedRecipes(user);
            foreach (SavedRecipe saved in savedRecipes)
            {
                Recipe recipe = await _RecipeContext.GetRecipeById(saved.RecipeID);
                recipes.Add(recipe);
            }
            return View(recipes);
        }

        [HttpGet]
        public async Task<IActionResult> Save(int id)
        {
            string user = User.Identity.Name;
            await _Context.CreateSavedRecipes(id, user);
            return RedirectToAction("ViewAll");
        }
    }
}