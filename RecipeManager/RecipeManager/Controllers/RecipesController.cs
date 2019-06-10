using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        private readonly ISavedRecipe _SavedRecipe;

        public RecipesController(IIngredient ingredient, IInstruction instruction, IRecipe recipe, ISavedRecipe savedRecipe)
        {
            _Ingredient = ingredient;
            _Instruction = instruction;
            _Recipe = recipe;
            _SavedRecipe = savedRecipe;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Recipe recipe)
        {
            var ingredients = recipe.Ingredients;
            var instructions = recipe.Instructions;
            recipe.Instructions = null;
            recipe.Ingredients = null;
            recipe.Author = User.Identity.Name;
            await _Recipe.CreateRecipe(recipe);
            foreach (var ingredient in ingredients)
            {
                ingredient.RecipeID = recipe.ID;
                await _Ingredient.CreateIngredient(ingredient);
            }
            foreach (var instruction in instructions)
            {
                instruction.RecipeID = recipe.ID;
                await _Instruction.CreateInstruction(instruction);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Recipe recipe = await _Recipe.GetRecipeById(id);
            String user = User.Identity.Name;
            if (user == recipe.Author)
            {
                recipe.Instructions = await _Instruction.GetInstructions(id);
                recipe.Ingredients = await _Ingredient.GetIngredients(id);
                return View(recipe);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Recipe recipe)
        {
            var ingredients = recipe.Ingredients;
            var instructions = recipe.Instructions;
            recipe.Instructions = null;
            recipe.Ingredients = null;
            recipe = await _Recipe.UpdateRecipe(recipe);
            List<Ingredient> deleteIngredients = await _Ingredient.GetIngredients(recipe.ID);
            List<Instruction> deleteInstruction = await _Instruction.GetInstructions(recipe.ID);
            foreach(Ingredient ingredient in deleteIngredients)
            {
                await _Ingredient.DeleteIngredient(ingredient);
            }
            foreach(Instruction instruction in deleteInstruction)
            {
                await _Instruction.DeleteInstruction(instruction);
            }
            foreach(Ingredient ingredient in ingredients)
            {
                ingredient.RecipeID = recipe.ID;
                await _Ingredient.CreateIngredient(ingredient);
            }
            foreach(Instruction instruction in instructions)
            {
                instruction.RecipeID = recipe.ID;
                await _Instruction.CreateInstruction(instruction);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            string user = User.Identity.Name;
            Recipe recipe = await _Recipe.GetRecipeById(id);
            recipe.Instructions = await _Instruction.GetInstructions(id);
            recipe.Ingredients = await _Ingredient.GetIngredients(id);
            var saved = await _SavedRecipe.GetSavedRecipe(id, user);
            if (saved != null)
            {
                recipe.IsSaved = true;
            }
            else
            {
                recipe.IsSaved = false;
            }
            return View(recipe);
        }
    }
}