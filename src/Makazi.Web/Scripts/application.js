var scrollOffset = 0;

function bindButtons() {

    var buttons = $('button');
    var viewport = $('.viewport');

    buttons.click(function () {
        scrollOffset += 275;
        viewport.animate({scrollTop: scrollOffset}, 'slow');
    });
}


$(document).ready(bindButtons);