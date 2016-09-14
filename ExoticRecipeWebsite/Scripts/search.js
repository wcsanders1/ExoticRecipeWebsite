/*****************  AJAX TO DATABASE ON SEARCH PAGE   ************************/

$("#btn-load-data").click(function () {
    CallDatabase();
});

$(document).ready(function () {
    CallDatabase();
})

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

        $names[i] = $("<div id='name-and-image-" + i + "' class='name-and-image'><p class='recipes-in-panel'>" + recipeName + "</p>");
        $images[i] = $("<div class='search-image'></div></div>");               
        $images[i].css("background", "url(" + imageText + ") center no-repeat");
        $images[i].css("background-size", "cover");
        $names[i].append($images[i]);
        $("#search-wrapper").append($names[i]);
    }
}

function OnError(data) {

}

function recipesClick() {
    var index = parseInt(this.id);
    var instructionIndex;
    var ingredientsInstructionIndex;
    var contentDescription = "";
    var contentInstructions = "";
    var contentIngredients = "";
    var instruction = 1;
    var ingredientsInstruction = 1;

    contentDescription = "<p>" + recipesDB[index].recipeDescriptionDB + "</p>";
    $("#recipe-description").html("");
    $("#recipe-description").html(contentDescription);


    var parseContent = JSON.parse(recipesDB[index].recipeInstructionsDB);

    for (i in parseContent)
    {      
        instructionIndex = instruction.toString();
        contentInstructions += "<p>" + i + ". " + parseContent[instructionIndex] + "</p>";
        instruction++;
    }

    $("#recipe-instructions").html("");
    $("#recipe-instructions").html(contentInstructions);

    var imageText = recipesDB[index].recipeImageDB;

    if (imageText != null) {
        $("#image-text").css("background", "url(" + imageText + ") center no-repeat");
        $("#image-text").css("background-size", "cover");
        $("#image-text").show();
    } else {
        $("#image-text").hide();
    }

    var parseIngredients = JSON.parse(recipesDB[index].recipeIngredientsDB);
    var parseEachIngredient;

    for (i in parseIngredients)
    {
        ingredientsInstructionIndex = ingredientsInstruction.toString();
        contentIngredients += "<p>" + ingredientsInstruction + ". " +
            parseIngredients[i].Ingredient + ": " +
            parseIngredients[i].Amount + " " +
            parseIngredients[i].Measurement + "</p>";

        ingredientsInstruction++;
    }

    $("#ingredient-list-search").html("");
    $("#ingredient-list-search").html(contentIngredients);
}

/************************   POSITION SEARCH WRAPPER ON FULL-SIZE PAGE   *********************************************/

//function PositionSearchWrapper() {

//    if ($("#search-page-measurement").css("z-index") == 3) {
//        $containerBodyContent = $("#container-body-content");
//        $searchWrapper = $("#search-wrapper");
        
//        $searchWrapper.height(0);
//        var searchWrapperHeight = $containerBodyContent.height() * .9;
//        console.log("height is:" + searchWrapperHeight);
//        $searchWrapper.height(searchWrapperHeight);
//    }
//}

$(window).resize(function () {
    //PositionSearchWrapper();
});

$(document).ready(function () {
    //PositionSearchWrapper();
})