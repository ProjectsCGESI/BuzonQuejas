$(document).ready(function () {

    $(".modal-seguimiento-ok").modal("show");

    //var fCreacion = $("#fechaCreacion").val();
    //var fAtencion = $("#fechaAtencion").val();

    //console.log(fCreacion);
    //console.log(fAtencion);

    //if (new Date(fCreacion).getTime() == new Date(fAtencion).getTime()) {
    //    $("#fechaAtencion").val(null);
    //}

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

    $.ajax({
        type: 'GET',
        url: "../GetMotivoName",
        data: {
            idMotivo: $("#motivoSeguimiento").val()
        },
        success: function (response) {
            $("#motivoSeguimiento").val(response['descripcion'])
            // console.log(response);
        },
    });

    $.ajax({
        type: 'GET',
        url: "../GetUnidadRemitenteName",
        data: {
            idunidadRemitente: $("#unidadRemitenteSeguimiento").val()
        },
        success: function (response) {
            $("#unidadRemitenteSeguimiento").val(response['nombre'])
            // console.log(response);
        },
    });
});
