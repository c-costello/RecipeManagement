using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class SavedRecipes
    {
        public string User { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
