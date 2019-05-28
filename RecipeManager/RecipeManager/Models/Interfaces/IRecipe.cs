using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IRecipe
    {
        Task<IEnumerable<Recipe>> GetRecipes();
        Task<Recipe> GetRecipeById();
        Task CreateRecipe();
        Task DeleteRecipeById(int id);
        Task UpdateRecipe(Recipe recipe);

    }
}
