using Microsoft.EntityFrameworkCore;
using RecipeManager.Data;
using RecipeManager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models.Services
{
    public class InstructionService : IInstruction
    {
        private readonly RecipeDbContext _context;

        public InstructionService(RecipeDbContext context)
        {
            _context = context;
        }
        public async Task<Instruction> CreateInstruction(Instruction instruction)
        {
            _context.Instructions.Add(instruction);
            await _context.SaveChangesAsync();
            return instruction;
        }

        public async Task DeleteInstructionByID(int recipeID, int stepNumber)
        {
            Instruction instruction = await GetInstruction(recipeID, stepNumber);
            _context.Instructions.Remove(instruction);
            await _context.SaveChangesAsync();
        }

        public async Task<Instruction> GetInstruction(int recipeID, int stepNumber)
        {
            List<Instruction> instructionsRaw = await _context.Instructions.ToListAsync();
            return instructionsRaw.FirstOrDefault(i => i.RecipeID == recipeID && i.StepNumber == stepNumber);
        }

        public async Task<List<Instruction>> GetInstructions(int recipeID)
        {
            List<Instruction> instructionsRaw = await _context.Instructions.ToListAsync();
            return instructionsRaw.FindAll(i => i.RecipeID == recipeID);
        }

        public async Task<Instruction> UpdateInstruction(Instruction instruction)
        {
            _context.Instructions.Update(instruction);
            await _context.SaveChangesAsync();
            return instruction;
        }
    }
}
