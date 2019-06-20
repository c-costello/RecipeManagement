using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IRecipe
    {
        /// <summary>
        /// Async. Get all recipes
        /// </summary>
        /// <returns>IEnumerable of Recipes</returns>
        Task<IEnumerable<Recipe>> GetRecipes();
        /// <summary>
        /// Async. Get's a recipe by ID.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Recipe</returns>
        Task<Recipe> GetRecipeById(int id);
        /// <summary>
        /// Async. Adds a recipe to the Recipe table.
        /// </summary>
        /// <param name="recipe">Recipe</param>
        /// <returns>Recipe</returns>
        Task<Recipe> CreateRecipe(Recipe recipe);
        /// <summary>
        /// Async. Delete's a recipe by it's id.
        /// </summary>
        /// <param name="id">int</param>
        Task DeleteRecipeById(int id);
        /// <summary>
        /// Async. Updates a recipe in the recipe table.
        /// </summary>
        /// <param name="recipe">Recipe</param>
        /// <returns>Recipe</returns>
        Task<Recipe> UpdateRecipe(Recipe recipe);

    }
}
