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

                int userChoice;
                if(!int.TryParse(Console.ReadLine(),out userChoice))
                {
                    Console.WriteLine("INVALID CHOICE.PLEASE ENTER A VALID NUMBER");
                    continue;
                }
            }
        }
    }
    
}