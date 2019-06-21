using System;
using Xunit;
using RecipeManager.Models;
using System.Collections.Generic;

namespace RecipeManagerTests
{
    public class InstructionGettersAndSetters
    {
        [Fact]
        public void CanGetRecipeID()
        {
            Instruction instruction = new Instruction()
            {
                RecipeID = 1
            };
            Assert.Equal(1, instruction.RecipeID);
        }
        [Fact]
        public void CanGetStepNumber()
        {
            Instruction instruction = new Instruction()
            {
                StepNumber = 1
            };
            Assert.Equal(1, instruction.StepNumber);
        }
        [Fact]
        public void CanGetDetail()
        {
            Instruction instruction = new Instruction()
            {
                Detail = "A detail"
            };
            Assert.Equal("A detail", instruction.Detail);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            Instruction instruction = new Instruction()
            {
                RecipeID = 1
            };
            instruction.RecipeID = 2;
            Assert.Equal(2, instruction.RecipeID);
        }
        [Fact]
        public void CanSetStepNumber()
        {
            Instruction instruction = new Instruction()
            {
                StepNumber = 1
            };
            instruction.StepNumber = 2;
            Assert.Equal(2, instruction.StepNumber);
        }
        [Fact]
        public void CanSetDetail()
        {
            Instruction instruction = new Instruction()
            {
                Detail = "A detail"
            };
            instruction.Detail = "A new detail";
            Assert.Equal("A new detail", instruction.Detail);
        }
    }
}
