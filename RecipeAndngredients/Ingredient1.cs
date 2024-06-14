using System.Diagnostics;

namespace Part1
{

}

class MainProgram

{
    static List<Recipe> recipes = new List<Recipe>(); // List to store recipes

    // Delegate to notify the user when a recipe exceeds 300 calories
    delegate void RecipeCaloriesExceeded(string recipeName);

    static void Main(string[] args)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            // Gives the user choices
            Console.WriteLine("\nEnter a command:");
            Console.WriteLine("1. Create a new recipe");
            Console.WriteLine("2. Display all recipes");
            Console.WriteLine("3. Select a recipe to display");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            // The different cases are based on the user's input
            switch (input)
            {
                case "1":
                    CreateRecipe();
                    break;
                case "2":
                    DisplayAllRecipes();
                    break;
                case "3":
                    SelectRecipe();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }

    // Method to create a new recipe
    static void CreateRecipe()

    {
        Console.Write("Enter the name of the recipe: ");
        string name = Console.ReadLine();

        Recipe recipe = new Recipe(name);

        Console.Write("Enter the number of ingredients: ");
        int numIngredients = ReadIntegerInput();

        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine($"Ingredient #{i + 1}:");
            Console.Write("Name: ");
            string ingredientName = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = ReadDoubleInput();
            Console.Write("Unit: ");
            string unit = Console.ReadLine();
            Console.Write("Calories: ");
            int calories = ReadIntegerInput();
            Console.Write("Food Group: ");
            string foodGroup = Console.ReadLine();

            Ingredient ingredient = new Ingredient(ingredientName, quantity, unit, calories, foodGroup);
            recipe.AddIngredient(ingredient);
        }

        Console.Write("Enter the number of steps: ");
        int numSteps = ReadIntegerInput();

        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Step #{i + 1}:");
            string step = Console.ReadLine();
            recipe.AddStep(step);
        }

        recipes.Add(recipe);
    }

    // Method to display all recipes in alphabetical order by name
    static void DisplayAllRecipes()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        if (recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
        }
        else
        {
            Console.WriteLine("Recipes:");
            List<string> recipeNames = recipes.Select(recipe => recipe.Name).OrderBy(name => name).ToList();
            foreach (string name in recipeNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    // Method to select and display a specific recipe
    static void SelectRecipe()
    {
        Console.Write("Enter the name of the recipe: ");
        string name = Console.ReadLine();

        Recipe selectedRecipe = recipes.FirstOrDefault(recipe => recipe.Name == name);

        if (selectedRecipe != null)
        {
            selectedRecipe.Display();
            selectedRecipe.DisplayTotalCalories();
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }

    // Helper method to read integer input from the user
    static int ReadIntegerInput()
    {
        int result;
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    // Helper method to read double input from the user
    static double ReadDoubleInput()
    {
        double result;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
}
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Ingredient
{
    public Ingredient(string? ingredientName, double quantity, string? unit, int calories, string? foodGroup)
    {
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Quantity, Unit, Calories, FoodGroup);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}