$(function () {
    $(".play").click(function () {
        var src = $(this).attr('data-content');
        if (src != undefined) {           
            document.getElementById('perra').setAttribute('scr', 'www.google.com');
        }
    });
});