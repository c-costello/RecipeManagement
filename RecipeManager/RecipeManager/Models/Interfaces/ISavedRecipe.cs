using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    interface ISavedRecipe
    {
        Task<SavedRecipes> CreateSavedRecipes(int recipeID, string user);
        Task DeleteRecipe(int recipeID, string user);
    }
}
