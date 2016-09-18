var pageSize = $("#search-page-measurement").css("z-index");

/*****************  AJAX TO DATABASE ON SEARCH PAGE   ************************/


$(document).ready(function () {
    CallDatabase();
    pageSize = $("#search-page-measurement").css("z-index");
})

$(window).resize(function () {
    pageSize = $("#search-page-measurement").css("z-index");
});

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

    DisplayRecipe(0);  //make this display recipe that was displayed on home page
}

function OnError(data) {

}

function RecipesClick() {

    var index = parseInt(this.id);
    recipeNum = index;
    DisplayRecipe(index);
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



/***********************   ALIGN SEARCH SCROLL WITH SEARCH BOX   ************************/

$("#get-recipe-name").keyup(function () {
    var searchInput = $("#get-recipe-name").val().toString().toLowerCase();
    var searchLength = searchInput.length;
    var numberOfRecipes = recipesDB.length;
    var recipeNameLength;
    var bestMatchId = 0;
    var bestMatchValue = 0;

    var height = $(".name-and-image").height();
    var width = $(".name-and-image").width();
                                           
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
        if (pageSize >= 4) {
            $("#search-wrapper").scrollTop(height * bestMatchId);
        }
        else {
            $("#search-wrapper").scrollLeft(width * bestMatchId);
        }
    }
});


/*****************   PRINT RECIPE   ******************************/

$("#print-recipe-button").click(function () {
    window.print();
});