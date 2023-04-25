using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_poe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Recipe recipe = new Recipe();
            recipe.GetRecipe();
            recipe.DisplayRecipe();
            recipe.ScaleRecipe();
            recipe.ResetRecipe();
            recipe.ClearRecipe();
        }
    }

    class Recipe
    {
        private string name;
        private int numIngredients;
        private string[] ingredients;
        private int[] quantity;
        private string[] unit;
        private int numSteps;
        private string[] steps;

        public void GetRecipe()
        {
            Console.WriteLine("Enter the name of the recipe:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the number of ingredients:");
            numIngredients = Convert.ToInt32(Console.ReadLine());
            ingredients = new string[numIngredients];
            quantity = new int[numIngredients];
            unit = new string[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter the name of the ingredient:");
                ingredients[i] = Console.ReadLine();
                Console.WriteLine("Enter the quantity of the ingredient:");
                quantity[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the unit of the ingredient:");
                unit[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the number of steps:");
            numSteps = Convert.ToInt32(Console.ReadLine());
            steps = new string[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Enter the description of the step:");
                steps[i] = Console.ReadLine();
            }
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe name: " + name);
            Console.WriteLine("Number of ingredients: " + numIngredients);
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient name: " + ingredients[i]);
                Console.WriteLine("Ingredient quantity: " + quantity[i]);
                Console.WriteLine("Ingredient unit: " + unit[i]);
            }
            Console.WriteLine("Number of steps: " + numSteps);
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step description: " + steps[i]);
            }
        }

        public void ScaleRecipe()
        {
            Console.WriteLine("Enter the scale factor:");
            int scaleFactor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numIngredients; i++)
            {
                quantity[i] = quantity[i] * scaleFactor;
            }
            Console.WriteLine("Recipe name: " + name);
            Console.WriteLine("Number of ingredients: " + numIngredients);
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient name: " + ingredients[i]);
                Console.WriteLine("Ingredient quantity: " + quantity[i]);
                Console.WriteLine("Ingredient unit: " + unit[i]);
            }
            Console.WriteLine("Number of steps: " + numSteps);
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step description: " + steps[i]);
            }
        }

        public void ResetRecipe()
        {
            Console.WriteLine("Recipe name: " + name);
            Console.WriteLine("Number of ingredients: " + numIngredients);
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Ingredient name: " + ingredients[i]);
                Console.WriteLine("Ingredient quantity: " + quantity[i]);
                Console.WriteLine("Ingredient unit: " + unit[i]);
            }
            Console.WriteLine("Number of steps: " + numSteps);
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine("Step description: " + steps[i]);
            }
        }

        public void ClearRecipe()
        {
            name = "";
            numIngredients = 0;
            ingredients = new string[numIngredients];
            quantity = new int[numIngredients];
            unit = new string[numIngredients];
            numSteps = 0;
            steps = new string[numSteps];
        }
    }
}
Recipe recipe = new Recipe();
recipe.GetRecipe();
recipe.DisplayRecipe();
recipe.ScaleRecipe();
recipe.ResetRecipe();
recipe.ClearRecipe();
class Recipe
{
    private string name;
    private int numIngredients;
    private string[] ingredients;
    private int[] quantity;
    private string[] unit;
    private int numSteps;
    private string[] steps;

    public void GetRecipe()
    {
        Console.WriteLine("Enter the name of the recipe:");
        name = Console.ReadLine();
        Console.WriteLine("Enter the number of ingredients:");
        numIngredients = Convert.ToInt32(Console.ReadLine());
        ingredients = new string[numIngredients];
        quantity = new int[numIngredients];
        unit = new string[numIngredients];
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("Enter the name of the ingredient:");
            ingredients[i] = Console.ReadLine();
            Console.WriteLine("Enter the quantity of the ingredient:");
            quantity[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the unit of the ingredient:");
            unit[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the number of steps:");
        numSteps = Convert.ToInt32(Console.ReadLine());
        steps = new string[numSteps];
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine("Enter the description of the step:");
            steps[i] = Console.ReadLine();
        }
    }

    public void DisplayRecipe()
    {
        Console.WriteLine("Recipe name: " + name);
        Console.WriteLine("Number of ingredients: " + numIngredients);
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("Ingredient name: " + ingredients[i]);
            Console.WriteLine("Ingredient quantity: " + quantity[i]);
            Console.WriteLine("Ingredient unit: " + unit[i]);
        }
        Console.WriteLine("Number of steps: " + numSteps);
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine("Step description: " + steps[i]);
        }
    }

    public void ScaleRecipe()
    {
        Console.WriteLine("Enter the scale factor:");
        int scaleFactor = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numIngredients; i++)
        {
            quantity[i] = quantity[i] * scaleFactor;
        }
        Console.WriteLine("Recipe name: " + name);
        Console.WriteLine("Number of ingredients: " + numIngredients);
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("Ingredient name: " + ingredients[i]);
            Console.WriteLine("Ingredient quantity: " + quantity[i]);
            Console.WriteLine("Ingredient unit: " + unit[i]);
        }
        Console.WriteLine("Number of steps: " + numSteps);
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine("Step description: " + steps[i]);
        }
    }

    public void ResetRecipe()
    {
        Console.WriteLine("Recipe name: " + name);
        Console.WriteLine("Number of ingredients: " + numIngredients);
        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("Ingredient name: " + ingredients[i]);
            Console.WriteLine("Ingredient quantity: " + quantity[i]);
            Console.WriteLine("Ingredient unit: " + unit[i]);
        }
        Console.WriteLine("Number of steps: " + numSteps);
        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine("Step description: " + steps[i]);
        }
    }

    public void ClearRecipe()
    {
        name = "";
        numIngredients = 0;
        ingredients = new string[numIngredients];
        quantity = new int[numIngredients];
        unit = new string[numIngredients];
        numSteps = 0;
        steps = new string[numSteps];
    }
}


