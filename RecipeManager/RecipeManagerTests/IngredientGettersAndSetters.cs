using System;
using Xunit;
using RecipeManager.Models;
using System.Collections.Generic;

namespace RecipeManagerTests
{
    public class IngredientGettersAndSetters
    {
        [Fact]
        public void CanGetID()
        {
            Ingredient ingredient = new Ingredient()
            {
                ID = 1,
            };
            Assert.Equal(1, ingredient.ID);
        }
        [Fact]
        public void CanGetRecipeID()
        {
            Ingredient ingredient = new Ingredient()
            {
                RecipeID = 1,
            };
            Assert.Equal(1, ingredient.RecipeID);
        }
        [Fact]
        public void CanGetName()
        {
            Ingredient ingredient = new Ingredient()
            {
                Name = "name",
            };
            Assert.Equal("name", ingredient.Name);

        }
        [Fact]
        public void CanGetNotes()
        {
            Ingredient ingredient = new Ingredient()
            {
                Notes = "notes"
            };
            Assert.Equal("notes", ingredient.Notes);
        }
        [Fact]
        public void CanGetQuantity()
        {
            Ingredient ingredient = new Ingredient()
            {
                Quantity = "3 cups",
            };
            Assert.Equal("3 cups", ingredient.Quantity);
        }
        [Fact]
        public void CanSetID()
        {
            Ingredient ingredient = new Ingredient()
            {
                ID = 1,
            };
            ingredient.ID = 2;
            Assert.Equal(2, ingredient.ID);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            Ingredient ingredient = new Ingredient()
            {
                RecipeID = 1,
            };
            ingredient.RecipeID = 2;
            Assert.Equal(2, ingredient.RecipeID);
        }
        [Fact]
        public void CanSetName()
        {
            Ingredient ingredient = new Ingredient()
            {
                Name = "name",
            };
            ingredient.Name = "new name";
            Assert.Equal("new name", ingredient.Name);

        }
        [Fact]
        public void CanSetNotes()
        {
            Ingredient ingredient = new Ingredient()
            {
                Notes = "notes"
            };
            ingredient.Notes = "new notes";
            Assert.Equal("new notes", ingredient.Notes);
        }
        [Fact]
        public void CanSetQuantity()
        {
            Ingredient ingredient = new Ingredient()
            {
                Quantity = "3 cups",
            };
            ingredient.Quantity = "4 cups";
            Assert.Equal("4 cups", ingredient.Quantity);
        }
    }
}
