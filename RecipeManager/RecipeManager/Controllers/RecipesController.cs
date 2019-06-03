﻿using System;
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
            var ingredients = recipe.Ingredients;
            var instructions = recipe.Instructions;
            recipe.Instructions = null;
            recipe.Ingredients = null;
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
    }
}