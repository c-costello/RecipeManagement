using Microsoft.EntityFrameworkCore;
using RecipeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instruction>().HasKey(ce => new { ce.RecipeID, ce.StepNumber });
            modelBuilder.Entity<SavedRecipe>().HasKey(ce => new { ce.RecipeID, ce.User });
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    ID = 1,
                    Title = "Welcome Wafers",
                    Author = "Clarice",
                    Description = "Tasty, tangy crackers",
                    Notes = "Good for parties",
                    ServingSize = 20,

                },
                new Recipe
                {
                    ID = 2,
                    Title = "Rice Balls",
                    Author = "Clarice",
                    Description = "Rice balls with a variety of toppings",
                    ServingSize = 8,

                },
                new Recipe
                {
                    ID = 3,
                    Title = "Ice Cream Sunday",
                    Author = "Clarice",
                    Description = "It's a Ice Cream Sunday, it doesn't need a description",
                    ServingSize = 2,

                },
                new Recipe
                {
                    ID = 4,
                    Title = "Chicken Gumbo",
                    Author = "Clarice",
                    Description = "Traditional Rice and Broth dish from Louisiana",
                    Notes = "Grandma's recipe",
                    ServingSize = 8,

                },
                new Recipe
                {
                    ID = 5,
                    Title = "Thyme Roasted Chicken",
                    Author = "Clarice",
                    Description = "Perfectly cooked chicken with a crispy skin",
                    Notes = "Be wary of cook time. It can depend on the oven, or the size of the chicken.",
                    ServingSize = 4,

                },
                new Recipe
                {
                    ID = 6,
                    Title = "Chicken and Biscuits",
                    Author = "Clarice",
                    Description = "An alternative to chicken pot pie",
                    Notes = "Frozen veggies make things a lot easier.",
                    ServingSize = 8,

                });
        }


        public DbSet<SavedRecipe> SavedRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    
    }
}
