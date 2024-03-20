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

        //this method Allows the capturing of the recipes details to be fully displayed on the system
        public void DisplayRecipe()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("RECIPE DETAILS");
            Console.WriteLine("***********************************");
            //This calls the recipe name from the previous code and displays it
            Console.WriteLine("Recipe Name: " + RecipeName);
            //This calls the stored details of the ingredients such as the ingredients names, ingredient quantities and unit of measurements
            Console.WriteLine("Ingredients: ");
            for(int i = 0;i < IngredientNames.Count;i++)
            {
                Console.WriteLine($"{IngredientNames[i]} - {IngredientQuantities[i]} {UnitOfMeasurements[i]}");
            }
            //This calls the stored user input and displays the details of the steps
            Console.WriteLine("Steps: ");
            for(int i = 0;i < Steps.Count;i++) 
            {
                Console.WriteLine($"{i + 1}.{Steps[i]}");
            }
            Console.WriteLine("***********************************");
            Console.WriteLine();
        }
        //The following coding method will scale the method to the the following factors {0.5,2,3}
        public void ScaleRecipe(double factor)
        {
            //this for loop will take the ingredient quantities into account and scale them to the factors that the user inserts
            for(int i=0;i < IngredientQuantities.Count;i++)
            {
                IngredientQuantities[i] = (int)(IngredientQuantities[i] * factor);
            }
        }

        //The following method was created in order to reset the Ingredient Quantities back to its original values
        public void ResetRecipe(Recipe originalRecipe)
        {
            //The method first clears the recipes details to be blank
            IngredientNames.Clear();
            IngredientQuantities.Clear();
            UnitOfMeasurements.Clear();
            Steps.Clear();

            //And then the method resets the values to the original information entered by the user before the scale
            RecipeName = originalRecipe.RecipeName;
            IngredientNames.AddRange(originalRecipe.IngredientNames);
            IngredientQuantities.AddRange(originalRecipe.IngredientNames);
            UnitOfMeasurements.AddRange(originalRecipe.UnitOfMeasurements);
            Steps.AddRange(originalRecipe.Steps);

        }

    }
}
