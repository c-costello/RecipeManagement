using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeManager.Models
{
    public class Instruction
    {
        public int RecipeID { get; set; }
        public int StepNumber { get; set; }
        public string Detail { get; set; }
    }
}
