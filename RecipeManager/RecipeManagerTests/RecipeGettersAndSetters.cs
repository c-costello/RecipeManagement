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

        [Fact]
        public void CanSetID()
        {
            Recipe recipe = new Recipe()
            {
                ID = 1,
            };
            recipe.ID = 2;
            Assert.Equal(2, recipe.ID);
        }
        [Fact]
        public void CanSetTitle()
        {
            Recipe recipe = new Recipe()
            {
                Title = "string"
            };
            recipe.Title = "A different string";
            Assert.Equal("A different string", recipe.Title);

        }
        [Fact]
        public void CanSetDescription()
        {
            Recipe recipe = new Recipe()
            {
                Description = "string"
            };
            recipe.Description = "A different string";
            Assert.Equal("A different string", recipe.Description);
        }
        [Fact]
        public void CanSetNotes()
        {
            Recipe recipe = new Recipe()
            {
                Notes = "string"
            };
            recipe.Notes = "A different string";
            Assert.Equal("A different string", recipe.Notes);
        }

        [Fact]
        public void CanSetServingSize()
        {
            Recipe recipe = new Recipe()
            {
                ServingSize = 4
            };
            recipe.ServingSize = 3;
            Assert.Equal(3, recipe.ServingSize);
        }

        [Fact]
        public void CanSetIsSaved()
        {
            Recipe recipe = new Recipe()
            {
                IsSaved = false
            };
            recipe.IsSaved = true;
            Assert.True(recipe.IsSaved);
        }
        [Fact]
        public void CansetInstructions()
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
                Instructions = null
            };
            recipe.Instructions = list;
            Assert.Equal(list, recipe.Instructions);
        }
        [Fact]
        public void CanSetIngredients()
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
                Ingredients = null
            };
            recipe.Ingredients = list;
            Assert.Equal(list, recipe.Ingredients);
        }
    }
}
