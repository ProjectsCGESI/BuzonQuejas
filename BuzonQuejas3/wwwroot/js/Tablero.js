
$(document).ready(function () {
    //Mostrar gráfico para total de quejas por ESTATUS
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasEstatusTotal",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            var totales = data[1];
            drawEstatus(data);
            $("#totalAtendidas").html(totales[0]);
            $("#totalPendientes").html(totales[1]);
            $("#totalQuejas").html(totales[2]);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por ESTATUS diario
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasEstatusDiario",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawEstatusDiario(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por ESTATUS Anual
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasEstatusAnual",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawQuejasAnual(data);
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

    //Mostrar gráfico para total de quejas por Medio de recepción
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasMedio",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawMedios(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total pendiente y atendido de quejas por unidad administrativa
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasEstatusPorUnidades",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawEstatusUnidades(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total por departamento 
    $.ajax({
        type: 'POST',
        url: "/Queja/GetQuejasPorDepartamento",
        dataType: "json",
        data: "",
        contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawDepartamentos(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

});

function drawEstatus(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = [];

    _data[1].forEach(function (value, index) {
        if (index != _data[1].length - 1)
            _chartData.push(value);
    });

    var ctx = document.getElementById("EstatusGraph");
    const myChart = new Chart(ctx,
        {
            type: "doughnut",
            data: {
                labels: _chartLabels,
                datasets: [{
                    backgroundColor: ["green", "red"],
                    label: 'Total de quejas',
                    data: _chartData
                }]
            },
            options: {
                plugins: {
                    legend: {
                        display: true,
                        labels: {
                            font: {
                                size: 14
                            }
                        },
                    }
                }
            }
        });

}

function drawEstatusDiario(data) {
    var _data = data;
    var _dataVal = data[1];
    var _chartLabels = _data[0];
    var _chartDataA = _dataVal[0];
    var _chartDataP = _dataVal[1];
    var _chartDataT = _dataVal[2];

    console.log(_chartDataA);


    var ctx = document.getElementById("EstatusDiarioGraph");
    const myChart = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                    backgroundColor: ["Blue","green","red"],
                    label: 'Quejas',
                        data: [_chartDataT, _chartDataA, _chartDataP]
                    },
                ]
            },
            options: {
                scales: {
                    y: {
                        ticks: {
                            beginAtZero: true,
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    }
                },
                plugins: {
                    legend: {
                        display: true,
                        labels: {
                            font: {
                                size: 14
                            }
                        },
                    }
                }
            }
        });

}

function scrollUnidadesHandle(ev) {
    let classNm = ev.currentTarget.className;

    if (ev.deltaY < 0) //scroll-up
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 20);
    } else if (ev.deltaY > 0)//scroll-down 
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 20);
    }
}

function drawUnidades(data) {

    var _data = data;
    var _chartLabels = [];
    var _chartData = [];

    _data[0].forEach(function (label, index) {
        const palabras = label.split(" ");
        palabras.join(" ");
        _chartLabels.push(palabras);

    });

    _data[1].forEach(function (total,index) {
        _chartData.push(total);
        var newwidth = $('.chartAreaWrapper2Unidad').width() + 20;
        $('.chartAreaWrapper2Unidad').width(newwidth);
    });

    var ctx = document.getElementById("UnidadesGraph").getContext("2d");
    const myChart = new Chart(ctx,
        {
            type: "line",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Número de quejas',
                        backgroundColor: "rgb(255, 255, 51,0.1)",
                        borderColor: "#cccc00",
                        toolTipOrder: 3,
                        fill:true,
                        data: _chartData,
                        yAxisID: "y",
                        barThickness: 15,
                    }
                ]
            },
            options: {
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            maxRotation: 0,
                            //minRotation: 20,
                            font: {
                                size: 9,
                            },
                        }
                    },
                    y: {
                        position: "left",
                        min: 0,
                        grid: {
                            display: true
                        },
                        ticks: {
                            beginAtZero: true,
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        //labels: {
                        //    filter: (l) => (l.text !== 'Eff')
                        //}

                    },
                }
            }
        });

}

function scrollMunicipiosHandle(ev) {
    let classNm = ev.currentTarget.className;

    if (ev.deltaY < 0) //scroll-up
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 20);
    } else if (ev.deltaY > 0)//scroll-down 
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 20);
    }
}

//Gráfico para quejas por MUNICIPIO
function drawMunicipios(data) {
    var _data = data;
    var _chartLabels = [];
    var _chartData = [];

    _data[0].forEach(function (label,index) {
        const palabras = label.split(" ");

        for (let i = 0; i < palabras.length; i++) {
            var subPalabra = palabras[i].substr(1);
            var subPalabraLower = subPalabra.toLowerCase();
            palabras[i] = palabras[i][0].toUpperCase() + subPalabraLower;
        }

        const nueva = palabras.join(" ");
        _chartLabels.push(nueva);

    });

    _data[1].forEach(function (total, index) {
        _chartData.push(total);
        var newwidth = $('.chartAreaWrapper2Municipio').width() + 10;
        $('.chartAreaWrapper2Municipio').width(newwidth);

    });

    var ctx = document.getElementById("MunicipiosGraph").getContext("2d");
    const myChart = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Total de quejas',
                        backgroundColor: "yellow",
                        borderColor: "#F3BC00",
                        toolTipOrder: 3,
                        data: _chartData,
                        yAxisID: "y",
                        barThickness: 15,
                    },
                    {
                        label: "Eff",
                        type: "line",
                        fill: true,
                        data: _chartData,
                        stepped: "middle"
                    }
                ]
            },
            options: {
                maxBarThickness: 55,
                clip: true,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    }
                },
                scales: {
                    x: {
                        grid: {
                            display: false
                        },
                        ticks: {
                            autoSkip: false,
                            maxRotation: 90,
                            font: {
                                size: 12,
                            }
                        }
                    },
                    y: {
                        position: "left",
                        precision: 0,
                        min: 0,
                        grid: {
                            display: true
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        labels: {
                            filter: (l) => (l.text !== 'Eff')
                        }

                    },
                }
            }
        });

}

function drawMedios(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = _data[1];

    var ctx = document.getElementById("MediosGraph");
    const myChart = new Chart(ctx,
        {
            type: "radar",
            data: {
                labels: _chartLabels,
                datasets: [{
                    backgroundColor: "#82bc0000",
                    borderColor: 'rgb(54, 162, 235)',
                    label: 'Quejas recibidas',
                    data: _chartData
                }]
            },
            options: {
                //maxBarThickness: 55,
                //clip: true,
                //layout: {
                //    padding: {
                //        bottom: 50,
                //        left: 50,
                //    }
                //},
                maintainAspectRatio: false,
                scales: {
                    r: {
                        //min: 0,
                        //max: 5,
                        precision: 0,
                        beginAtZero: true,
                        angleLines: {
                            color: "red",
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    },
                },
                plugins: {
                    
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true

                    },
                }
            }
        });

}

function scrollEstatusUnidadesHandle(ev) {
    let classNm = ev.currentTarget.className;

    if (ev.deltaY < 0) //scroll-up
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 20);
    } else if (ev.deltaY > 0)//scroll-down 
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 20);
    }
}


function drawEstatusUnidades(data) {

    var _data = data;
    var _chartLabels = [];
    var _chartDataA = [];
    var _chartDataP = [];

    console.log(_data[0]);
    console.log(_data[1]);
    console.log(_data[2]);

    _data[0].forEach(function (label, index) {
        const palabras = label.split(" ");
        palabras.join(" ");
        _chartLabels.push(palabras);

    });

    _data[1].forEach(function (total,index) {
        _chartDataA.push(total);
        var newwidth = $('.chartAreaWrapper2EstatusUnidad').width() + 20;
        $('.chartAreaWrapper2EstatusUnidad').width(newwidth);

    });

    _data[2].forEach(function (total) {
        _chartDataP.push(total);
    });

    var ctx = document.getElementById("EstatusUnidadesGraph").getContext("2d");
    const myChart = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Atendidas',
                        backgroundColor: "green",
                        borderColor: "green",
                        toolTipOrder: 3,
                        data: _chartDataA,
                        yAxisID: "y",
                        //barPercentage: 0.1,
                        barThickness: 15,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                    {
                        label: 'Pendientes',
                        backgroundColor: "red",
                        borderColor: "red",
                        toolTipOrder: 3,
                        data: _chartDataP,
                        yAxisID: "y",
                        //barPercentage: 0.1,
                        barThickness: 15,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                ]
            },
            options: {
                maintainAspectRatio: false,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            maxRotation: 0,
                            //minRotation: 30,
                            font: {
                                size: 9,
                            },
                        },
                        stacked: true,
                    },
                    y: {
                        position: "left",
                        beginAtZero: true,
                        min: 0,
                        grid: {
                            display: true
                        },
                        stacked: true,
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    }
                },
                plugins: {
                    //tooltip: {
                    //    itemSort: function (a, b) {
                    //        if (a.dataset.toolTipOrder > b.dataset.toolTipOrder) return 1;
                    //        else return -1;
                    //    }
                    //},
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true

                    },
                }
            }
        });

}

function scrollDepartamentosHandle(ev) {
    let classNm = ev.currentTarget.className;

    if (ev.deltaY < 0) //scroll-up
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 20);
    } else if (ev.deltaY > 0)//scroll-down 
    {
        $(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 20);
    }
}


function drawDepartamentos(data) {

    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = [];

    _data[1].forEach(function (total) {
        _chartData.push(total);
        //var newHeight = $('.chartAreaWrapper2Dpto').height() + 40;
        //$('.chartAreaWrapper2Dpto').height(newHeight);

    });

    var ctx = document.getElementById("DepartamentosGraph").getContext("2d");
    const myChart = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Quejas registradas',
                        backgroundColor: "green",
                        borderColor: "green",
                        toolTipOrder: 3,
                        data: _chartData,
                        yAxisID: "y",
                        //barPercentage: 0.1,
                        barThickness: 15,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                ]
            },
            options: {
                indexAxis: 'y',
                maintainAspectRatio: false,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 50,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            //maxRotation: 90,
                            //minRotation: 30,
                            font: {
                                size: 10,
                            },
                        },
                        stacked: true,
                    },
                    y: {
                        position: "left",
                        beginAtZero: true,
                        min: 0,
                        grid: {
                            display: true
                        },
                        stacked: true,
                    }
                },
                plugins: {
                    //tooltip: {
                    //    itemSort: function (a, b) {
                    //        if (a.dataset.toolTipOrder > b.dataset.toolTipOrder) return 1;
                    //        else return -1;
                    //    }
                    //},
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true

                    },
                }
            }
        });

}

function drawQuejasAnual(data) {

    var _data = data;
    var _chartLabels = _data[0];
    var _chartDataA = _data[1];
    var _chartDataP = _data[2];

    //_data[1].forEach(function (total, index) {
    //    _chartData.push(total);
    //    var newwidth = $('.chartAreaWrapper2Unidad').width() + index;
    //    $('.chartAreaWrapper2Unidad').width(newwidth);
    //});

    var ctx = document.getElementById("EstatusAnualGraph").getContext("2d");
    const myChart = new Chart(ctx,
        {
            type: "line",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Atendidas',
                        backgroundColor: "rgb(255, 92, 51,0.1)",
                        borderColor: "rgb(255, 92, 51)",
                        fill: true,
                        toolTipOrder: 3,
                        data: _chartDataP,
                        yAxisID: "y",
                        barThickness: 15,
                    },
                    {
                        label: 'Pendientes',
                        backgroundColor: "rgb(0, 179, 0,0.1)",
                        borderColor: "rgb(0, 179, 0)",
                        fill:true,
                        toolTipOrder: 3,
                        data: _chartDataA,
                        yAxisID: "y",
                        barThickness: 15,
                    },
                ]
            },
            options: {
                layout: {
                    padding: {
                        bottom: 10,
                        left: 120,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            //maxRotation: 90,
                            //minRotation: 20,
                            font: {
                                size: 9,
                            },
                        },
                    },
                    y: {
                        position: "left",
                        min: 0,
                        grid: {
                            display: true
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        //labels: {
                        //    filter: (l) => (l.text !== 'Eff')
                        //}

                    },
                }
            }
        });

}
