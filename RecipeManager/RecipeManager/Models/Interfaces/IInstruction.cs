﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Interfaces
{
    interface IInstruction
    {
        Task<IEnumerable<Instruction>> GetInstructions(int recipeID);
        Task<Instruction> GetInstruction(int recipeID, int stepNumber);
        Task<Instruction> CreateInstruction(Instruction instruction);
        Task<Instruction> UpdateInstruction(Instruction instruction);
        Task DeleteInstructionByID(int recipeID, int stepNumber);
    }
}