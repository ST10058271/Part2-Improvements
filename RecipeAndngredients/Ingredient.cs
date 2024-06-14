using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{

}


// Define class for an ingredient
class Ingredient 

{
    public string Name { get; set; } // Name of the ingredient
    public double Quantity { get; set; } // Quantity of the ingredient
    public string Unit { get; set; } // Unit of measurement of the ingredient
    public int Calories { get; set; } // Number of calories in the ingredient
    public string FoodGroup { get; set; } // Food group that the ingredient belongs to

    public Ingredient(string name, double quantity, string unit, int calories, string foodGroup)
    {
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Calories = calories;
        FoodGroup = foodGroup;
    }

    public override bool Equals(object? obj)
    {
        return obj is Ingredient ingredient &&
               Name == ingredient.Name &&
               Quantity == ingredient.Quantity &&
               Unit == ingredient.Unit &&
               Calories == ingredient.Calories &&
               FoodGroup == ingredient.FoodGroup;
    }
}
