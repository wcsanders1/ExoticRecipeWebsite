using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoticRecipeWebsite.Data
{
    public class RecipesSeedData
    {
        public static void EnsureSeedData()
        {
            var seedData = new Table()
            {
                recipeNameDB = "Tazmanian Sizzler",
                recipeImageDB = "../images/Tazmanian_sizzler.gif",
                recipeDescriptionDB = "Legend has it that if you eat too much of this mysterious dinner, you'll achieve interesting feats. So in the interest of caution, try to control yourself and take small bites!",
                recipeIngredientsDB = "[{\"Ingredient\": \"Bark\", \"Amount\": \"34\", \"Measurement\": \"piece\"}, {\"Ingredient\": \"Bay Leaves\", \"Amount\": \"2\", \"Measurement\": \"head\"}, {\"Ingredient\": \"Seeds\", \"Amount\": \"8\", \"Measurement\": \"oz\"}]",
                recipeInstructionsDB = "{\"1\": \"Wash all of the utensils for safety.\", \"2\": \"Determine the proper value of money.\"}",
                recipeOrderDB = 6
            };

            using (siteDatabaseEntities dc = new siteDatabaseEntities())
            {
                dc.Tables.Add(seedData);
                dc.SaveChanges();
            }
        }
    }
}


//[{"Ingredient": "Bark", "Amount": "34", "Measurement": "piece"}, {"Ingredient": "Bay Leaves", "Amount": "2", "Measurement": "head"}, {"Ingredient": "Seeds", "Amount": "8", "Measurement": "oz"}]





//    if (!_context.Trips.Any())
//    {
//        var usTrip = new Trip()
//        {
//            DateCreated = DateTime.UtcNow,
//            Name = "US Trip",
//            UserName = "samhastings",
//            Stops = new List<Stop>()
//                    {
//                        new Stop() {  Name = "Atlanta, GA", Arrival = new DateTime(2014, 6, 4), Latitude = 33.748995, Longitude = -84.387982, Order = 0 },
//                        new Stop() {  Name = "New York, NY", Arrival = new DateTime(2014, 6, 9), Latitude = 40.712784, Longitude = -74.005941, Order = 1 },
//                        new Stop() {  Name = "Boston, MA", Arrival = new DateTime(2014, 7, 1), Latitude = 42.360082, Longitude = -71.058880, Order = 2 },
//                        new Stop() {  Name = "Chicago, IL", Arrival = new DateTime(2014, 7, 10), Latitude = 41.878114, Longitude = -87.629798, Order = 3 },
//                        new Stop() {  Name = "Seattle, WA", Arrival = new DateTime(2014, 8, 13), Latitude = 47.606209, Longitude = -122.332071, Order = 4 },
//                        new Stop() {  Name = "Atlanta, GA", Arrival = new DateTime(2014, 8, 23), Latitude = 33.748995, Longitude = -84.387982, Order = 5 }
//                    }
//        };

//        _context.Trips.Add(usTrip);

//        _context.Stops.AddRange(usTrip.Stops);