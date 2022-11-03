$(document).ready(function () {

    $("#radioYes").prop('checked', true);
    $("#selectDepartamento").prop('disabled', true);
    $("#departamentoFalse").hide();

    $("#radioYes").click(function () {

        $("#selectDepartamento").prop('disabled', true);
        $("#departamentoFalse").hide();
        //$("#departamentoTrue").show();

        // for current value
        //alert($(this).val());
        //var opcion = $(this).val();
       
    })

    $("#radioNo").click(function () {

        $("#departamentoFalse").show();
        $("#departamentoTrue").hide();
        $("#selectDepartamento").prop('disabled', false);
        // for current value
        //alert($(this).val());
        //var opcion = $(this).val();
       
    })

    //$("#gridRadios1").click(function () {

        // for current value
        //alert($(this).val());
        //var opcion = $(this).val();

        //$.ajax({
        //    url: "/Queja/Create",
        //    type: 'POST',
        //    data: { esDepartamento : opcion},
        //    success: function (result) {
        //        //alert("success" + opcion);
        //        //console.log("click");
        //        $("body").html(result);
        //    },
        //    error: function (request, status, error) {
        //        alert(request.responseText);
        //    }
        //});
    //})



});



    //$("#gridRadios1").click(function () {
    //    var RatingStar = $("input[name=esMiDepartamento]:checked").val() //Other fields  //Other fields values'it is true');
    //    alert($(this).val());
    //$.ajax({
    //    url: '@Url.Action("GiveReview", "Home")',
    //    type: 'POST',
    //    data: { "UserId": 1, "RatingStar": RatingStar, "ConsumerName": "ABC", "ReviewHeader": "ok", "ReviewContent": "wqsada" },
    //    success: function (result) {
    //        //alert("success");
    //        console.log("click");
    //    },
    //    error: function (result) {
    //        alert("error!");
    //    }
    //});   //end ajax
    //});
