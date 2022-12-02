
let ChartDrawEstatus;
let ChartDrawEstatusDiario;
let ChartDrawQuejasAnual;
let ChartDrawUnidades;
let ChartDrawMunicipios;
let ChartDrawMedios;
let ChartDrawEstatusUnidades;
let ChartDrawDepartamentos;



$(document).ready(function () {

    $("#navBarPrincipal").hide();

    for (var i = 0; i < 32; i++) {
        if (i == 0) {
            $("select[name=dia]").append(new Option("-", "-"));
        }
        else {
            $("select[name=dia]").append(new Option(i, i));
        }
    }

    for (var i = 0; i < 13; i++) {
        if (i == 0) {
            $("select[name=mes]").append(new Option("-", "-"));
        }
        else {
            $("select[name=mes]").append(new Option(i, i));
        }
    }

    $.ajax({
        type: 'GET',
        url: "../Queja/GetFirstLastYear",
        success: function (response) {
            $("select[name=anio]").append(new Option("-", ""));
            for (var i = response[0]; i <= response[1]; i++) {

                $("select[name=anio]").append(new Option(i, i));
            }
            $("#fechaAnio").val($("#fechaAnio option:first").val());
        },
    });

    //Mostrar gráfico para total de quejas por ESTATUS
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasEstatusTotal",
        //dataType: "json",
        //data: "",
        //contentType: "application/x-www-form-urlencoded; charset=UTF-8",
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
        type: 'GET',
        url: "../Queja/GetQuejasEstatusDiario",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawEstatusDiario(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por ESTATUS Anual
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasEstatusAnual",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawQuejasAnual(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por UNIDAD
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasPorUnidades",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawUnidades(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por MUNICIPIO
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasPorMunicipio",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawMunicipios(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total de quejas por Medio de recepción
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasMedio",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawMedios(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total pendiente y atendido de quejas por unidad administrativa
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasEstatusPorUnidades",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawEstatusUnidades(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //Mostrar gráfico para total por departamento 
    $.ajax({
        type: 'GET',
        url: "../Queja/GetQuejasPorDepartamento",
        //dataType: "json",
        //data: "",
        //contentType: "application / json; charset=utf-8",
        success: function (data) {
            drawDepartamentos(data);
        },
        error: function (err) {
            //alert("error" + err.data);
        },
    });

    //$("#AjaxForm").submit(function () {
    $('body').on('click', '#filtrarFecha', function (e) {
        if ($("#fechaMes").val() != "-" && $("#fechaAnio").val() == "") {
        }
        else {
            e.preventDefault();
            var valdata = new Array;
            valdata.push($("#fechaAnio").val() == "" ? "-" : $("#fechaAnio").val());
            valdata.push($("#fechaMes").val());
            valdata.push($("#fechaDia").val());
            console.log(valdata);

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasEstatusTotal",
                dataType: "json",
                contextType: "application/json",
                //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                data: { filter: valdata },
                traditional: true,
                success: function (data) {
                    var totales = data[1];
                    console.log("quejas filtro" + totales[2]);
                    $("#totalAtendidas").html(totales[0]);
                    $("#totalPendientes").html(totales[1]);
                    $("#totalQuejas").html(totales[2]);
                    if (ChartDrawEstatus) {
                        ChartDrawEstatus.destroy();
                    }
                    drawEstatus(data);
                },
                error: function (err) {
                    alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasEstatusDiario",
                dataType: "json",
                contextType: "application/json",
                data: { filter: valdata },
                traditional: true,
                success: function (data) {
                    if (ChartDrawEstatusDiario) {
                        ChartDrawEstatusDiario.destroy();
                    }
                    drawEstatusDiario(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasEstatusAnual",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawQuejasAnual) {
                        ChartDrawQuejasAnual.destroy();
                    }
                    drawQuejasAnual(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasPorUnidades",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawUnidades) {
                        ChartDrawUnidades.destroy();
                    }
                    drawUnidades(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasPorMunicipio",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawMunicipios) {
                        ChartDrawMunicipios.destroy();
                    }
                    drawMunicipios(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasMedio",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawMedios) {
                        ChartDrawMedios.destroy();
                    }
                    drawMedios(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasEstatusPorUnidades",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawEstatusUnidades) {
                        ChartDrawEstatusUnidades.destroy();
                    }
                    drawEstatusUnidades(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

            $.ajax({
                type: 'GET',
                url: "../Queja/GetQuejasPorDepartamento",
                dataType: "json",
                data: { filter: valdata },
                contextType: "application/json",
                traditional: true,
                success: function (data) {
                    if (ChartDrawDepartamentos) {
                        ChartDrawDepartamentos.destroy();
                    }
                    drawDepartamentos(data);
                },
                error: function (err) {
                    //alert("error" + err.data);
                },
            });

        }
    });

    $('#group-day').hide();

    $('#fechaMes').on('change', function () {
        // Para asignar un nuevo valor a la variable global "a" no se usa var, 
        // solo el nombre de la variable
        var selectedMes = $("#fechaMes option:selected").text();
        if (selectedMes != "-") {
            $('#group-day').show();
        }
        else {
            $('#group-day').hide();
            $("#fechaDia").val($("#fechaDia option:first").val());
        }
    });


});

//const scrollDemo = document.querySelector("#chartAreaWrapperUnidad");

//scrollDemo.addEventListener("scroll", event => {
//    console.log("haciendo scrooll");
//    chartAreaWrapper2Unidad.innerHTML = `scrollTop: ${scrollDemo.scrollTop} <br>
//                                scrollLeft: ${scrollDemo.scrollLeft} `;
//        }, { passive: true });

const legendMargin = {
    id: 'legendMargin',
    beforeInit(chart, legend, options) {
        const fitValue = chart.legend.fit;

        chart.legend.fit = function fit() {
            fitValue.bind(chart.legend)();
            return this.height += 20;
        }

    }
};

const canvasBg = {
    id: 'customCanvasBackgroundColor',
    beforeDraw: (chart, args, options) => {
        const { ctx } = chart;
        ctx.save();
        ctx.globalCompositeOperation = 'destination-over';
        ctx.fillStyle = options.color || '#002733';
        ctx.fillRect(0, 0, chart.width, chart.height);
        ctx.restore();
    }
};


function drawEstatus(data) {
    var _data = data;
    var _chartLabels = _data[0];
    var _chartData = [];

    _data[1].forEach(function (value, index) {
        if (index != _data[1].length - 1)
            _chartData.push(value);
    });
    Chart.register({
        id: 'doughnut-centertext',
        beforeDraw: function (chart) {
            if (chart.options.elements.center) {
                // Get ctx from string
                var ctx = chart.ctx;
                // Get options from the center object in options
                var centerConfig = chart.options.elements.center;
                var fontStyle = centerConfig.fontStyle || 'Arial';
                var txt = centerConfig.text;
                var color = centerConfig.color || '#000';
                var maxFontSize = centerConfig.maxFontSize || 75;
                var sidePadding = centerConfig.sidePadding || 20;
                var sidePaddingCalculated = (sidePadding / 100) * (chart._metasets[chart._metasets.length - 1].data[0].innerRadius * 2)
                // Start with a base font of 30px
                ctx.font = "30px " + fontStyle;

                // Get the width of the string and also the width of the element minus 10 to give it 5px side padding
                var stringWidth = ctx.measureText(txt).width;
                var elementWidth = (chart._metasets[chart._metasets.length - 1].data[0].innerRadius * 2) - sidePaddingCalculated;

                // Find out how much the font can grow in width.
                var widthRatio = elementWidth / stringWidth;
                var newFontSize = Math.floor(30 * widthRatio);
                var elementHeight = (chart._metasets[chart._metasets.length - 1].data[0].innerRadius * 2);

                // Pick a new font size so it will not be larger than the height of label.
                var fontSizeToUse = Math.min(newFontSize, elementHeight, maxFontSize);
                var minFontSize = centerConfig.minFontSize;
                var lineHeight = centerConfig.lineHeight || 25;
                var wrapText = false;

                if (minFontSize === undefined) {
                    minFontSize = 20;
                }

                if (minFontSize && fontSizeToUse < minFontSize) {
                    fontSizeToUse = minFontSize;
                    wrapText = true;
                }

                // Set font settings to draw it correctly.
                ctx.textAlign = 'center';
                ctx.textBaseline = 'middle';
                var centerX = ((chart.chartArea.left + chart.chartArea.right) / 2);
                var centerY = ((chart.chartArea.top + chart.chartArea.bottom) / 2);
                ctx.font = fontSizeToUse + "px " + fontStyle;
                ctx.fillStyle = color;

                if (!wrapText) {
                    ctx.fillText(txt, centerX, centerY);
                    return;
                }

                var words = `${txt}`.split(" ");
                //var words = txt.split(' ');
                var line = '';
                var lines = [];

                // Break words up into multiple lines if necessary
                for (var n = 0; n < words.length; n++) {
                    var testLine = line + words[n] + ' ';
                    var metrics = ctx.measureText(testLine);
                    var testWidth = metrics.width;
                    if (testWidth > elementWidth && n > 0) {
                        lines.push(line);
                        line = words[n] + ' ';
                    } else {
                        line = testLine;
                    }
                }

                // Move the center up depending on line height and number of lines
                centerY -= (lines.length / 2) * lineHeight;

                for (var m = 0; m < lines.length; m++) {
                    ctx.fillText(lines[m], centerX, centerY);
                    centerY += lineHeight;
                }
                //Draw text in center
                ctx.fillText(line, centerX, centerY);
            }
        }
    });

    var ctx = document.getElementById("EstatusGraph").getContext("2d");


    ChartDrawEstatus = new Chart(ctx,
        {
            type: "doughnut",
            data: {
                labels: _chartLabels,
                datasets: [{
                    backgroundColor: ["#00e600", "#ff3333"],
                    label: 'Total de quejas',
                    data: _chartData
                }]
            },
            plugins: [ChartDataLabels, legendMargin, canvasBg],
            options: {
                elements: {
                    center: {
                        text: 'Quejas',
                        color: '#FF6384', // Default is #000000
                        fontStyle: 'Arial', // Default is Arial
                        sidePadding: 20, // Default is 20 (as a percentage)
                        minFontSize: 10, // Default is 20 (in px), set to false and text will not wrap.
                        lineHeight: 25 // Default is 25 (in px), used for when text wraps
                    }
                },
                //showTooltips: false,
                plugins: {
                    legend: {
                        display: true,
                        labels: {
                            //padding: 50,
                            font: {
                                size: 14
                            },
                            color: "white"
                        },
                    },
                    //customCanvasBackgroundColor: {
                    //    color: '#d7dad9',
                    //},
                    datalabels: {
                        color: "white",
                        //color: "rgb(62, 66, 64)",
                        backgroundColor: ["rgb(62, 66, 64,0.3)", "rgb(62, 66, 64,0.3)"],
                        borderRadius: [10, 10],
                        font: {
                            size: 15,
                            weight: "bold"
                        },
                        formatter: (value, ctx) => {
                            const datapoints = ctx.chart.data.datasets[0].data
                            if (datapoints[0] > 0 || datapoints[1] > 0) {
                                const total = datapoints.reduce((total, datapoint) => total + datapoint, 0)
                                const percentage = value / total * 100
                                return percentage != 0 ? percentage.toFixed(2) + "%" : null;
                            }
                            else {
                                return null;
                            }
                        },
                        //anchor: "end",
                        //align: "top",
                        //offset:10
                    },
                },


            },

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
    ChartDrawEstatusDiario = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        backgroundColor: ["rgb(0, 184, 230,0.5)", "rgb(0, 230, 0,0.5)", "rgb(255, 51, 51,0.5)"],
                        borderColor: ["#00ccff", "#00e600", "#ff3333"],
                        borderWidth: 2,
                        label: 'Quejas',
                        data: [_chartDataT, _chartDataA, _chartDataP]
                    },
                ]
            },
            plugins: [ChartDataLabels, canvasBg],
            options: {
                scales: {
                    y: {
                        ticks: {
                            beginAtZero: true,
                            callback: function (value) { if (value % 1 === 0) { return value; } }
                        },
                        grid: {
                            color: "#004e66"
                        }
                    },
                    x: {
                        ticks: {
                            color: "white",
                            //align: "center"
                        },
                        grid: {
                            display: false,
                        }
                    }
                },
                plugins: {
                    legend: {
                        display: false,
                        labels: {
                            font: {
                                size: 14
                            }
                        },
                    },
                    datalabels: {
                        color: "white",
                        backgroundColor: ["rgb(0, 184, 230)", "rgb(0, 230, 0)", "rgb(255, 51, 51)"],
                        borderRadius: 10,
                        font: {
                            size: 15,
                            weight: "bold"
                        },
                        formatter: function (value, context) { return value || null; },
                        //anchor: "end",
                        //align: "top",
                        //offset:10
                    }
                }
            }
        });

}

function scrollUnidadesHandle(ev) {
    let classNm = ev.currentTarget.className;
    const chart = Chart.getChart(ev.target);

    if (ev.deltaY < 0 && chart.scales.x.min > 0) //scroll-up
    {
        chart.options.scales.x.min -= 1;
        chart.options.scales.x.max -= 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 40);
    } else if (ev.deltaY > 0 && chart.scales.x.max < chart.data.labels.length - 1)//scroll-down
    {
        chart.options.scales.x.min += 1;
        chart.options.scales.x.max += 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 40);
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

    _data[1].forEach(function (total) {
        _chartData.push(total);
        //var newwidth = $('.chartAreaWrapper2Unidad').width() + 60;
        //$('.chartAreaWrapper2Unidad').width(newwidth);
    });

    var ctx = document.getElementById("UnidadesGraph").getContext("2d");
    ChartDrawUnidades = new Chart(ctx,
        {
            type: "line",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Número de quejas',
                        backgroundColor: "rgb(0, 255, 255,0.2)",
                        borderColor: "#00b3b3",
                        fill: true,
                        data: _chartData,
                        //barThickness: 15,
                    }
                ]
            },
            plugins: [ChartDataLabels, legendMargin, canvasBg],
            options: {
                //maxBarThickness: 55,
                clip: true,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        min: 0,
                        max:9,
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
                            color: "white"
                        }
                    },
                    y: {
                        position: "left",
                        min: 0,
                        grid: {
                            display: true,
                            color: "#004e66"
                        },
                        ticks: {
                            beginAtZero: true,
                            callback: function (value) { if (value % 1 === 0) { return value; } },
                            color: "white"
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        labels: {
                            color: "white",
                            font: {
                                size: 14
                            }
                        },
                    },
                    //customCanvasBackgroundColor: {
                    //    color: '#d7dad9',
                    //},
                    datalabels: {
                        color: "white",
                        backgroundColor: "rgb(0, 255, 255,0.8)",
                        borderRadius: 10,
                        font: {
                            size: 14,
                            weight: "bold"
                        },
                        formatter: function (value, context) { return value || null; },
                        //anchor: "end",
                        align: "top",
                        //offset:10
                    }
                },
            }
        });

}

function scrollMunicipiosHandle(ev) {
    let classNm = ev.currentTarget.className;
    const chart = Chart.getChart(ev.target);

    if (ev.deltaY < 0 && chart.scales.x.min > 0) //scroll-up
    {
        chart.options.scales.x.min -= 1;
        chart.options.scales.x.max -= 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 40);
    } else if (ev.deltaY > 0 && chart.scales.x.max < chart.data.labels.length - 1)//scroll-down
    {
        chart.options.scales.x.min += 1;
        chart.options.scales.x.max += 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 40);
    }
}

//Gráfico para quejas por MUNICIPIO
function drawMunicipios(data) {
    var _data = data;
    var _chartLabels = [];
    var _chartData = [];

    _data[0].forEach(function (label, index) {
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
        //var newwidth = $('.chartAreaWrapper2Municipio').width() + 50;
        //$('.chartAreaWrapper2Municipio').width(newwidth);

    });

    var ctx = document.getElementById("MunicipiosGraph").getContext("2d");

    const legendMarginMunicipio = {
        id: 'legendMargin',
        beforeInit(chart, legend, options) {
            const fitValue = chart.legend.fit;

            chart.legend.fit = function fit() {
                fitValue.bind(chart.legend)();
                return this.height += 15;
            }

        }
    };

    ChartDrawMunicipios = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Total de quejas',
                        backgroundColor: "rgb(255, 255, 0,0.8)",
                        borderColor: "#b38600",
                        borderWidth: 1,
                        data: _chartData,
                        barThickness: 10,
                        datalabels: {
                            color: "white",
                            backgroundColor: "rgb(255, 255, 0,0.5)",
                            borderRadius: 30,
                            font: {
                                size: 13,
                                weight: "bold"
                            },
                            formatter: function (value, context) { return value || null; },
                            anchor: "end",
                            align: "top",
                            //offset:0
                            //padding:10
                            rotation: 270
                        }
                    },
                    {
                        label: "Eff",
                        type: "line",
                        fill: true,
                        data: _chartData,
                        stepped: "middle",
                        datalabels: {
                            display: false,
                        },
                    }
                ]
            },
            plugins: [ChartDataLabels, legendMarginMunicipio, canvasBg],
            options: {
                maxBarThickness: 55,
                //clip: true,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    }
                },
                scales: {
                    x: {
                        min: 0,
                        max:20,
                        grid: {
                            display: false
                        },
                        ticks: {
                            autoSkip: false,
                            color: "white",
                            minRotation: 60,
                            maxRotation: 60,
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
                            display: true,
                            color: "#004e66"
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } },
                            color: "white"
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        labels: {
                            filter: (l) => (l.text !== 'Eff'),
                            color: "white",
                            font: {
                                size: 14
                            }
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
    ChartDrawMedios = new Chart(ctx,
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
            plugins: [ChartDataLabels, legendMargin, canvasBg],
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
                        grid: {
                            color: "#004e66"
                        },
                        precision: 0,
                        beginAtZero: true,
                        angleLines: {
                            color: "white",
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } },
                            color: "white",
                            backdropColor: 'transparent'
                        },
                        pointLabels: {
                            color: 'white',
                            font: {
                                size: 12,
                            },
                        },
                    },
                },
                plugins: {

                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        labels: {
                            color: "white",
                            font: {
                                size: 14
                            }
                        }

                    },
                    datalabels: {
                        color: "white",
                        backgroundColor: "rgb(54, 162, 235,0.8)",
                        borderRadius: 10,
                        font: {
                            size: 15,
                            weight: "bold"
                        },
                        formatter: function (value, context) { return value || null; },
                        //anchor: "end",
                        //align: "top",
                        //offset:10
                    }
                }
            }
        });

}

function scrollEstatusUnidadesHandle(ev) {
    let classNm = ev.currentTarget.className;
    const chart = Chart.getChart(ev.target);

    if (ev.deltaY < 0 && chart.scales.x.min > 0) //scroll-up
    {
        chart.options.scales.x.min -= 1;
        chart.options.scales.x.max -= 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() - 40);
    } else if (ev.deltaY > 0 && chart.scales.x.max < chart.data.labels.length - 1)//scroll-down
    {
        chart.options.scales.x.min += 1;
        chart.options.scales.x.max += 1;
        chart.update();
        //$(`.${classNm}`).scrollLeft($(`.${classNm}`).scrollLeft() + 40);
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

    _data[1].forEach(function (total, index) {
        _chartDataA.push(total);
        //var newwidth = $('.chartAreaWrapper2EstatusUnidad').width() + 60;
        //$('.chartAreaWrapper2EstatusUnidad').width(newwidth);

    });

    _data[2].forEach(function (total) {
        _chartDataP.push(total);
    });

    var ctx = document.getElementById("EstatusUnidadesGraph").getContext("2d");
    ChartDrawEstatusUnidades = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Atendidas',
                        backgroundColor: "rgb(0, 230, 0,0.5)",
                        borderColor: "#00e600",
                        borderWidth: 1,
                        //toolTipOrder: 3,
                        data: _chartDataA,
                        //yAxisID: "y",
                        //barPercentage: 0.1,
                        //barThickness: 20,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                    {
                        label: 'Pendientes',
                        backgroundColor: "rgb(255, 51, 51,0.5)",
                        borderColor: "#ff3333",
                        borderWidth: 1,
                        //toolTipOrder: 3,
                        data: _chartDataP,
                        //yAxisID: "y",
                        //barPercentage: 0.1,
                        //barThickness: 20,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                ]
            },
            plugins: [ChartDataLabels, legendMargin, canvasBg],
            options: {
                maxBarThickness: 55,
                responsive: true,
                maintainAspectRatio: true,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 10,
                    },
                },
                scales: {
                    x: {
                        //stacked: true,
                        min: 0,
                        max:9,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            maxRotation: 0,
                            color: "white",
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
                            display: true,
                            color: "#004e66"
                        },
                        stacked: true,
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } },
                            color: "white"
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
                        display: true,
                        labels: {
                            color: "white",
                            font: {
                                size: 14
                            }
                        }

                    },
                    datalabels: {
                        color: "White",
                        backgroundColor: "rgb(62, 66, 64,0.5)",
                        borderRadius: 10,
                        font: {
                            size: 13,
                            weight: "bold"
                        },
                        formatter: function (value, context) { return value || null; },
                        //anchor: "end",
                        //align: "top",
                        //offset:10
                    }
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
    var _chartLabels = [];
    var _chartData = [];

    _data[0].forEach(function (label, index) {
        const palabras = label.split(" ");
        var contadorPalabras = 0;

        var nuevoArr = [];
        var palabrasNew = [];
        var tam = palabras.length - 1;

        console.log("palabra: " + palabras);
        for (var i = 0; i <= tam; i++) {
            var taaam = tam - i;
            console.log("tam -i " + taaam);
            if (tam - i >= 1) {
                if (contadorPalabras <= 2) {
                    nuevoArr.push(palabras[i])

                    if (contadorPalabras < 2) {
                        contadorPalabras++;
                    }
                    else {
                        var res = nuevoArr.join(" ");
                        palabrasNew.push(res);
                        nuevoArr = [];
                        contadorPalabras = 0;
                    }
                }
            }
            else {
                console.log("iteró" + i);
                if (i == tam) {
                    nuevoArr.push(palabras[i]);
                    var res = nuevoArr.join(" ");
                    palabrasNew.push(res);

                }
                else {
                    nuevoArr.push(palabras[i])
                }
            }
        }
        console.log(palabrasNew);
        palabrasNew.join(" ");
        _chartLabels.push(palabrasNew);

    });

    _data[1].forEach(function (total) {
        _chartData.push(total);
        var newHeight = $('.chartAreaWrapper2Dpto').height() + 2;
        $('.chartAreaWrapper2Dpto').height(newHeight);

        //var newWidth = $('.chartAreaWrapper2Dpto').width() + 10;
        //$('.chartAreaWrapper2Dpto').width(newWidth);

    });

    var ctx = document.getElementById("DepartamentosGraph").getContext("2d");
    ChartDrawDepartamentos = new Chart(ctx,
        {
            type: "bar",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Quejas registradas',
                        backgroundColor: "rgb(187, 153, 255,0.5)",
                        borderColor: "#bb99ff",
                        borderWidth: 2,
                        toolTipOrder: 3,
                        data: _chartData,
                        //yAxisID: "y",
                        //barPercentage: 0.1,
                        barThickness: 15,
                        //tension: -1,
                        //categoryPercentage: 0.9,
                        //barPercentage: 1
                    },
                ]
            },
            plugins: [ChartDataLabels, legendMargin, canvasBg],
            options: {
                indexAxis: 'y',
                maintainAspectRatio: true,
                layout: {
                    padding: {
                        bottom: 10,
                        left: 20,
                        right: 30
                    },
                },
                scales: {
                    y: {
                        //stacked: true,
                        grid: {
                            display: false,
                        },
                        ticks: {
                            autoSkip: false,
                            color: "white",
                            //maxRotation: 90,
                            //minRotation: 30,
                            font: {
                                size: 10,
                            },
                        },
                        //stacked: true,
                    },
                    x: {
                        //position: "left",
                        beginAtZero: true,
                        min: 0,
                        grid: {
                            display: true,
                            color: "#004e66"
                        },
                        ticks: {
                            color: "white"
                        }
                        //stacked: true,
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
                        display: true,
                        labels: {
                            color: "white",
                            font: {
                                size: 14
                            }
                        }

                    },
                    datalabels: {
                        color: "white",
                        backgroundColor: "rgb(187, 153, 255,0.5)",
                        borderRadius: 10,
                        font: {
                            size: 15,
                            weight: "bold"
                        },
                        formatter: function (value, context) { return value || null; },
                        anchor: "end",
                        align: "right",
                        //offset:10
                    }
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
    ChartDrawQuejasAnual = new Chart(ctx,
        {
            type: "line",
            data: {
                labels: _chartLabels,
                datasets: [
                    {
                        label: 'Pendientes',
                        backgroundColor: "rgb(255, 92, 51,0.2)",
                        borderColor: "rgb(255, 92, 51)",
                        fill: true,
                        toolTipOrder: 3,
                        data: _chartDataP,
                        yAxisID: "y",
                        barThickness: 15,
                        datalabels: {
                            color: "white",
                            backgroundColor: "rgb(255, 92, 51,0.5)",
                            borderRadius: 10,
                            font: {
                                size: 15,
                                weight: "bold"
                            },
                            formatter: function (value, context) { return value || null; },
                            //anchor: "end",
                            align: "top",
                            //offset:10
                        }
                    },
                    {
                        label: 'Atendidas',
                        backgroundColor: "rgb(0, 179, 0,0.2)",
                        borderColor: "rgb(0, 179, 0)",
                        fill: true,
                        toolTipOrder: 3,
                        data: _chartDataA,
                        yAxisID: "y",
                        barThickness: 15,
                        datalabels: {
                            color: "white",
                            backgroundColor: "rgb(0, 179, 0,0.5)",
                            borderRadius: 10,
                            font: {
                                size: 15,
                                weight: "bold"
                            },
                            formatter: function (value, context) { return value || null; },
                            //anchor: "end",
                            align: "top",
                            //offset:10
                        }
                    },
                ]
            },
            plugins: [ChartDataLabels, legendMargin, canvasBg],
            options: {
                layout: {
                    padding: {
                        bottom: 10,
                        //left: 120,
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
                            color: "white",
                            //maxRotation: 90,
                            //minRotation: 20,
                            font: {
                                size: 15,
                            },
                        },
                    },
                    y: {
                        position: "left",
                        min: 0,
                        grid: {
                            display: true,
                            color: "#004e66"
                        },
                        ticks: {
                            callback: function (value) { if (value % 1 === 0) { return value; } },
                            color: "white"
                        }
                    }
                },
                plugins: {
                    legend: {
                        position: "top",
                        reverse: true,
                        display: true,
                        labels: {
                            color: "white",
                            font: {
                                size: 14
                            }
                        }
                        //labels: {
                        //    filter: (l) => (l.text !== 'Eff')
                        //}

                    },

                }
            }
        });

}
