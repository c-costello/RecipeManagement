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

                });
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    ID = 1,
                    Name = "Oyster Crackers",
                    RecipeID = 1,
                    Quantity = "Two bags or 2 lbs",
                },
                new Ingredient
                {
                    ID = 2,
                    Name = "Tony Chachere's",
                    Notes = "A louisianan seasoning",
                    RecipeID = 1,
                    Quantity = "1 tbsp",
                },
                new Ingredient
                {
                    ID = 3,
                    Name = "Lemon Pepper",
                    RecipeID = 1,
                    Quantity = "1 tsp",
                },
                new Ingredient
                {
                    ID = 4,
                    Name = "Dill",
                    Notes = "dried works best",
                    RecipeID = 1,
                    Quantity = "3 tbsp",
                },
                new Ingredient
                {
                    ID = 5,
                    Name = "Ranch Dressing Packet",
                    Notes = "I like hidden valley",
                    RecipeID = 1,
                    Quantity = "1",
                },
                new Ingredient
                {
                    ID = 6,
                    Name = "Uncooked Sushi Rice",
                    RecipeID = 2,
                    Quantity = "2 cups",
                },
                new Ingredient
                {
                    ID = 7,
                    Name = "Salted Salmon",
                    RecipeID = 2,
                    Quantity = "4 oz",
                },
                new Ingredient
                {
                    ID = 8,
                    Name = "Pickled Plums / Umeboshi",
                    RecipeID = 2,
                    Quantity = "2 - 3 depending on how much you like pickled plum"
                },
                new Ingredient
                {
                    ID = 9,
                    Name = "Seaweed",
                    RecipeID = 2,
                    Quantity = "4 sheets, cut in half",
                },
                new Ingredient
                {
                    ID = 10,
                    Name = "Your favorite Ice Cream",
                    RecipeID = 3,
                    Quantity = "1 pint or 6 scoops",
                },
                new Ingredient
                {
                    ID = 11,
                    Name = "Chocolate Fudge Sauce",
                    Notes = "Heated slightly",
                    RecipeID = 3,
                    Quantity = "1/2 cup",
                },
                new Ingredient
                {
                    ID = 12,
                    Name = "Sprinkles",
                    RecipeID = 3,
                    Quantity = "To Taste",
                },
                new Ingredient
                {
                    ID = 13,
                    Name = "Marichino Cherry",
                    RecipeID = 3,
                    Quantity = "2",
                },
                new Ingredient
                {
                    ID = 14,
                    Name = "Whole, roasted, broken down chicken",
                    RecipeID = 4,
                    Quantity = "One",
                },
                new Ingredient
                {
                    ID = 15,
                    Name = "Flour",
                    RecipeID = 4,
                    Quantity = "1/2 cup",
                },
                new Ingredient
                {
                    ID = 16,
                    Name = "Oil or Butter, or other fat",
                    Notes = "I prefer butter",
                    RecipeID = 4,
                    Quantity = "1/2 cup",
                },
                new Ingredient
                {
                    ID = 17,
                    Name = "Onion",
                    RecipeID = 4,
                    Quantity = "1 large",
                },
                new Ingredient
                {
                    ID = 18,
                    Name = "Chicken stock",
                    Notes = "Home made is better",
                    RecipeID = 4,
                    Quantity = "6 qts",
                },
                new Ingredient
                {
                    ID = 19,
                    Name = "Butter",
                    RecipeID = 5,
                    Quantity = "1/2 cup",
                },
                new Ingredient
                {
                    ID = 20,
                    Name = "Fresh Thyme",
                    RecipeID = 5,
                    Quantity = "4-6 sprigs",
                },
                new Ingredient
                {
                    ID = 20,
                    Name = "Whole, raw chicken",
                    RecipeID = 5,
                    Quantity = "One",
                },
                new Ingredient
                {
                    ID = 21,
                    Name = "White Wine",
                    Notes = "Optional",
                    RecipeID = 5,
                    Quantity = "1 cup",
                }
                );

        }


        public DbSet<SavedRecipe> SavedRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    
    }
}
