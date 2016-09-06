using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ExoticRecipeWebsite.Models;
using ExoticRecipeWebsite.Data;
using System.Web.Services;
using System.Web.Script.Services;

namespace ExoticRecipeWebsite.Controllers
{
    public class HomeController : Controller
    {
        

        private DailyRecipesRepository _dailyRecipesRepository = null;

        public HomeController()
        {
            _dailyRecipesRepository = new DailyRecipesRepository();
        }
        
        // GET: Main
        public ActionResult Index()
        {
            //var dailyRecipe = _dailyRecipesRepository.GetRandomDailyRecipe();
            //RecipesSeedData.EnsureSeedData(); //THIS WORKS, BUT ONLY ONCE; NEED TO FINISH

            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ScrollRecipes(string direction)
        {
            var dailyRecipe = _dailyRecipesRepository.GetNextDailyRecipe(direction);
            return View("Index", dailyRecipe);
        }
    }
}