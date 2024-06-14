using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{

    // Define class for a recipe
    class Recipe
    {
        private List<Ingredient> ingredients; // List to store the ingredients
        private List<string> steps; // List to store the steps
        public string Name { get; set; } // Name of the recipe

        // Constructor to initialize the recipe and its properties
        public Recipe(string name)
        {
            Name = name;
            ingredients = new List<Ingredient>();
            steps = new List<string>();
        }

        // Method to add an ingredient to the recipe
        public void AddIngredient(Ingredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        // Method to add a step to the recipe
        public void AddStep(string step)
        {
            steps.Add(step);
        }

        // Method to calculate and display the total calories of the recipe
        public void DisplayTotalCalories()
        {
            int totalCalories = ingredients.Sum(ingredient => ingredient.Calories);
            Console.WriteLine($"Total calories: {totalCalories}");
            if (totalCalories > 300)
            {
                Console.WriteLine("Warning: This recipe exceeds 300 calories.");
            }
        }

        // Method to display the recipe in a neat format
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Recipe: {Name}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, {ingredient.FoodGroup})");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }
}