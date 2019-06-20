using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IIngredient
    {
        /// <summary>
        /// Get's ingredients belonging to a recipe by recipe ID.
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <returns>List of Ingredients</returns>
        Task<List<Ingredient>> GetIngredients(int recipeID);
        /// <summary>
        /// Async. Get's ingredient by ingredient id.
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>Ingredient</returns>
        Task<Ingredient> GetIngredient(int id);
        /// <summary>
        /// Async. Adds an ingredient to the Ingredient table
        /// </summary>
        /// <param name="ingredient">Ingredient</param>
        /// <returns>Ingredient</returns>
        Task<Ingredient> CreateIngredient(Ingredient ingredient);
        /// <summary>
        /// Async. Delete's Ingredient from ingredient table.
        /// </summary>
        /// <param name="ingredient">Ingredient</param>
        Task DeleteIngredient(Ingredient ingredient);
        /// <summary>
        /// Async. Updates an Ingredient
        /// </summary>
        /// <param name="ingredient">Ingredient</param>
        /// <returns>Ingredient.</returns>
        Task<Ingredient> UpdateIngredient(Ingredient ingredient);
    }
}
