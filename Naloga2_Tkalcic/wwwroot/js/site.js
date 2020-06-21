// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log("Ready");
});

    $(function () {
        $("#accordion").accordion();
    });

    $(function () {
        $("#datepicker").datepicker({
            changeMonth: true,
            changeYear: true,
            dateFormat: 'dd-mm-yy'
        }).val();
        });
/*$(function () {
$("#datepicker").datepicker({ dateFormat: 'dd-mm-yy' }).val();
});*/

$(document).ready(function () {
    $(".slider").each(function () {
        $(".slider-range").slider({
            range: true,
            min: 0,
            max: 100,
            values: [1, 100],
            slide: function (event, ui) {
                $(this).parent().find(".amount").val(ui.values[0]);
            }
        });
    });
});;


    $(function () {
        $("#tabs").tabs();
    });