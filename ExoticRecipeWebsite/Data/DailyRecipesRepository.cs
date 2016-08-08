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