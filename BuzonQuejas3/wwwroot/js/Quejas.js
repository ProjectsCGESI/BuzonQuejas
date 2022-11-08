$(document).ready(function () {

    $('body').on('click', '.reasignar', function () {
        var idQueja = $(this).attr("id") + "";
        //$("#modalbodi").append(idEmpleado);
        //$("#showID").val(idQueja);
        $("#QuejaId").val(idQueja);

        $.ajax({
            type: 'GET',
            url: "Queja/GetUnidad",
            dataType: "json",
            data: {
                quejaId: idQueja
            },
            success: function (response) {
                $("#showID").val(response['nombre']);
                $("#optionPrincipal").text(response['nombre']);
                $("#optionPrincipal").val(response['unidadAdministrativaID']);

                console.log("data: " + response['nombre']);
            },
            error: function (request, status, error) {
                alert(request.responseText);
            }
        })

        $.ajax({
            type: 'GET',
            url: "Queja/GetUnidades",
            success: function (response) {
                $.each(response, function (i, unidad) {
                    var str = unidad.nombre;
                    str = str.toLowerCase().replace(/\b[a-z]/g, function (letter) {
                        return letter.toUpperCase();
                    });

                    $("#unidad").append($('<option>', {
                        value: unidad.unidadAdministrativaID,
                        text: str
                    }));
                });
                // console.log(response);
            },
                error: function (request, status, error) {
                alert(request);
            }
        });
    });

    $("#salir-bttn").click(function () {
        $('#unidad option:not(:first)').remove();
    });

    //$("close-modal-bttn").click(function () {
    //    $('#unidad option:not(:first)').remove();
    //});
});
