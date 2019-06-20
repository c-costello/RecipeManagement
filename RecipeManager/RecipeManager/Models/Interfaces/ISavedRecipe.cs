using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface ISavedRecipe
    {
        /// <summary>
        /// Async. Create's a saved recipe based on the user and recipeID.
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <param name="user">string</param>
        /// <returns>SavedRecipe</returns>
        Task<SavedRecipe> CreateSavedRecipes(int recipeID, string user);
        /// <summary>
        /// Async. Get's all recipes a user has saved. 
        /// </summary>
        /// <param name="user">string</param>
        /// <returns>List of SavedRecipes</returns>
        Task<IEnumerable<SavedRecipe>> GetSavedRecipes(string user);
        /// <summary>
        /// Async. Get's a saved recipe based on user and recipe ID.
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <param name="user">string</param>
        /// <returns>IEnumerable of SavedRecipe</returns>
        Task<SavedRecipe> GetSavedRecipe(int recipeID, string user);
        /// <summary>
        /// Async. Delete's a saved recipe based on recipe and user.
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <param name="user">string</param>
        Task DeleteRecipe(int recipeID, string user);
    }
}
