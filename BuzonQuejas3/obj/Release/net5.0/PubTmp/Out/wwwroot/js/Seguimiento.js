$(document).ready(function () {

    $(".modal-seguimiento-ok").modal("show");

    $.ajax({
        type: 'GET',
        url: "../GetUnidadName",
        data: {
            idUnidad: $("#unidadSeguimiento").val()
        },
        success: function (response) {
            $("#unidadSeguimiento").val(response['nombre'])
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
});
