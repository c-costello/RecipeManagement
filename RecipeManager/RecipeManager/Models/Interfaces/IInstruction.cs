using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    public interface IInstruction
    {
        Task<List<Instruction>> GetInstructions(int recipeID);
        Task<Instruction> GetInstruction(int recipeID, int stepNumber);
        Task<Instruction> CreateInstruction(Instruction instruction);
        Task<Instruction> UpdateInstruction(Instruction instruction);
        Task DeleteInstruction(Instruction instruction);
    }
}
