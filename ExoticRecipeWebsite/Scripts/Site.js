/******************   COMMON VARIABLES   *********************************/

var loop = false;
var timer;
var initialServingSize = $("#serving-size").val();
var priorServingSize = initialServingSize;             //parseFloat(document.getElementById("serving-size").value);
$ingredients = $("#ingredients");
$recipeOfDayContainer = $("#recipe-of-day-container");


/*****************   SCROLL-BUTTON-WRAPPER POSITIONING   *******************/

function PositionScrollButtonAndAuthorWrapper() {
    $scrollButtonAndAuthorWrapper = $("#scroll-button-and-author-wrapper");
    $recipeImage = $("#recipe-image");
    $recipeImagePosition = $recipeImage.offset();

    //for semi-semi-full screen size
    if ($("#overlay").css("z-index") == 8) {
        var ingredientsWidth = $ingredients.outerWidth();
        var rightPosition = $recipeImagePosition.left;
        var thisWidth = rightPosition - ingredientsWidth;

        console.log(thisWidth);

        $recipeOfDayContainer.append($scrollButtonAndAuthorWrapper);
        $scrollButtonAndAuthorWrapper.offset({ left: ingredientsWidth });
        $scrollButtonAndAuthorWrapper.outerWidth(thisWidth);
    }

    // for full and semi-full screen size
    if ($("#overlay").css("z-index") >= 9) {
        console.log("resizing");
        $recipeOfDayContainer.after($scrollButtonAndAuthorWrapper);
    }
}

$(window).resize(function () {
    PositionScrollButtonAndAuthorWrapper();
    //PositionInstructions();
});

$(document).ready(function () {
    PositionScrollButtonAndAuthorWrapper();
    //PositionInstructions();
})



/*******************   INSTRUCTIONS POSITIONING   ***************************/

function PositionInstructions() {
    $instructions = $("#instructions");

    if ($("#overlay").css("z-index") == 8) {
        $recipeOfDayContainer.after($instructions);
    }
}


/*******************   OVERLAY FOR HOMEPAGE   ******************************/

var $overlay = $("<div id='overlay'></div>");
var $caption = $("<p></p>");
var $dish_image = $("<img>");
$overlay.append($dish_image);
$overlay.append($caption);
$(".container-body-content").prepend($overlay);
$overlay.hide();

$(".recipe-of-day-figure img").click(function () {
    if ($("#overlay").css("z-index") == 10) {
        loop = false;
        var imageLocation = $(this).attr("src");
        $dish_image.attr("src", imageLocation);
        $overlay.slideDown();
        var captionText = $(".title").text();
        $caption.text(captionText);
    }
});

$overlay.click(function () {
    $(this).slideUp();
    loop = true;
});

$(window).resize(function () {
    $("#overlay").hide();
});


//******************* TOOLTIP FOR RECIPE PICTURE ****************

var $tip = $("<p class='tooltip'>Click for larger view!</p>");

$(".recipe-of-day-figure img").hover(function () {
    if ($("#overlay").css("z-index") == 10) {
        $(".recipe-of-day-figure").append($tip);
        $tip.fadeIn("slow");
    }
}, function () {
    $(".tooltip").remove();
}).mousemove(function (e) {
    var mousex = e.pageX - 50;
    var mousey = e.offsetY - 45;
    $(".tooltip").css({ top: mousey, left: mousex });
});




//*********************   MAKING THE 'SUBMIT' BUTTON WORK FOR THE INGRDIENTS  *****************************

var numericalAmounts = document.getElementsByClassName("numerical-amounts");
var newIngredientAmount = 0;
var newServingSize = 0;
var priorIngredientAmount = 0;
var newIngredientAmount = 0;

$("#ingredient-button").click(function () {
    newServingSize = parseFloat(document.getElementById("serving-size").value);

    for (var i = 0; i < numericalAmounts.length; i++) {
        priorIngredientAmount = parseFloat(numericalAmounts[i].innerText);

        if (priorIngredientAmount > 0) {
            newIngredientAmount = (priorIngredientAmount / priorServingSize) * newServingSize;
            newIngredientAmount = Math.round(newIngredientAmount * 100) / 100;
            numericalAmounts[i].innerText = newIngredientAmount;
        }
    }

    priorServingSize = newServingSize;
});

/***********************   LOADING RECIPES  **********************************/

var recipesDB;
var recipeNum = 0;

function CallDatabase() {
    $.ajax({
        async: false,
        type: "GET",
        url: searchUrl,
        data: "{}",
        dataType: "json",
        success: OnSuccess,
        error: OnError
    });
}

function OnSuccess(data) {
    recipesDB = data.sort(function (a, b) { return a.recipeNameDB.localeCompare(b.recipeNameDB); });
}

function OnError(data) {

}

function GetRandomRecipe(length) {
    var min = 0;
    var max = Math.floor(length);
    return Math.floor(Math.random() * (max - min));
}

$(document).ready(function () {
    
    CallDatabase();

    recipeNum = GetRandomRecipe(recipesDB.length);

    SetRecipe(recipeNum);

    loop = true;
    timer = setInterval(function () { loopRecipes(loop); }, 7000);

    $("#play-scroll").addClass("scroll-button-highlight");
});

function resetTimer() {
    clearInterval(timer);
    timer = setInterval(function () { loopRecipes(loop); }, 7000);
}

var $recipeElements = $("#recipe-image,#recipe-name,#recipe-caption,#ingredients-container,#instructions-container");

function SetRecipe(recipe) {
    $("#serving-size").val(initialServingSize);
    priorServingSize = initialServingSize;

    var $recipeImage = $("#recipe-image");
    var $recipeName = $("#recipe-name");
    var $recipeCaption = $("#recipe-caption");
    var $ingredientsContainer = $("#ingredients-container");
    var $instructionsContainer = $("#instructions-container");

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

    $recipeImage.attr("src", recipeImage);
    $recipeName.text(recipeName);
    $recipeCaption.text(recipeCaption);

    $ingredientsContainer.empty();

    for (i in recipeIngredients) {
        ingredientsContent += "<div class='ingredient-lists-container'><div class='ingredient-names-list'><ul><li>";
        ingredientsContent += recipeIngredients[i].Ingredient;
        ingredientsContent += ": </li></ul></div><div class='ingredient-amounts-list'><ul id='ingredient-amounts'><li class='numerical-amounts'>";
        ingredientsContent += recipeIngredients[i].Amount;
        ingredientsContent += " </li><li class='amount-labels'>";
        ingredientsContent += recipeIngredients[i].Measurement;
        ingredientsContent += "</li></ul></div></div>";
    }

    $ingredientsContainer.html(ingredientsContent);

    $instructionsContainer.empty();

    for (i in recipeInstructions) {
        instructionsContent += "<li>" + recipeInstructions[i] + "</li>";
    }

    $instructionsContainer.html(instructionsContent);
}



/****************************   BROWSE RECIPE BUTTONS   *********************************/

$("#scroll-button-back").click(function () {
    recipeNum--;
    resetTimer();

    if (recipeNum < 0) {
        recipeNum = recipesDB.length - 1;
    }

    SetRecipe(recipeNum);
});

$("#scroll-button-forward").click(function () {
    recipeNum++;
    resetTimer();

    if (recipeNum >= recipesDB.length) {
        recipeNum = 0;
    }

    SetRecipe(recipeNum);
});

$("#pause-scroll").click(function () {
    $("#play-scroll").removeClass("scroll-button-highlight");
    $(this).addClass("scroll-button-highlight");
    loop = false;
});

$("#play-scroll").click(function () {
    $("#pause-scroll").removeClass("scroll-button-highlight");
    $(this).addClass("scroll-button-highlight");
    loop = true;
});



/****************************   ITERATE RECIPES ON TIMER   ******************************/

function loopRecipes(loop) {
    
    var $ingredientButton = $("#ingredient-button");

    if (loop) {
        $ingredientButton.prop("disabled", true);
        recipeNum++;

        $recipeElements.fadeOut("slow", function () {
            if (recipeNum >= recipesDB.length) {
                recipeNum = 0;
            }

            $recipeElements.empty();
            SetRecipe(recipeNum);
            $recipeElements.fadeIn("slow");
            $ingredientButton.prop("disabled", false);
        });
     }
}