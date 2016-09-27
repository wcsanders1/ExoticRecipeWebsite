/*********************   GLOBAL VARIABLES   ***************************************************/

var pageSize = $("#search-page-measurement").css("z-index");
var chosenRecipe;
var suggestedRecipe = null;
var resize;

$(document).ready(function () {
    CallDatabase();
    pageSize = $("#search-page-measurement").css("z-index");
    resize = true;
    ResizeForIE();
});

$(window).resize(function () {
    if (!resize) {
        resize = true;
        return;
    }

    pageSize = $("#search-page-measurement").css("z-index");
    
    if (suggestedRecipe != null) {
        ScrollToRecipe(suggestedRecipe);
    } else {
        ScrollToRecipe(chosenRecipe);
    }

    ResizeForIE();

});

function ResizeForIE() {                // this is to fix a problem in IE with the horizontal scroll
    if (pageSize < 4) {
        if (resize) {
            console.log("resizeing");
            window.resizeBy(1, 0);
            resize = false;
        }
    }
}


/*****************  AJAX   ************************/

function OnSuccess(data) {
    var content = "";
    var $homeSelector = $("<li class='navigation-selector'><a href='#'>Home</a></li>");
    var $images = [];
    var $names = [];
    var recipeName;
    var imageText;

    recipesDB = data.sort(function (a, b) { return a.recipeNameDB.localeCompare(b.recipeNameDB); });

    $("#search-wrapper").empty();

    for (var i = 0; i < recipesDB.length; i++) {
        recipeName = recipesDB[i].recipeNameDB;
        imageText = recipesDB[i].recipeImageDB;

        $names[i] = $("<div id='" + i + "' class='name-and-image'><p class='recipes-in-panel'>" + recipeName + "</p>");
        $images[i] = $("<div class='search-image'></div></div>");               
        $images[i].css("background", "url(" + imageText + ") center no-repeat");
        $images[i].css("background-size", "cover");
        $names[i].append($images[i]);
        $names[i].click(RecipesClick);
        $("#search-wrapper").append($names[i]);
    }

    chosenRecipe = 0;
    RecipeChosen(chosenRecipe);
    recipeNum = chosenRecipe;
    DisplayRecipe(chosenRecipe);  //make this display recipe that was displayed on home page
}

function OnError(data) {
    
}

/****************   WHEN A RECIPE IS CLICKED   *********************************/

function RecipesClick() {
    var index = parseInt(this.id);
    RecipeChosen(index);
    recipeNum = index;
    DisplayRecipe(index);
}

function RecipeChosen(index) {
    $(".search-image").removeClass("chosen suggested-recipe");
    var recipeImages = document.getElementsByClassName("search-image");
    recipeImages[index].classList.add("chosen");
    chosenRecipe = index;
}

function DisplayRecipe(index) {
    //fill recipe name
    $recipeName = $("#recipe-name");
    var recipeName = recipesDB[index].recipeNameDB;
    $recipeName.text(recipeName);

    //fill caption
    $recipeCaption = $("#caption-p");
    var recipeCaption = recipesDB[index].recipeDescriptionDB;
    $recipeCaption.text(recipeCaption);

    //fill image
    $recipeImage = $("#image");
    var recipeImage = recipesDB[index].recipeImageDB;
    $recipeImage.attr("src", recipeImage);

    //fill author container
    $authorContainer = $("#author-name");
    var recipeAuthor = recipesDB[index].recipeAuthorDB;
    $authorContainer.text(recipeAuthor);

    //fill ingredients
    $("#serving-size").val(INITIAL_SERVING_SIZE);
    $ingredientsContainer = $("#ingredients-container");
    var ingredientsContent = IngredientsContent(index);
    $ingredientsContainer.html(ingredientsContent);

    //fill instructions
    $instructionsContainer = $("#instructions-container");
    var instructionsContent = InstructionsContent(index);
    $instructionsContainer.html(instructionsContent);
}



/***********************   ALIGN SEARCH SCROLL WITH SEARCH BOX AND HIGHLIGHT IMAGE   ************************/

$("#get-recipe-name").keyup(function (e) {
    $searchResponse = $("#search-response");
    $getRecipeName = $("#get-recipe-name");

    if (e.which != 13) {            // if not "enter"
        var searchInput = $getRecipeName.val().toString().toLowerCase();
        var searchLength = searchInput.length;
        var numberOfRecipes = recipesDB.length;
        var recipeNameLength;
        var bestMatchValue = 0;
        var bestMatchId = null;

        if (searchLength == 0) {
            HighlightRecipe(false, null);
            ScrollToRecipe(chosenRecipe);
            suggestedRecipe = null;
            $searchResponse.html("");
            return;
        }

        for (var x = 0; x < numberOfRecipes; x++) {
            var recipeName = recipesDB[x].recipeNameDB.toString().toLowerCase();
            var match = 0;
            for (var y = 0; y < recipeName.length && y < searchLength; y++) {

                if (recipeName.charAt(y) == searchInput.charAt(y)) {
                    match++;
                    if (y == (recipeName.length - 1) || y == (searchLength - 1)) {
                        if (match > bestMatchValue) {
                            bestMatchValue = match;
                            bestMatchId = x;
                        }
                    }
                } else if (recipeName.charAt(y) != searchInput.charAt(y)) {
                    if (match > bestMatchValue) {
                        bestMatchValue = match;
                        bestMatchId = x;
                    }
                    break;
                }
            }
        }
        if (bestMatchId != null) {
            suggestedRecipe = bestMatchId;
            ScrollToRecipe(bestMatchId);
            HighlightRecipe(true, bestMatchId);
            $searchResponse.html("Are you looking for " + recipesDB[bestMatchId].recipeNameDB + "?<br>" + "If so, press enter.");
            $searchResponse.css("color", "inherit");
        }

        if (searchLength > 0 && bestMatchId == null) {
            $searchResponse.html("Sorry. Your search yields no results.");
            $searchResponse.css("color", "crimson");
            suggestedRecipe = null;
        }
    } else if (e.which == 13) {             // if "enter"
        if (suggestedRecipe != null) {
            RecipeChosen(suggestedRecipe);
            recipeNum = suggestedRecipe;
            DisplayRecipe(suggestedRecipe);
            $getRecipeName.val("");
            $searchResponse.html("");
            suggestedRecipe = null;
            HighlightRecipe(false, null);
        }
    }
});

function ScrollToRecipe(index) {
    var height = $(".name-and-image").outerHeight(true);
    var width = $(".name-and-image").outerWidth(true);

    if (pageSize >= 4) {
        $("#search-wrapper").scrollTop(height * index);
    }
    else {
        $("#search-wrapper").scrollLeft(width * index);
    }
}

function HighlightRecipe(highlight, index) {
    $(".recipes-in-panel").removeClass("suggested-recipe");

    if (highlight) {
        var recipeNames = document.getElementsByClassName("recipes-in-panel");
        recipeNames[index].classList.add("suggested-recipe");
    }
}



/*****************   PRINT RECIPE   ******************************/

$("#print-recipe-button").click(function () {
    window.print();
});