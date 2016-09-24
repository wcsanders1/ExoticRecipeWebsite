using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
//using ExoticRecipeWebsite.Models;
using ExoticRecipeWebsite.Data;
using System.Web.Services;
using System.Web.Script.Services;

namespace ExoticRecipeWebsite.Controllers
{
    public class DataController : Controller
    {
        private List<Table> _allTables = null;

        public DataController()
        {

        }

        public ActionResult GetTable()
        {
            return View();
        }

        public JsonResult GetAllTables()
        {
            _allTables = new List<Table>();

            using (siteDatabaseEntities dc = new siteDatabaseEntities())
            {
                _allTables = dc.Tables.ToList();
            }

            return new JsonResult { Data = _allTables, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public void SaveTable(Table table)
        {
            using (siteDatabaseEntities dc = new siteDatabaseEntities())
            {
                dc.Tables.Add(table);
                
            }
        }
    }
}