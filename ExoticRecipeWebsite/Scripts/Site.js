/*************************   COMMON VARIABLES   *************************************/

var recipesDB;
var recipeNum = 0;


/*************************   COMMON FUNCTIONS   *************************************/

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

$(document).ready(function () {
    if (page == "index") {
        console.log("index");
        $("#index").addClass("active-nav-list-item");
    } else if (page == "search") {
        $("#search").addClass("active-nav-list-item");
    } else if (page == "contact") {
        $("#contact").addClass("active-nav-list-item");
    }
});