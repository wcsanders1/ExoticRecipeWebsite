var $overlay = $("<div id='overlay'></div>");
var $caption = $("<p></p>");
var $dish_image = $("<img>");
$overlay.append($dish_image);
$overlay.append($caption);
$(".container-body-content").prepend($overlay);
$overlay.hide();

$(".recipe-of-day-figure img").click(function () {
    if ($("#overlay").css("z-index") == 10) {
        var imageLocation = $(this).attr("src");
        $dish_image.attr("src", imageLocation);
        $overlay.slideDown();
        var captionText = $(".title").text();
        $caption.text(captionText);
    }
});

$overlay.click(function () {
    $(this).hide();
})

$(window).resize(function () {
    $("#overlay").hide();
});