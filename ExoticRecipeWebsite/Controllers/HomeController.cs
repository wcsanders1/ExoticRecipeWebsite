using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ExoticRecipeWebsite.Data;
using System.Web.Services;
using System.Web.Script.Services;

namespace ExoticRecipeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        
        public ActionResult Index()
        {
            RecipesSeedData.EnsureSeedData();

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
    }
}