using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IIngredient
    {
        Task<List<Ingredient>> GetIngredients(int recipeID);
        Task<Ingredient> GetIngredient(int id);
        Task<Ingredient> CreateIngredient(Ingredient ingredient);
        Task DeleteIngredient(Ingredient ingredient);
        Task<Ingredient> UpdateIngredient(Ingredient ingredient);
    }
}
