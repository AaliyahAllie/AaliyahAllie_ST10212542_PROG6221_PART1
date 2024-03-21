namespace AaliyahAllie_ST10212542_PROG6221_PART1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Array list to store values
            List<Recipe> recipes = new List<Recipe>();
            int choice = 0;

            while (true)
            {
                //Basic user interface
                Console.WriteLine("***********************************************");
                Console.WriteLine("Welcome To Your Recipe Application");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Please enter (1) to launch the menu");
                Console.WriteLine();


                //if user selects anything other than 1 an error message will display
                if (!int.TryParse(Console.ReadLine(),  out choice) || choice != 1)
                {
                    Console.WriteLine("INVALID OPTION.ENTER (1) TO LAUNCH MENU");
                    continue;
                }
                Console.WriteLine();

                Console.WriteLine("***********************************************");
                Console.WriteLine("PLEASE SELECT ONE OF THE NUMERIC OPTIONS BELOW");
                Console.WriteLine("***********************************************");
                Console.WriteLine("1.Enter new recipe");
                Console.WriteLine("2.Display recipe");
                Console.WriteLine("3.Scale recipe (0.5, 2, 3)");
                Console.WriteLine("4.Reset recipe to original values");
                Console.WriteLine("5.Clear recipe data");
                Console.WriteLine("6.Exit Program");
                Console.WriteLine("***********************************************");
                Console.WriteLine();

                int userChoice;
                if(!int.TryParse(Console.ReadLine(),out userChoice))
                {
                    Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER.");
                    continue;
                }
                Console.WriteLine();

                switch(userChoice) 
                {
                    case 1:
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("ENTER NEW RECIPE DETAILS");
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Enter recipe name: ");
                        string recipeName = Console.ReadLine();
                        Recipe newRecipe = new Recipe(recipeName); // Instantiate a new Recipe object
                        Console.WriteLine("Enter number of ingredients: ");
                        int numIngredients;
                        if (!int.TryParse(Console.ReadLine(), out numIngredients))
                        {
                            Console.WriteLine("INVALID INPUT.PLEASE ENTER A VALID NUMBER.");
                            continue;
                        }
                        for (int i = 0; i < numIngredients; i++)
                        {
                            Console.WriteLine($"Ingredient {i + 1}");
                            Console.WriteLine("Name: ");
                            string ingredientName = Console.ReadLine();
                            Console.WriteLine("Quantity: ");
                            int ingredientQuantity;
                            if (!int.TryParse(Console.ReadLine(), out ingredientQuantity))
                            {
                                Console.WriteLine("Invalid input.Please enter a valid number.");
                                continue;
                            }
                            Console.WriteLine("Unit of Measurement (ml/mg/teaspoon/tablespoon/cup)");
                            string unitOfMeasurement = Console.ReadLine();
                            newRecipe.AddIngredients(ingredientName, ingredientQuantity, unitOfMeasurement);
                        }
                        Console.WriteLine("Enter the number of steps: ");
                        int numSteps;
                        if (!int.TryParse(Console.ReadLine(), out numSteps))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                            continue;
                        }
                        for (int i = 0; i < numSteps; i++)
                        {
                            Console.WriteLine($"Step {i + 1}: ");
                            string step = Console.ReadLine();
                            newRecipe.AddStep(step);
                        }
                        recipes.Add(newRecipe);
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        Console.WriteLine();
                        break;


                    case 2:
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("DISPLAYING RECIPE DETAILS:");
                        Console.WriteLine("***********************************************");
                        foreach(Recipe recipe in recipes)
                        {
                            recipe.DisplayRecipe();
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("SCALE RECIPE:");
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Enter the scaling factor(0.5,2,3): ");
                        double scaleFactor;
                        if(!double.TryParse(Console.ReadLine(),out scaleFactor))
                        {
                            Console.WriteLine("Invalid input.Enter a valid number");
                            continue;
                        }
                        foreach(Recipe recipe in recipes)
                        {
                            recipe.ScaleRecipe(scaleFactor);
                        }
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("RESET RECIPE TO ORIGINAL VALUES");
                        Console.WriteLine("***********************************************");
                        foreach(Recipe recipe in recipes)
                        {
                            recipe.ResetRecipe();
                        }
                        Console.WriteLine("RECIPE SUCCESSFULLY SAVED");
                        Console.WriteLine();
                        break ;
                    case 5:
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("CLEAR RECIPE DATA:");
                        Console.WriteLine("***********************************************");
                        recipes.Clear();
                        Console.WriteLine("RECIPE DATA SUCCESSFULLY CLEARED");
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Are you sure you want to exit? (y/n)");
                        string exitConfirmation = Console.ReadLine().ToLower();
                        if (exitConfirmation == "y")
                        {
                            Console.WriteLine("THANK YOU FOR USING THIS APPLICATION");
                            Console.WriteLine("PROGRAM WILL NOW CLOSE");
                            Environment.Exit(0);
                        }
                        else if (exitConfirmation == "n")
                        {
                            Console.WriteLine("Returning to the main menu.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Returning to the main menu.");
                        }
                        break;

                    default:
                        Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER");
                        break;
                }

            }
            
        }
    }
    
}