using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

        public ActionResult ScrollRecipes()   // This is probably stupid
        {
            var dailyRecipe = _dailyRecipesRepository.GetNextDailyRecipe("forward");
            return View("Index", dailyRecipe);
        }
    }
}