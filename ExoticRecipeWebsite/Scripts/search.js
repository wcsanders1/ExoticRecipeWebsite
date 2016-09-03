/*****************  AJAX TO DATABASE ON SEARCH PAGE   ************************/

$("#btn-load-data").click(function () {
    console.log("this is clicking");
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
    var content;
    for (var i = 0; i < data.length; i++) {
        content += "<p>" + data[i].recipeNameDB + "</p>";
    }
    $("#update-panel").html(content);
}

function OnError(data) {

}