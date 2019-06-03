using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Services
{
    public class IngredientService : IIngredient
    {
        private readonly RecipeDbContext _context;

        public IngredientService(RecipeDbContext context)
        {
            _context = context;
        }
        public async Task<Ingredient> CreateIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;
        }

        public async Task DeleteIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Remove(ingredient);
            await _context.SaveChangesAsync();
        }

        public async Task<Ingredient> GetIngredient(int id)
        {
            Ingredient ingredient = await _context.Ingredients.FindAsync(id);
            return ingredient;
            
        }

        public async Task<List<Ingredient>> GetIngredients(int recipeID)
        {
            List<Ingredient> ingredientsRaw = await _context.Ingredients.ToListAsync();
            List<Ingredient> ingredients =  ingredientsRaw.FindAll(r => r.RecipeID == recipeID);
            return ingredients;
        }

        public async Task<Ingredient> UpdateIngredient(Ingredient ingredient)
        {
            _context.Ingredients.Update(ingredient);
            await _context.SaveChangesAsync();
            return ingredient;
        }
    }
}
