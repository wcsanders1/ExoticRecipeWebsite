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
                    recipeIngredientsDB = "[{\"Ingredient\": \"Mint\", \"Amount\": \"3\", \"SingularMeasurement\": \"sprig\", \"PluralMeasurement\": \"sprigs\"}, {\"Ingredient\": \"Hope\", \"Amount\": \"50\", \"SingularMeasurement\": \"handful\", \"PluralMeasurement\": \"handfuls\"}, {\"Ingredient\": \"Paper\", \"Amount\": \"7.5\", \"SingularMeasurement\": \"tbsp\", \"PluralMeasurement\": \"tbsps\"}, {\"Ingredient\": \"Pie\", \"Amount\": \"4\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Corn Oil\", \"Amount\": \"11\", \"SingularMeasurement\": \"tube\", \"PluralMeasurement\": \"tubes\"}, {\"Ingredient\": \"Fame\", \"Amount\": \"2\", \"SingularMeasurement\": \"week\", \"PluralMeasurement\": \"weeks\"}, {\"Ingredient\": \"Calcium\", \"Amount\": \"0.25\", \"SingularMeasurement\": \"handful\", \"PluralMeasurement\": \"handfuls\"}, {\"Ingredient\": \"Bread\", \"Amount\": \"1\", \"SingularMeasurement\": \"loaf\", \"PluralMeasurement\": \"loaves\"}, {\"Ingredient\": \"Deer\", \"Amount\": \"1\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Cream\", \"Amount\": \"7\", \"SingularMeasurement\": \"glass\", \"PluralMeasurement\": \"glasses\"}]",
                    recipeInstructionsDB = "{\"1\": \"Get the salt and flour out of the drawer.\", \"2\": \"Put everything back.\", \"3\": \"Get out what you really need.\", \"4\": \"Do what you need to do.\", \"5\": \"Find a way of life that's closer to nature.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "King Hupple's Regret",
                    recipeImageDB = "../images/cardamon-cocoa.gif",
                    recipeDescriptionDB = "Likely the only thing ol' Hupple regretted about this meal was eating too much of it! The cocoa accentuates the spring-flower notes of the cardamon, but it's the cardamon that really brings the cocoa to full body.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Fire\", \"Amount\": \"1\", \"SingularMeasurement\": \"flame\", \"PluralMeasurement\": \"flames\"}, {\"Ingredient\": \"Salt\", \"Amount\": \"3.5\", \"SingularMeasurement\": \"load\", \"PluralMeasurement\": \"loads\"}, {\"Ingredient\": \"Pride\", \"Amount\": \"1\", \"SingularMeasurement\": \"foot\", \"PluralMeasurement\": \"feet\"}, {\"Ingredient\": \"Water\", \"Amount\": \"0.8\", \"SingularMeasurement\": \"cup\", \"PluralMeasurement\": \"cups\"}, {\"Ingredient\": \"Gum\", \"Amount\": \"10.5\", \"SingularMeasurement\": \"stick\", \"PluralMeasurement\": \"sticks\"}, {\"Ingredient\": \"Gypsum\", \"Amount\": \"0.05\", \"SingularMeasurement\": \"cart\", \"PluralMeasurement\": \"carts\"}, {\"Ingredient\": \"Cake\", \"Amount\": \"2\", \"SingularMeasurement\": \"piece\", \"PluralMeasurement\": \"pieces\"}, {\"Ingredient\": \"Cream\", \"Amount\": \"6.5\", \"SingularMeasurement\": \"thimble\", \"PluralMeasurement\": \"thimbles\"}, {\"Ingredient\": \"Embers\", \"Amount\": \"2.1\", \"SingularMeasurement\": \"pallet\", \"PluralMeasurement\": \"pallets\"}]",
                    recipeInstructionsDB = "{\"1\": \"Swing your arms around like a helicopter.\", \"2\": \"Stop doing that after a while.\", \"3\": \"There's nothing on television, but you'll watch it a bit anyway.\", \"4\": \"Put the food into the fridge to marinate and make that phone call while you wait.\", \"5\": \"You'll know the dish is done when it's all gone.\", \"6\": \"Make sure the edges are nice and brown and crisp.\", \"7\": \"Sprinkle sugar atop a'fore serving.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Liquor",
                    recipeImageDB = "../images/liquor.gif",
                    recipeDescriptionDB = "American Indians introduced this delicacy to the Europeans when Abraham Lincoln first landed in the New World in 1211. Its earthy texture has connotations of new birth, while its ethereal aroma is known to evoke the philosophical mindset.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Coconut fat\", \"Amount\": \"4.25\", \"SingularMeasurement\": \"mug\", \"PluralMeasurement\": \"mugs\"}, {\"Ingredient\": \"Anise Seeds\", \"Amount\": \"0.75\", \"SingularMeasurement\": \"cap\", \"PluralMeasurement\": \"caps\"}, {\"Ingredient\": \"Wheat\", \"Amount\": \"7\", \"SingularMeasurement\": \"strand\", \"PluralMeasurement\": \"strands\"}, {\"Ingredient\": \"Greek Yogurt\", \"Amount\": \"1.2\", \"SingularMeasurement\": \"tank\", \"PluralMeasurement\": \"tanks\"}, {\"Ingredient\": \"Garam Masala\", \"Amount\": \"0.5\", \"SingularMeasurement\": \"tsp\", \"PluralMeasurement\": \"tsps\"}, {\"Ingredient\": \"Boston Lettuce\", \"Amount\": \"1\", \"SingularMeasurement\": \"leaf\", \"PluralMeasurement\": \"leaves\"}, {\"Ingredient\": \"Tamarind Paste\", \"Amount\": \"19\", \"SingularMeasurement\": \"ml\", \"PluralMeasurement\": \"mls\"}, {\"Ingredient\": \"Twine\", \"Amount\": \"2\", \"SingularMeasurement\": \"yard\", \"PluralMeasurement\": \"yards\"}]",
                    recipeInstructionsDB = "{\"1\": \"Put the ingredients into a pan.\", \"2\": \"Cook the ingredients over a hot stove till done.\", \"3\": \"Let simmer for a while to reduce the excess moisture.\", \"4\": \"Add water to taste.\", \"5\": \"Let simmer for a while to get rid of that water you added.\", \"6\": \"Now you're going to have to add more water to replace that water that evaporated while the dish was simmering.\", \"7\": \"Let simmer; stir occassionally.\", \"8\": \"Add water to taste.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Sylvan Delight",
                    recipeImageDB = "../images/sylvan.gif",
                    recipeDescriptionDB = "This dish is kind to the simple and sophisticated palate alike. Some say it's mouthfeel is like the first breeze of an oncoming storm. Others say this is just simply the best thing they've ever tasted or ever will!",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Pork\", \"Amount\": \"1\", \"SingularMeasurement\": \"lb\", \"PluralMeasurement\": \"lbs\"}, {\"Ingredient\": \"Magazines\", \"Amount\": \"6\", \"SingularMeasurement\": \"\", \"PluralMeasurement\": \"\"}, {\"Ingredient\": \"Granite\", \"Amount\": \"4\", \"SingularMeasurement\": \"stone\", \"PluralMeasurement\": \"stones\"}, {\"Ingredient\": \"Mustard Oil\", \"Amount\": \"1.5\", \"SingularMeasurement\": \"mug\", \"PluralMeasurement\": \"mugs\"}, {\"Ingredient\": \"Cow Meat\", \"Amount\": \"12\", \"SingularMeasurement\": \"tsp\", \"PluralMeasurement\": \"tsps\"}, {\"Ingredient\": \"Whole Olives\", \"Amount\": \"4\", \"SingularMeasurement\": \"jar\", \"PluralMeasurement\": \"jars\"}]",
                    recipeInstructionsDB = "{\"1\": \"Consider your regrets.\", \"2\": \"But don't dwell on them too long.\", \"3\": \"Use your laments of the past to improve your present.\", \"4\": \"The natural law is not violated with impunity.\", \"5\": \"We all pay our debts.\", \"6\": \"Look at what's before you with open eyes and a clear mind.\", \"7\": \"Add water to taste.\"}",
                    recipeAuthorDB = "Bill Sanders"
                },
                new Table()
                {
                    recipeNameDB = "Ziffledon With Seeds",
                    recipeImageDB = "../images/ziffledon.gif",
                    recipeDescriptionDB = "FDR had a bowl of this every morning before he even considered tinkering with the value of the dollar. Whether you're a president, priest, or pauper, this concoction will sitr your imagination fill you right up.",
                    recipeIngredientsDB = "[{\"Ingredient\": \"Rye\", \"Amount\": \".32\", \"SingularMeasurement\": \"drop\", \"PluralMeasurement\": \"drops\"}, {\"Ingredient\": \"Electricity\", \"Amount\": \"191\", \"SingularMeasurement\": \"volt\", \"PluralMeasurement\": \"volts\"}, {\"Ingredient\": \"Ham\", \"Amount\": \"5\", \"SingularMeasurement\": \"slab\", \"PluralMeasurement\": \"slabs\"}, {\"Ingredient\": \"Small Pebbles\", \"Amount\": \"1\", \"SingularMeasurement\": \"hat-full\", \"PluralMeasurement\": \"hats-full\"}, {\"Ingredient\": \"Texas Salt\", \"Amount\": \"0.8\", \"SingularMeasurement\": \"carafe\", \"PluralMeasurement\": \"carafes\"}, {\"Ingredient\": \"Flounder\", \"Amount\": \"4\", \"SingularMeasurement\": \"piece\", \"PluralMeasurement\": \"pieces\"}, {\"Ingredient\": \"Yolk\", \"Amount\": \"58.1\", \"SingularMeasurement\": \"helping\", \"PluralMeasurement\": \"helpings\"}]",
                    recipeInstructionsDB = "{\"1\": \"If the self is a delusion, from where does it arise?\", \"2\": \"Heat the milk till boiling.\", \"3\": \"Allow the milk to simmer while covered, and add salt to taste.\", \"4\": \"If the beginning was a singularity, what changed it?\", \"5\": \"Peel some ginger and place it gently in the foaming milk.\", \"6\": \"Accept the mystery.\"}",
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