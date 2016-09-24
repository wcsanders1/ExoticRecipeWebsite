/*************************   GLOBAL VARIABLES   *************************************/

var recipesDB;
var recipeNum = 0;
var INITIAL_SERVING_SIZE = 4;


/*************************   COMMON FUNCTIONS   *************************************/


function CallDatabase() {
    $.ajax({
        async: false,
        type: "GET",
        url: searchUrl,      // searchUrl set in cshtml
        data: "{}",
        dataType: "json",
        success: OnSuccess,
        error: OnError
    });
}

$(document).ready(function () {
    if (page == "index") {
        $("#index").addClass("active-nav-list-item");
    } else if (page == "search") {
        $("#search").addClass("active-nav-list-item");
    } else if (page == "contact") {
        $("#contact").addClass("active-nav-list-item");
    }
});


/*******************************   FILLS THE INGREDIENTS, PICTURE, AND INSTRUCTIONS BOXES WITH RECIPE   ********************************/

function SetRecipe(recipe) {
    $("#serving-size").val(INITIAL_SERVING_SIZE);

    var $recipeImage = $("#recipe-image");
    var $recipeName = $("#recipe-name");
    var $recipeCaption = $("#recipe-caption");
    var $ingredientsContainer = $("#ingredients-container");
    var $instructionsContainer = $("#instructions-container");
    var $authorContainer = $("#author-name");

    var instruction = 1;
    var ingredientsInstruction = 1;
    var ingredientsInstructionIndex;
    var instructionIndex;
    var ingredientsContent = "";
    var instructionsContent = "";

    var recipeImage = recipesDB[recipe].recipeImageDB;
    var recipeName = recipesDB[recipe].recipeNameDB;
    var recipeCaption = recipesDB[recipe].recipeDescriptionDB;
    var recipeIngredients = JSON.parse(recipesDB[recipe].recipeIngredientsDB);
    var recipeInstructions = JSON.parse(recipesDB[recipe].recipeInstructionsDB);
    var recipeAuthor = recipesDB[recipe].recipeAuthorDB;

    $recipeImage.attr("src", recipeImage);
    $recipeName.text(recipeName);
    $recipeCaption.text(recipeCaption);
    ingredientsContent = IngredientsContent(recipe);
    $ingredientsContainer.html(ingredientsContent);
    instructionsContent = InstructionsContent(recipe);
    $instructionsContainer.html(instructionsContent);
    $authorContainer.text(recipeAuthor);
}


/********************   RETURNS CONTENT OF INGREDIENTS CONTAINER   ***********************************/

function IngredientsContent(recipe) {

    var recipeIngredients = JSON.parse(recipesDB[recipe].recipeIngredientsDB);
    var ingredientsContent = "";

    for (i in recipeIngredients) {
        ingredientsContent += "<div class='ingredient-lists-container'><div class='ingredient-names-list'><ul><li>";
        ingredientsContent += recipeIngredients[i].Ingredient;
        ingredientsContent += ": </li></ul></div><div class='ingredient-amounts-list'><ul id='ingredient-amounts'><li class='numerical-amounts'>";
        ingredientsContent += recipeIngredients[i].Amount;
        ingredientsContent += " </li><li class='amount-labels'>";

        if (parseInt(recipeIngredients[i].Amount) == 1) {
            ingredientsContent += recipeIngredients[i].SingularMeasurement;
        } else {
            ingredientsContent += recipeIngredients[i].PluralMeasurement;
        }

        ingredientsContent += "</li></ul></div></div><ul><li class='ingredient-borders'></li></ul>";
    }

    return ingredientsContent;
}


/******************   RETURNS CONTENT OF INSTRUCTIONS CONTAINER   ****************/

function InstructionsContent(recipe) {
    var recipeInstructions = JSON.parse(recipesDB[recipe].recipeInstructionsDB);
    var instructionsContent = "";

    for (i in recipeInstructions) {
        instructionsContent += "<li>" + recipeInstructions[i] + "</li>";
    }
    
    return instructionsContent;
}


/**********************   MAKING INGREDIENT LABEL ACCEPT ONLY INTS BETWEEN 1 AND 20   ****************************/
$servingSize = $("#serving-size");

$servingSize.keypress(function (e) {
   
    if ($servingSize.val().length > 2 || e.which < 48 || e.which > 57) {
        return false;
    }
});

$servingSize.keyup(function () {
    if ($servingSize.val() > 20) {
        $servingSize.val(20);
    }
});

//*********************   MAKING THE INGREDIENT BUTTON CALCULATE INGREDIENT AMOUNTS  *****************************


$("#ingredient-button").click(function () {
    var numericalAmounts = document.getElementsByClassName("numerical-amounts");
    var amountLabels = document.getElementsByClassName("amount-labels");
    var newIngredientAmount = 0;
    var newServingSize = 0;
    var initialAmount;
    var singleServingSize;

    if ($servingSize.val() == "" || parseInt($servingSize.val()) == 0) {
        $servingSize.val(4);
    }

    newServingSize = parseInt($servingSize.val());
    var recipeIngredientsCalculate = JSON.parse(recipesDB[recipeNum].recipeIngredientsDB);

    for (var i = 0; i < numericalAmounts.length; i++) {
        initialAmount = parseFloat(recipeIngredientsCalculate[i].Amount);

        if (initialAmount > 0) {
            singleServingSize = initialAmount / INITIAL_SERVING_SIZE;
            newIngredientAmount = singleServingSize * newServingSize;
            newIngredientAmount = Math.round(newIngredientAmount * 100) / 100;
            numericalAmounts[i].innerText = newIngredientAmount;

            if (newIngredientAmount == 1) {
                amountLabels[i].innerText = recipeIngredientsCalculate[i].SingularMeasurement;
            } else {
                amountLabels[i].innerText = recipeIngredientsCalculate[i].PluralMeasurement;
            }
        }
    }
});