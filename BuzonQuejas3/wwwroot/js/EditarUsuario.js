$(document).ready(function () {
    $(".modal-EditarUsuario-ok").modal("show");
    var $select2 = $('.select2').select2();
    $("#reestablecer-ok").hide();
    $("#reestablecer-no").hide();
    $("#nueva-clave").prop("disabled", true);

    var claveBD = $("#claveUsuarioHidden").val();
    $("#claveHidden").val(claveBD);


    //$("#reestablecerClave").on("change", function () {
    //    var valor = $("input:checkbox[name=reestablecerClave]:checked").val();
    //    console.log(valor);
    //})

    $("#reestablecerClave").click(function () {
        if ($('#reestablecerClave').prop('checked')) {
            //$("#nueva-clave").val('');
            $("#nueva-clave").prop("disabled", false);
            $("#reestablecer-ok").show();
        }
        else {
            $("#reestablecer-ok").hide();
            $("#nueva-clave").prop("disabled", true);
            $("#reestablecer-no").show();
        }
    });

    
});