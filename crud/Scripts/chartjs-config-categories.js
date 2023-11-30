var urlCategories = "/Home/GetDataCategories";
var chartRef = $("#chart-categories");
var chartRefA = $("#chart-articles");

$(document).ready(function () {
    $('select').change(function () {
        var value = $(this).val();
        if (value == 'pie') {
            chartRefA.hide();
            chartRef.show();
        }
        if (value == 'bar') {
            chartRef.hide();
            chartRefA.show();
        }
    })
});