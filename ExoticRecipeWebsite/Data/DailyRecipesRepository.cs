using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExoticRecipeWebsite.Models;

namespace ExoticRecipeWebsite.Data
{
    public class DailyRecipesRepository
    {
        private static DailyRecipes[] _dailyRecipes = new DailyRecipes[]
        {
            new DailyRecipes()
            {
                RecipeTitle = "Onions with Ginger",
                RecipeImage = "../images/onions_with_ginger.gif",
                RecipeCaption = "This is a classic main course from the Kambala region of northern India. It has a sublte aroma, but a bold, stringent palate. Pairs well with rice or wine.",
                RecipeIngredients = new string[][]
                {
                    new string[] {"Water", "3", "cups"},
                    new string[] {"Cinnamon", "2", "tbls"},
                    new string[] {"Manganese", "1", "cube"}
      
                },
                RecipeInstructions = new string[]
                {
                    "Wring the juice out of the nettle.",
                    "Wash the salt.",
                    "Smash everything together until settled."
                }
            },
            new DailyRecipes()
            {
                RecipeTitle = "Salt and Coffee",
                RecipeImage = "../images/salt_and_coffee.gif",
                RecipeCaption = "Don't be intimidated by the sophistication of this Russian side dish. Well... ok, be intimidated--but don't be shy about digging right in!",
                RecipeIngredients = new string[][]
                {
                    new string[] {"Olive Oil", ".5", "cups"},
                    new string[] {"Sea Water", "1", "gallon"},
                    new string[] {"Earth", "2", "tsp"},
                    new string[] {"Egg", "1", ""}  
                },
                RecipeInstructions = new string[]
                {
                    "Denounce delusion in all its forms.",
                    "Prepare a pan of hot cocnut oil.",
                    "Smash everything together.",
                    "Put yourself in alternative shoes."
                }
            },
            new DailyRecipes()
            {
                RecipeTitle = "Bennington's Mash",
                RecipeImage = "../images/pepper-cilantro.gif",
                RecipeCaption = "This rustic snack isn't for the fainthearted. The pepper gives it bite, though the cilantro tempers the stray jungle notes. This is the perfect addition to a smart dinner party.",
                RecipeIngredients = new string[][]
                {
                    new string[] {"Helium", "44", "mls"},
                    new string[] {"Copper Wire", "3", "feet"},
                    new string[] {"Brown Sugar", "", "a pinch"},
                    new string[] {"Cidar", "2", "bowls"},
                    new string[] {"Sheep", "5", ""}
                },
                RecipeInstructions = new string[]
                {
                    "Move all of your cookware to the highest possible position in the kitchen.",
                    "Don't answer the door.",
                    "Smash everything together.",
                    "Ponder the origin of dust.",
                    "Add saffron at the end for extra decadence!"
                }
            },
            new DailyRecipes()
            {
                RecipeTitle = "St. Jessup's Gift",
                RecipeImage = "../images/raw-pasta.gif",
                RecipeCaption = "This simple gem of a dish will fill your house with the lucious aroma of wheat. It's heart-healthy too!",
                RecipeIngredients = new string[][]
                {
                    new string[] {"Ice", "2", "handles"},
                    new string[] {"1996 Toyata Camry", "", ""},
                    new string[] {"Ash", "5", "cups"},
                    new string[] {"Tepid Milk", "2", "tsp"}
                },
                RecipeInstructions = new string[]
                {
                    "Set the oven to 350 degrees.",
                    "Be sure to turn the oven off before you leave.",
                    "Check the oven again, to make sure it's off.",
                    "Did you check each knob? Were all of them turned to 'off'?",
                    "Did you check the coffee maker too, to make sure you unplugged it?"
                }
            },
        };

        public DailyRecipes GetDailyRecipe()
        {
            Random rnd = new Random();
            int recipeNum = rnd.Next(0, _dailyRecipes.Length);
            return _dailyRecipes[recipeNum];
        }
    }
}