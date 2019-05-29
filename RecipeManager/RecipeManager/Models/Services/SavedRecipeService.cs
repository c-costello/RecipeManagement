using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Services
{
    public class SavedRecipeService : ISavedRecipe
    {
        private readonly RecipeDbContext _context;

        public SavedRecipeService(RecipeDbContext context)
        {
            _context = context;
        }

        public async Task<SavedRecipe> CreateSavedRecipes(SavedRecipe savedRecipe)
        {
            _context.SavedRecipes.Add(savedRecipe);
            await _context.SaveChangesAsync();
            return savedRecipe;
        }

        public async Task<SavedRecipe> CreateSavedRecipes(int recipeID, string user)
        {
            SavedRecipe savedRecipe = new SavedRecipe()
            {
                RecipeID = recipeID,
                User = user
            };
            _context.SavedRecipes.Add(savedRecipe);
            await _context.SaveChangesAsync();
            return savedRecipe;

        }

        public async Task DeleteRecipe(int recipeID, string user)
        {
            SavedRecipe savedRecipe = await GetSavedRecipe(recipeID, user);
            _context.SavedRecipes.Remove(savedRecipe);
            await _context.SaveChangesAsync();

        }

        public async Task<SavedRecipe> GetSavedRecipe(int recipeID, string user)
        {
            IEnumerable<SavedRecipe> savedRecipes = await GetSavedRecipes(user);
            return savedRecipes.FirstOrDefault(r => r.RecipeID == recipeID);
        }

        public async Task<IEnumerable<SavedRecipe>> GetSavedRecipes(string user)
        {
            IEnumerable<SavedRecipe> savedRecipeRaw = await _context.SavedRecipes.ToListAsync();
            return savedRecipeRaw.Where(r => r.User == user);

        }
    }
}
