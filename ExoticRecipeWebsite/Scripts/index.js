﻿/******************   GLOBAL VARIABLES   *********************************/

var loop = false;
var timer;
$ingredients = $("#ingredients");
$recipeOfDayContainer = $("#recipe-of-day-container");



/*****************   SCROLL-BUTTON-WRAPPER POSITIONING   *******************/

function PositionScrollButtonAndAuthorWrapper() {
    $scrollButtonAndAuthorWrapper = $("#scroll-button-and-author-wrapper");

    $scrollButtonWrapper = $("#scroll-button-wrapper");
    $authorWrapper = $("#author-wrapper");
    $recipeNameContainerWrapper = $("#recipe-name-container-wrapper");

    //for semi-semi-full screen size
    if ($("#overlay").css("z-index") < 8) {
        $scrollButtonAndAuthorWrapper.append($scrollButtonWrapper);
        $scrollButtonAndAuthorWrapper.append($authorWrapper);
        $("#container-body-content").prepend($scrollButtonAndAuthorWrapper);
        $scrollButtonAndAuthorWrapper.show();
    }

    if ($("#overlay").css("z-index") == 8) {

        $recipeNameContainerWrapper.prepend($scrollButtonWrapper);
        $recipeNameContainerWrapper.append($authorWrapper);
        $scrollButtonAndAuthorWrapper.hide();
    }

    // for full screen size
    if ($("#overlay").css("z-index") >= 9) {
        $scrollButtonAndAuthorWrapper.append($scrollButtonWrapper);
        $scrollButtonAndAuthorWrapper.append($authorWrapper);
        $("#container-body-content").after($scrollButtonAndAuthorWrapper);
        $scrollButtonAndAuthorWrapper.show();
    }
}

$(window).resize(function () {
    PositionScrollButtonAndAuthorWrapper();
});

$(document).ready(function () {
    PositionScrollButtonAndAuthorWrapper();
})



/*******************   OVERLAY FOR HOMEPAGE   ******************************/

var $overlay = $("<div id='overlay'></div>");
var $caption = $("<p></p>");
var $dish_image = $("<img>");
$overlay.append($dish_image);
$overlay.append($caption);
$("#container-body-content").prepend($overlay);
$overlay.hide();

$("#recipe-image").click(function () {
    if ($("#overlay").css("z-index") >= 8) {
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

    if (!$("#pause-scroll").hasClass("activeCustom")) {
        loop = true;
    }
});

$(window).resize(function () {
    $("#overlay").hide();
});


//******************* TOOLTIP FOR RECIPE PICTURE ****************

var $tip = $("<p id='tooltip'>Click for larger view!</p>");

$("#recipe-image").hover(function () {
    if ($("#overlay").css("z-index") >= 8) {
        $("#recipe-figure").append($tip);
        $tip.fadeIn("slow");
    }
}, function () {
    $("#tooltip").remove();
}).mousemove(function (e) {
    var mousex = e.pageX - 50;
    var mousey = e.offsetY - 45;
    $("#tooltip").css({ top: mousey, left: mousex });
});




/*****************   AJAX and TIMER   **********************************************************/

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

function loopRecipes(loop) {

    var $recipeElements = $("#recipe-image,#recipe-name,#recipe-caption,#ingredients-container,#instructions-container,#author-name");

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

$("#pause-scroll").mousedown(function () {
    $("#play-scroll").removeClass("activeCustom");
    $(this).addClass("activeCustom");
    loop = false;
});

$("#play-scroll").mousedown(function () {
    $("#pause-scroll").removeClass("activeCustom");
    $(this).addClass("activeCustom");
    loop = true;
});