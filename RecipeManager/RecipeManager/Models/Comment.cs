using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public string Author { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }

    }
}
