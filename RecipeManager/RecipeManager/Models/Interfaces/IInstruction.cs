using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IInstruction
    {
        /// <summary>
        /// Async. Get all instructions related to a recipe
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <returns>List of Instructions</returns>
        Task<List<Instruction>> GetInstructions(int recipeID);
        /// <summary>
        /// Get Instruction by RecipeID and Step Number
        /// </summary>
        /// <param name="recipeID">int</param>
        /// <param name="stepNumber">int</param>
        /// <returns>Instruction</returns>
        Task<Instruction> GetInstruction(int recipeID, int stepNumber);
        /// <summary>
        /// Async. Add an instruction to the Instructions table
        /// </summary>
        /// <param name="instruction">Instruction</param>
        /// <returns>Instruction</returns>
        Task<Instruction> CreateInstruction(Instruction instruction);
        /// <summary>
        /// Async. Update an instruction in the Instruction table.
        /// </summary>
        /// <param name="instruction">Instruction</param>
        /// <returns>Instruction</returns>
        Task<Instruction> UpdateInstruction(Instruction instruction);
        /// <summary>
        /// Deletes an instruction from the Instruction table.
        /// </summary>
        /// <param name="instruction">Instruction</param>
        Task DeleteInstruction(Instruction instruction);
    }
}
