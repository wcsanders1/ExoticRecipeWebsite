function SizeForIE() {

    var ua = window.navigator.userAgent;
    var msie = ua.indexOf("MSIE ");

    console.log(msie);

    if (/MSIE 10/i.test(navigator.userAgent)) {   //doesn't work

        //position container body content

        $containerBodyContent = $("#container-body-content");

        var spaceBetweenHeaderAndFooter = $("footer").position().top - ($("header").position().top + $("header").height());

        console.log(spaceBetweenHeaderAndFooter);
        $containerBodyContent.css("margin-top", (spaceBetweenHeaderAndFooter / 2));
    }
}

$(document).ready(function () {
    SizeForIE();
});