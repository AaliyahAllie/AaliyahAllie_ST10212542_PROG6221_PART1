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

        //this method allows for the capturing of ingredients into the recipe
        public void AddIngredients(string name,int quatity,string unitOfMeasurement)
        {
            IngredientNames.Add(name);
            IngredientQuantities.Add(quatity);
            UnitOfMeasurements.Add(unitOfMeasurement);
        }

        //this method will allow for the users input to get captures to add the steps into the program
        public void AddStep (string step)
        {
            Steps.Add(step);
        }


    }
}
