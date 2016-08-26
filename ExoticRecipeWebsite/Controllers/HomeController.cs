using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ExoticRecipeWebsite.Models;
using ExoticRecipeWebsite.Data;

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
            var dailyRecipe = _dailyRecipesRepository.GetRandomDailyRecipe();
            return View(dailyRecipe);
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