using System;
using Xunit;
using RecipeManager.Models;
using System.Collections.Generic;

namespace RecipeManagerTests
{
    public class SavedRecipeGettersAndSetters
    {
        [Fact]
        public void CanGetRecipeID()
        {
            SavedRecipe savedRecipe = new SavedRecipe()
            {
                RecipeID = 1,
            };
            Assert.Equal(1, savedRecipe.RecipeID);
        }
        [Fact]
        public void CanGetUser()
        {
            SavedRecipe savedRecipe = new SavedRecipe()
            {
                User = "user",
            };
            Assert.Equal("user", savedRecipe.User);
        }
        [Fact]
        public void CanSetRecipeID()
        {
            SavedRecipe savedRecipe = new SavedRecipe()
            {
                RecipeID = 1,
            };
            savedRecipe.RecipeID = 2;
            Assert.Equal(2, savedRecipe.RecipeID);
        }
        [Fact]
        public void CanSetUser()
        {
            SavedRecipe savedRecipe = new SavedRecipe()
            {
                User = "user",
            };
            savedRecipe.User = "new user";
            Assert.Equal("new user", savedRecipe.User);
        }

    }
}
