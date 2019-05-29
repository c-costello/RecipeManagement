using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models;
using RecipeManager.Models.Interfaces;

namespace RecipeManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipe _Recipe;
        private readonly IInstruction _Instruction;
        private readonly IIngredient _Ingredient;
        private readonly IComment _Comment;
        private readonly ISavedRecipe _SavedRecipe;

        public HomeController(IRecipe recipe, IInstruction instructions, IIngredient ingredient, IComment comment, ISavedRecipe savedRecipe)
        {
            _Recipe = recipe;
            _Instruction = instructions;
            _Ingredient = ingredient;
            _Comment = comment;
            _SavedRecipe = savedRecipe;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<Recipe> recipes = await _Recipe.GetRecipes();
            foreach (Recipe recipe in recipes)
            {
                recipe.Ingredients = await _Ingredient.GetIngredients(recipe.ID);
                recipe.Instructions = await _Instruction.GetInstructions(recipe.ID);
            }
            return View(recipes);
        }
    }
}