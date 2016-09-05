/*****************  AJAX TO DATABASE ON SEARCH PAGE   ************************/

var recipesDB;

function CallDatabase() {
    $.ajax({
        type: "GET",
        url: searchUrl,
        data: "{}",
        dataType: "json",
        success: OnSuccess,
        error: OnError
    });
}

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
    var imageText;

    recipesDB = data.sort(function (a, b) { return a.recipeNameDB.localeCompare(b.recipeNameDB); });

    for (var i = 0; i < recipesDB.length; i++) {
        content += "<p class='recipes-in-panel' id=" + i + ">" + recipesDB[i].recipeNameDB + "</p>";
    }
    $("#recipe-panel").html("");
    $("#recipe-panel").html(content);

    var recipesInPanel = document.getElementsByClassName("recipes-in-panel");

    for (var i = 0; i < recipesInPanel.length; i++) {
        recipesInPanel[i].onclick = recipesClick;
    }

    $("#search-wrapper").empty();

    for (var i = 0; i < recipesDB.length; i++) {
        imageText = recipesDB[i].recipeImageDB;
        $images[i] = $("<div class='search-image'></div>");
        $images[i].css("background", "url(" + imageText + ") center no-repeat");
        $images[i].css("background-size", "cover");
        $("#search-wrapper").append($images[i]);
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