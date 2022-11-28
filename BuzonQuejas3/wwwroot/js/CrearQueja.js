$(document).ready(function () {

    $(".modal-ok").modal("show");

    $(function () {
        var $select2 = $('.select2').select2();

        //Here, for long strings, space-separation is performed every 50 characters to ensure line breaks. 
        //You can change the length according to your needs.
        $('#CargoID option').each(function () {
            var myStr = $(this).text();
            var newStr = myStr;
            if (myStr.length > 50) {
                newStr = myStr.match(/.{1,50}/g).join(' ');
            }
            $(this).text(newStr);
        });
    })
});


