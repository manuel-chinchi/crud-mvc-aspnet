var _chart; // debe ser global para poder volver a instanciar sin causar problemas
var _chart2;

// ejemplos
// https://codepen.io/chartjs/pen/YVWZbz

$(document).ready(function () {
    //btnChart.on('click', function () {
        $.ajax({
            type: "POST",
            url: urlCategories,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (_data) {
                var dataLabels = [];
                var dataContent = [];

                for (var i = 0; i < _data.length; i++) {
                    dataLabels.push(_data[i].name);
                    dataContent.push(_data[i].quantity);
                }

                if (_chart) {
                    _chart.destroy();
                }

                // pie chart
                _chart = new Chart(chartRef, {
                    type: 'pie',
                    data: {
                        labels: dataLabels,
                        datasets: [{
                            data: dataContent,
                            backgroundColor: ['#007bff', '#dc3545', '#ffc107', '#28a745'],
                        }],
                    },
                    options: {
                        /*responsive: true,*/
                        //maintainAspectRatio: false,

                        //responsive: true,
                        /*maintainAspectRatio: true,*/

                    }
                });

                // bar chart
                _chart2 = new Chart(chartRefA, {
                    type: 'bar',
                    data: {
                        labels: dataLabels,
                        datasets: [{
                            data: dataContent,
                            backgroundColor: ['#007bff', '#dc3545', '#ffc107', '#28a745'],
                        }],
                        borderWidth: 1
                    },
                    options: {
                        scales: {
                            y: {beginAtZero: true}
                        },
                        maintainAspectRatio: false
                    },
                });


            },
            error: function (error) {
                console.log(error);
            }
        });
});

