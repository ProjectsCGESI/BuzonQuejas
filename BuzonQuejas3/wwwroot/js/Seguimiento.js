$(document).ready(function () {

    $(".modal-seguimiento-ok").modal("show");

    $.ajax({
        type: 'GET',
        url: "../GetUnidadName",
        data: {
            idUnidad: $("#unidadSeguimiento").val()
        },
        success: function (response) {
            $("#unidadSeguimiento").val(response['nombre'] === "No Aplica" ? "Sin asignar" : response['nombre'])
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "../GetMunicipioName",
        data: {
            idMunicipio: $("#municipioSeguimiento").val()
        },
        success: function (response) {
            $("#municipioSeguimiento").val(response['nombre'])
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "../GetMedioName",
        data: {
            idMedio: $("#medioSeguimiento").val()
        },
        success: function (response) {
            $("#medioSeguimiento").val(response['nombre'])
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "../GetCargoName",
        data: {
            idCargo: $("#cargoSeguimiento").val()
        },
        success: function (response) {
            $("#cargoSeguimiento").val(response['nombre'])
            // console.log(response);
        },
    });
});
