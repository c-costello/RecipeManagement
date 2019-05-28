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
            modelBuilder.Entity<SavedRecipes>().HasKey(ce => new { ce.RecipeID, ce.User });
        }

        public DbSet<SavedRecipes> SavedRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Instruction> Instructions { get; set; }
        public DbSet<Comment> Comments { get; set; }
    
    }
}
