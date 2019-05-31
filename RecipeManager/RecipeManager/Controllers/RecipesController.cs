using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models;
using RecipeManager.Models.Interfaces;

namespace RecipeManager.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IIngredient _Ingredient;
        private readonly IInstruction _Instruction;
        private readonly IRecipe _Recipe;

        public RecipesController(IIngredient ingredient, IInstruction instruction, IRecipe recipe)
        {
            _Ingredient = ingredient;
            _Instruction = instruction;
            _Recipe = recipe;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Recipe recipe)
        {
            var Instructions = recipe.Instructions;
            return RedirectToAction("Index", "Home");
        }
    }
}