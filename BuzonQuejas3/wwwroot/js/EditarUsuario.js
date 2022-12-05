$(document).ready(function () {
    $(".modal-EditarUsuario-ok").modal("show");
    $("#reestablecer-ok").hide();
    $("#reestablecer-no").hide();

    //$("#reestablecerClave").on("change", function () {
    //    var valor = $("input:checkbox[name=reestablecerClave]:checked").val();
    //    console.log(valor);
    //})

    $("#reestablecerClave").click(function () {
        if ($('#reestablecerClave').prop('checked')) {
            $("#nueva-clave").val('');
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