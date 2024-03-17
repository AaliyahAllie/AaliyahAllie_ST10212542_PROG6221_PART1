using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public List<string> IngredientNames { get; set; }
        public List<int> IngredientQuantities { get; set; }
        public List<string> UnitOfMeasurements { get; set; }
        public List<String> Steps { get; set; }

        //method to capture into array list
        public Recipe(string recipeName)
        {
            recipeName = recipeName;
            IngredientNames = new List<string>();
            IngredientQuantities = new List<int>();
            UnitOfMeasurements = new List<string>();
            Steps = new List<string>();
        }



    }
}
