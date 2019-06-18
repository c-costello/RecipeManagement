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
                    ID = 23,
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
                },
                new Ingredient
                {
                    ID = 22,
                    RecipeID = 1,
                    Name = "Vegitable Oil",
                    Quantity = "1/2 cup",
                }
                );
            modelBuilder.Entity<Instruction>().HasData(
                new Instruction
                {
                    StepNumber = 1,
                    RecipeID = 1,
                    Detail = "Preheat oven to 325 degrees",
                },
                new Instruction
                {
                    StepNumber = 2,
                    RecipeID = 1,
                    Detail = "Mix together Ranch, Lemon Pepper, Tony Chachere's, and Dill",
                },
                new Instruction
                {
                    StepNumber = 3,
                    RecipeID = 1,
                    Detail = "Pour crackers into 9 X 13 pan. Mix crackers and oil",
                },
                new Instruction
                {
                    StepNumber = 4,
                    RecipeID = 1,
                    Detail = "Add seasoning to oiled crackers. Mix well",
                },
                new Instruction
                {
                    StepNumber = 5,
                    RecipeID = 1,
                    Detail = "Bake for 15 minutes, stirring frequently. Let cool before eating",
                },
                new Instruction
                {
                    StepNumber = 1,
                    RecipeID = 2,
                    Detail = "Cook rice according to manufacturer instructions, or in a rice cooker. While rice is cooking, bake salted salmon at 350 degrees for 15 minutes or until done.",
                },
                new Instruction
                {
                    StepNumber = 2,
                    RecipeID = 2,
                    Detail = "When rice is done cooking, remove from pot and transfer onto a baking sheet. Fan with a peice of cardboard until rice is cool enough to touch. (But don't let it get cold.) While rice and fish are cooling, prepare a small bowl of salt and a bowl of water.",
                },
                new Instruction
                {
                    StepNumber = 3,
                    RecipeID = 2,
                    Detail = "Dip hands in water, then coat in salt. Pick up a handful of rice slightly larger than a golf ball. (Note: Size isn't super important. If you want a larger rice ball, add more rice). Gently press rice flat into your hand, making a slight indent in the center of the rice. Add your filling (salmon or umeboshi). Add a golf ball sized peice of rice on top of filling and pack into a triangle shape",
                },
                new Instruction
                {
                    StepNumber = 4,
                    RecipeID = 2,
                    Detail = "When ready to eat, wrap rice ball in seaweed and enjoy.",
                },
                new Instruction
                {
                    StepNumber = 1,
                    RecipeID = 3,
                    Detail = "Scoop IceCream into two bowls, three scoops each.",
                },
                new Instruction
                {
                    StepNumber = 2,
                    RecipeID = 3,
                    Detail = "Pour chocolate sauce over ice cream. Sprinkle on the sprinkles.",
                },
                new Instruction
                {
                    StepNumber = 3,
                    RecipeID = 3,
                    Detail = "Add a cherry on top and enjoy!",
                },
                new Instruction
                {
                    StepNumber = 1,
                    RecipeID = 4,
                    Detail = "In a large, thick bottomed pot, add butter and flour. Stir constantly over medium heat until flour becomes a dark golden brown. Add chopped onions. Cook until onions are tender.",
                },
                new Instruction
                {
                    StepNumber = 2,
                    RecipeID = 4,
                    Detail = "Once onions are cooked, add in 1/2 cup of chicken stock. Stir until there are no lumps. Gradually add the rest of the chicken stock. Bring to a boil and allow to cook until all flavors have mingled (20 minutes)",
                },
                new Instruction
                {
                    StepNumber = 3,
                    RecipeID = 4,
                    Detail = "Add chicken, and salt to taste. Serve over rice with Gumbo File",
                },
                new Instruction
                {
                    StepNumber = 1,
                    RecipeID = 5,
                    Detail = "Prehead oven to 350. In a small pan, add butter and thyme leaves. Remove from heat once butter is completely melted, and allow to cool slightly",
                },
                new Instruction
                {
                    StepNumber = 2,
                    RecipeID = 5,
                    Detail = "Once butter is cool enough to touch, carefully coat chicken in the thyme butter. If possible, get the butter under the skin as well. Reserve leftover butter.",
                },
                new Instruction
                {
                    StepNumber = 3,
                    RecipeID = 5,
                    Detail = "Pour wine into a 2 and a half to three inch wide glass jar. Place the glass jar in a deep lipped baking sheet or pirex baking dish. Carefully slide the chicken onto the glass jar."
                },
                new Instruction
                {
                    StepNumber = 4,
                    RecipeID = 5,
                    Detail = "Bake chicken for 30 minutes for each pound. Add more butter to chicken halfway through baking. Allow to rest before cutting."
                });

        }


        public DbSet<SavedRecipe> SavedRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    
    }
}
