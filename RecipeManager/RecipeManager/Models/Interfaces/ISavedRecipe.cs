using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface ISavedRecipe
    {
        Task<SavedRecipe> CreateSavedRecipes(int recipeID, string user);
        Task<IEnumerable<SavedRecipe>> GetSavedRecipes(string user);
        Task<SavedRecipe> GetSavedRecipe(int recipeID, string user);
        Task DeleteRecipe(int recipeID, string user);
    }
}
