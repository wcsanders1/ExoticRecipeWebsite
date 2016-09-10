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
            var seedData = new List<Table>()
            {
                new Table()
                {
                    recipeNameDB = "Tazmanian Sizzler",
                    recipeImageDB = "../images/Tazmanian_sizzler.gif",
                    recipeDescriptionDB = "Legend has it that if you eat too much of this mysterious dinner, you'll achieve interesting feats. So in the interest of caution, try to control yourself and take small bites!",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Bark\", \"Amount\": \"34\", \"SingularMeasurement\": \"piece\", \"PluralMeasurement\": \"pieces\"}, {\"Ingredient\": \"Bay Leaves\", \"Amount\": \"2\", \"SingularMeasurement\": \"head\", \"PluralMeasurement\": \"heads\"}, {\"Ingredient\": \"Seeds\", \"Amount\": \"8\", \"SingularMeasurement\": \"oz\", \"PluralMeasurement\": \"ozs\"}]",
                    recipeInstructionsDB = "{\"1\": \"Wash all of the utensils for safety.\", \"2\": \"Determine the proper value of money.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Eppelstauffer",
                    recipeImageDB = "../images/Eppel-gek.gif",
                    recipeDescriptionDB = "This lovely morsel captivates the senses and intoxicates the brain.  One bite and you'll be wondering why you haven't been eating this for each and every meal every day of your entire life.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Almond butter\", \"Amount\": \"304\", \"SingularMeasurement\": \"spoon\", \"PluralMeasurement\": \"spoons\"}, {\"Ingredient\": \"Plaster\", \"Amount\": \"9.6\", \"SingularMeasurement\": \"truckload\", \"PluralMeasurement\": \"truckloads\"}, {\"Ingredient\": \"Pears\", \"Amount\": \"3\", \"SingularMeasurement\": \"oz\", \"PluralMeasurement\": \"ozs\"}, {\"Ingredient\": \"Batteries\", \"Amount\": \"6\", \"SingularMeasurement\": \"oz\", \"PluralMeasurement\": \"ozs\"}]",
                    recipeInstructionsDB = "{\"1\": \"Add oil to a hot pan.\", \"2\": \"Stir in water.\", \"3\": \"Add oil to taste.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Onions with Ginger",
                    recipeImageDB = "../images/onions_with_ginger.gif",
                    recipeDescriptionDB = "This is a classic main course from the Kambala region of northern India. It has a sublte aroma, but a bold, stringent palate. Pairs well with rice or wine.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Water\", \"Amount\": \"3\", \"SingularMeasurement\": \"cup\", \"PluralMeasurement\": \"cups\"}, {\"Ingredient\": \"Cinnamon\", \"Amount\": \"2\", \"SingularMeasurement\": \"tbsp\", \"PluralMeasurement\": \"tbsps\"}, {\"Ingredient\": \"Manganese\", \"Amount\": \"1\", \"SingularMeasurement\": \"cube\", \"PluralMeasurement\": \"cubes\"}]",
                    recipeInstructionsDB = "{\"1\": \"Wring the juice out of the nettle.\", \"2\": \"Wash the salt.\", \"3\": \"Smash everything together until settled.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Salt and Coffee",
                    recipeImageDB = "../images/salt_and_coffee.gif",
                    recipeDescriptionDB = "Don't be intimidated by the sophistication of this Russian side dish. Well... ok, be intimidated--but don't be shy about digging right in!",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Olive Oil\", \"Amount\": \"0.5\", \"SingularMeasurement\": \"cup\", \"PluralMeasurement\": \"cups\"}, {\"Ingredient\": \"Sea Water\", \"Amount\": \"1\", \"SingularMeasurement\": \"gallon\", \"PluralMeasurement\": \"gallons\"}, {\"Ingredient\": \"Earth\", \"Amount\": \"2\", \"SingularMeasurement\": \"tsp\", \"PluralMeasurement\": \"tsps\"}, {\"Ingredient\": \"Eggs\", \"Amount\": \"1\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}]",
                    recipeInstructionsDB = "{\"1\": \"Denounce delusion in all its forms.\", \"2\": \"Prepare a pan of hot cocnut oil.\", \"3\": \"Smash everything together.\", \"4\": \"Put yourself in alternative shoes.\" }",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Bennington's Mash",
                    recipeImageDB = "../images/pepper-cilantro.gif",
                    recipeDescriptionDB = "This rustic snack isn't for the fainthearted. The pepper gives it bite, though the cilantro tempers the stray jungle notes. This is the perfect addition to a smart dinner party.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Helium\", \"Amount\": \"44\", \"SingularMeasurement\": \"ml\", \"PluralMeasurement\": \"mls\"}, {\"Ingredient\": \"Copper Wire\", \"Amount\": \"3\", \"SingularMeasurement\": \"foot\", \"PluralMeasurement\": \"feet\"}, {\"Ingredient\": \"Brown Sugar\", \"Amount\": \"\", \"SingularMeasurement\": \"pinch\", \"PluralMeasurement\": \"pinches\"}, {\"Ingredient\": \"Cidar\", \"Amount\": \"2\", \"SingularMeasurement\": \"bowl\", \"PluralMeasurement\": \"bowls\"}, {\"Ingredient\": \"Sheep\", \"Amount\": \"5\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}]",
                    recipeInstructionsDB = "{\"1\": \"Move all of your cookware to the highest possible position in the kitchen.\", \"2\": \"Don't answer the door.\", \"3\": \"Smash everything together.\", \"4\": \"Ponder the origin of dust.\", \"5\": \"Add saffron at the end for extra decadence!\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "St. Jessup's Gift",
                    recipeImageDB = "../images/raw-pasta.gif",
                    recipeDescriptionDB = "This simple gem of a dish will fill your house with the lucious aroma of wheat. It's heart-healthy too!",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Ice\", \"Amount\": \"2\", \"SingularMeasurement\": \"handle\", \"PluralMeasurement\": \"handles\"}, {\"Ingredient\": \"1996 Toyta Camry\", \"Amount\": \"1\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Ash\", \"Amount\": \"5\", \"SingularMeasurement\": \"cup\", \"PluralMeasurement\": \"cups\"}, {\"Ingredient\": \"Tepid Milk\", \"Amount\": \"2\", \"SingularMeasurement\": \"tsp\", \"PluralMeasurement\": \"tsps\"}]",
                    recipeInstructionsDB = "{\"1\": \"Set the oven to 350 degrees.\", \"2\": \"Be sure to turn the oven off before you leave.\", \"3\": \"Check the oven again, to make sure it's off.\", \"4\": \"Did you check each knob? Were all of them turned to 'off'\", \"5\": \"Did you check the coffee maker too, to make sure you unplugged it?\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Syrian Waffles",
                    recipeImageDB = "../images/Syrian-waffles.gif",
                    recipeDescriptionDB = "A little \"syr\"up, a little salt, and a whole lot of delicious!",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Mint\", \"Amount\": \"3\", \"SingularMeasurement\": \"sprig\", \"PluralMeasurement\": \"sprigs\"}, {\"Ingredient\": \"Hope\", \"Amount\": \"50\", \"SingularMeasurement\": \"handful\", \"PluralMeasurement\": \"handfuls\"}, {\"Ingredient\": \"Paper\", \"Amount\": \"7.5\", \"SingularMeasurement\": \"tbsp\", \"PluralMeasurement\": \"tbsps\"}, {\"Ingredient\": \"Pie\", \"Amount\": \"4\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Corn Oil\", \"Amount\": \"11\", \"SingularMeasurement\": \"tube\", \"PluralMeasurement\": \"tubes\"}, {\"Ingredient\": \"Fame\", \"Amount\": \"2\", \"SingularMeasurement\": \"week\", \"PluralMeasurement\": \"weeks\"}, {\"Ingredient\": \"Calcium\", \"Amount\": \"0.25\", \"SingularMeasurement\": \"handful\", \"PluralMeasurement\": \"handfuls\"}, {\"Ingredient\": \"Bread\", \"Amount\": \"3\", \"SingularMeasurement\": \"loaf\", \"PluralMeasurement\": \"loaves\"}, {\"Ingredient\": \"Deer\", \"Amount\": \"1\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Cream\", \"Amount\": \"7\", \"SingularMeasurement\": \"glass\", \"PluralMeasurement\": \"glasses\"}]",
                    recipeInstructionsDB = "{\"1\": \"Get the salt and flour out of the drawer.\", \"2\": \"Put everything back.\", \"3\": \"Get out what you really need.\", \"4\": \"Do what you need to do.\", \"5\": \"Find a way of life that's closer to nature.\"}",
                    recipeAuthorDB = "Bill Sanders"
                }
            };

            using (siteDatabaseEntities dc = new siteDatabaseEntities())
            {
                if (!dc.Tables.Any())
                {
                    dc.Tables.AddRange(seedData);
                    dc.SaveChanges();
                }
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