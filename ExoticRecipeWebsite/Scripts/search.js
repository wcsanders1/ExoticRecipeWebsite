/*****************  AJAX TO DATABASE ON SEARCH PAGE   ************************/

var recipesDB;

$("#btn-load-data").click(function () {
    $.ajax({
        type: "GET",
        url: searchUrl,
        data: "{}",
        dataType: "json",
        success: OnSuccess,
        error: OnError
    });
});

function OnSuccess(data) {
    var content = "";
    recipesDB = data;
    for (var i = 0; i < data.length; i++) {
        content += "<p class='recipes-in-panel' id=" + data[i].recipeOrderDB + ">" + data[i].recipeNameDB + "</p>";
    }
    $("#recipe-panel").html("");
    $("#recipe-panel").html(content);

    var recipesInPanel = document.getElementsByClassName("recipes-in-panel");

    for (var i = 0; i < recipesInPanel.length; i++) {
        recipesInPanel[i].onclick = recipesClick;
    }
}

function OnError(data) {

}

function recipesClick() {
    var index = parseInt(this.id);
    var contentDescription = "";
    var contentInstructions = "";
    var instruction = 1;

    contentDescription = "<p>" + recipesDB[index].recipeDescriptionDB + "</p>";
    $("#recipe-description").html("");
    $("#recipe-description").html(contentDescription);


    var parseContent = JSON.parse(recipesDB[index].recipeInstructionsDB);

    for (i in parseContent)
    {      
        var index = instruction.toString();
        contentInstructions += "<p>" + i + ". " + parseContent[index] + "</p>";
        instruction++;
    }

    $("#recipe-instructions").html("");
    $("#recipe-instructions").html(contentInstructions);

}