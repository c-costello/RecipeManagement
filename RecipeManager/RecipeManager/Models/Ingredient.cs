using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class Ingredient
    {   
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Notes { get; set; }
    }
}
