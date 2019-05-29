using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Models.Interfaces;

namespace RecipeManager.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipe _Recipe;
        private readonly IInstruction _Instruction;
        private readonly IIngredient _Ingredient;
        private readonly IComment _Comment;
        private readonly ISavedRecipe _SavedRecipe;

        public RecipeController(IRecipe recipe, IInstruction instructions, IIngredient ingredient, IComment comment, ISavedRecipe savedRecipe)
        {
            _Recipe = recipe;
            _Instruction = instructions;
            _Ingredient = ingredient;
            _Comment = comment;
            _SavedRecipe = savedRecipe;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}