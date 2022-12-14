$(document).ready(function () {
    var $select2 = $('.select2').select2({
        width: 'resolve'
    });

    $('body').on('click', '.reasignar', function () {
        var idQueja = $(this).attr("id") + "";
        $("#QuejaId").val(idQueja);

        $.ajax({
            type: 'GET',
            url: "../Queja/GetUnidades",
            success: function (response) {
                $.each(response, function (i, unidad) {
                    $("#unidad").append($('<option>', {
                        value: unidad.unidadAdministrativaID,
                        text: unidad.nombre
                    }));
                });
            },
            error: function (request, status, error) {
                //alert(request);
            }
        });
    });

    $("#salir-bttn").click(function () {
        $('#unidad').empty();
    });

});
