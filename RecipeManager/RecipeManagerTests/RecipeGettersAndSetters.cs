using System;
using Xunit;
using RecipeManager.Models;
using System.Collections.Generic;

namespace RecipeManagerTests
{
    public class RecipeGettersAndSetters
    {
        [Fact]
        public void CanGetID()
        {
            Recipe recipe = new Recipe()
            {
                ID = 1,
            };
            Assert.Equal(1, recipe.ID);
        }
        [Fact]
        public void CanGetTitle()
        {
            Recipe recipe = new Recipe()
            {
                Title = "string"
            };
            Assert.Equal("string", recipe.Title);
        }
        [Fact]
        public void CanGetDescription()
        {
            Recipe recipe = new Recipe()
            {
                Description = "string"
            };
            Assert.Equal("string", recipe.Description);
        }
        [Fact]
        public void CanGetNotes()
        {
            Recipe recipe = new Recipe()
            {
                Notes = "string"
            };
            Assert.Equal("string", recipe.Notes);
        }

        [Fact]
        public void CanGetServingSize()
        {
            Recipe recipe = new Recipe()
            {
                ServingSize = 4
            };
            Assert.Equal(4, recipe.ServingSize);
        }

        [Fact]
        public void CanGetIsSaved()
        {
            Recipe recipe = new Recipe()
            {
                IsSaved = false
            };
            Assert.False(recipe.IsSaved);
        }
        [Fact]
        public void CanGetInstructions()
        {
            List<Instruction> list = new List<Instruction>();
            Instruction instruction = new Instruction()
            {
                StepNumber = 1,
                Detail = "This is a detail",
                RecipeID = 1,
            };
            list.Add(instruction);
            Recipe recipe = new Recipe()
            {
                Instructions = list,
            };
            Assert.Equal(list, recipe.Instructions);
        }
        [Fact]
        public void CanGetIngredients()
        {
            List<Ingredient> list = new List<Ingredient>();
            Ingredient ingredient = new Ingredient()
            {
                ID = 1,
                RecipeID = 1,
                Name = "name",
                Notes = "notes",
                Quantity = "3 cups",
                                
                  
            };
            list.Add(ingredient);
            Recipe recipe = new Recipe()
            {
                Ingredients = list,
            };
            Assert.Equal(list, recipe.Ingredients);
        }
    }
}
