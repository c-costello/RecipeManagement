using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ServingSize { get; set; }
        public string CookTime { get; set; }
        public string Author { get; set; }
        public IEnumerable<string> ImgUrls { get; set; }
        public string Notes { get; set; }
        public IEnumerable<Instruction> Instructions { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}
