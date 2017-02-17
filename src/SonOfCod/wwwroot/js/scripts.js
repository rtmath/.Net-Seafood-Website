$(document).ready(function () {
    $('#admin-tab')
        .mouseenter(function () {
            $('.subnav').show();
        })
        .mouseleave(function () {
            $('.subnav').hide();
        });

    $('.subnav')
    .mouseenter(function () {
        $('.subnav').show();
    })
    .mouseleave(function () {
        $('.subnav').hide();
    });
})