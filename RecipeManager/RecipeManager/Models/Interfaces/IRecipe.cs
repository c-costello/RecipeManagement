using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IRecipe
    {
        Task<IEnumerable<Recipe>> GetRecipes();
        Task<Recipe> GetRecipeById(int id);
        Task<Recipe> CreateRecipe(Recipe recipe);
        Task DeleteRecipeById(int id);
        Task<Recipe> UpdateRecipe(Recipe recipe);

    }
}
