using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoticRecipeWebsite.Models
{
    public class DailyRecipes
    {
        public string RecipeTitle { get; set; }
        public string RecipeImage { get; set; }
        public string RecipeCaption { get; set; }
        public string[][] RecipeIngredients { get; set; }
    }
}