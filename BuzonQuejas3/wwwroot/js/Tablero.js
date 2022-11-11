$(document).ready(function () {
    //$('body').bind('cut copy paste', function (e) {
    //    e.preventDefault();
    //});

    ////Disable mouse right click
    //$("body").on("contextmenu", function (e) {
    //    return false;
    //});

    //Mostrar gráfico para total de quejas por ESTATUS
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasEstatusTotal",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawEstatus(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por UNIDAD
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasPorUnidades",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawUnidades(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por MUNICIPIO
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasPorMunicipio",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawMunicipios(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

});

function drawEstatus(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = _data[1];
    var barColor = [];

    _chartLabels.forEach(function (name) {
        barColor.push("red");
    });

    //Chart.defaults.elements.bar.backgroundColor = "red";
    //Chart.defaults.elements.bar.borderWidth = 5;

    var ctx = document.getElementById("EstatusGraph");
    const myChart = new Chart(ctx,
        {
            type: "pie",
            data: {
                labels: _chartLabels,
                datasets: [{
                    backgroundColor: ["green","red"],
                    label: 'Total de quejas',
                    data: _chartData
                }]
            },
            options: {
                plugins: {
                    title: {
                        display: true,
                        text: "Quejas por Estatus",
                        padding: {
                            top: 10,
                            bottom: 30
                        },
                        fullSize: true,
                    },
                    legend: {
                        display: true,
                        labels: {
                            // This more specific font property overrides the global property
                            font: {
                                size: 14
                            }
                        },
                        text: "holaa"

                    }
                }
            }
        });

}

function generarLetra() {
    var letras = ["a", "b", "c", "d", "e", "f", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"];
    var numero = (Math.random() * 15).toFixed(0);
    return letras[numero];
}

function colorHEX() {
    var coolor = "";
    for (var i = 0; i < 6; i++) {
        coolor = coolor + generarLetra();
    }
    return "#" + coolor;
}

function drawUnidades(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = _data[1];
    var barColor = [];

    _chartLabels.forEach(function (name) {
        barColor.push(colorHEX());
    });

    //Chart.defaults.elements.bar.backgroundColor = "green";
    //Chart.defaults.elements.bar.borderWidth = 5;

    var ctx = document.getElementById("UnidadesGraph");
    const myChart = new Chart(ctx,
        {
            type: "line",
            data: {
                labels: _chartLabels,
                datasets: [{
                    label: 'Total de quejas',
                    backgroundColor: barColor,
                    data: _chartData
                }]
            },
            options: {
                scaleShowValues: true,
                scales: {
                    x: {
                        stacked: true,
                        ticks: {
                            //autoSkip: false,
                            //maxRotation: 90,
                            //minRotation: 90,
                            font: {
                                size: 12,
                            }
                        },

                    },
                    y: {
                        min: 0,
                        max: 10,

                    }
                },
                plugins: {
                    title: {
                        display: true,
                        text: "Quejas por Unidad Administrativa",
                        padding: {
                            top: 10,
                            bottom: 30
                        },
                        fullSize: true,
                    },
                    legend: {
                        display: true,
                        labels: {
                            // This more specific font property overrides the global property
                            font: {
                                size: 14
                            }
                        },
                        text: "holaa"

                    }
                }
            }
        });

}

//Gráfico para quejas por MUNICIPIO
function drawMunicipios(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = _data[1];
    var barColor = [];

    console.log("labels: " + _chartLabels.length);
    console.log("data: " + _chartData.length);

    _chartLabels.forEach(function (name) {
        barColor.push("yellow");
    });

    //Chart.defaults.elements.bar.backgroundColor = "green";
    //Chart.defaults.elements.bar.borderWidth = 5;
    //Chart.defaults.scales.linear.min = 0;
    //Chart.defaults.scales.linear.max = 990;

    var ctx = document.getElementById("MunicipiosGraph");
    const myChart = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [{
                    label: 'Total de quejas',
                    backgroundColor: barColor,
                    data: _chartData
                }]
            },
            responsive: true,
            options: {
                scaleShowValues: true,
                scales: {
                    x: {
                        stacked: true,
                        ticks: {
                          //autoSkip: false,
                            maxRotation: 90,
                            minRotation: 90,
                            font: {
                                size: 12,
                            }
                        },

                    },
                    y: {
                        min: 0,
                        max: 50,
                        
                    }
                    //yAxes: [{
                    //    ticks: {
                    //        beginAtZero: true
                    //    }
                    //}],
                    //xAxes: [{
                    //    ticks: {
                    //        autoSkip: false,
                    //        maxRotation: 90,
                    //        minRotation: 90
                    //    },
                    //    barPercentage: 0.1
                    //}]
                },
                //indexAxis: 'y',
                plugins: {
                    title: {
                        display: true,
                        text: "Quejas por Municipios",
                        padding: {
                            top: 10,
                            bottom: 30
                        },
                        fullSize: true,
                    },
                    legend: {
                        display: true,
                        labels: {
                            // This more specific font property overrides the global property
                            font: {
                                size: 14
                            }
                        },
                        text: "holaa"

                    }
                }
            }
        });

}
