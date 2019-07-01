using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Services
{
    public class RecipeService : IRecipe
    {
        private readonly RecipeDbContext _context;

        public RecipeService(RecipeDbContext context)
        {
            _context = context;
        }
        public async Task<Recipe> CreateRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }

        public async Task DeleteRecipeById(int id)
        {
            Recipe recipe = await GetRecipeById(id);
            List<SavedRecipe> savedRaw = await _context.SavedRecipes.ToListAsync();
            List<SavedRecipe> saved = savedRaw.FindAll(s => s.RecipeID == id);
            foreach (var savedRecipe in saved)
            {
                _context.SavedRecipes.Remove(savedRecipe);
                await _context.SaveChangesAsync();
            }            
            _context.Recipes.Remove(recipe);
            await _context.SaveChangesAsync();

        }

        public async Task<Recipe> GetRecipeById(int id)
        {
            IEnumerable<Recipe> recipes = await _context.Recipes.ToListAsync();
            Recipe recipe = recipes.FirstOrDefault(r => r.ID == id);
            return recipe;
        }

        public async Task<IEnumerable<Recipe>> GetRecipes()
        {
            IEnumerable<Recipe> Recipes = await _context.Recipes.ToListAsync();
            return Recipes;
        }

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
            await _context.SaveChangesAsync();
            return recipe;
        }
    }
}
