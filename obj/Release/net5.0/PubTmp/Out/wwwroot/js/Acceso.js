
$(document).ready(function () {
    console.log("Ready!");

    _hide();

    $("#send").click(function () {
        _hide();
        var mail = $("#email-address").val();
        var pass = $("#password").val();

        if ((mail.length == 0) || pass.length == 0) {
            $("#vacios").show();
            $("#alert-4").show();
        } else {

            $.ajax({
                type: 'POST',
                
                url: '/sicegipruebas4/Acceso/validar',
                data: { correo: mail, password : pass },
                success: function (response) {
                    if (response === 'true') {
                        //alert("Acceso Correcto");
                        $(location).attr('href', '/sicegipruebas4/Home/Index')
                    } else {
                        $("#alert-4").show();
                        $("#incorrectos").show();
                    }

                }
            });
        }
    });

    $("#close").click(function () {
        _hide();
    });

});

function _hide() {
    $("#alert-4").hide();
    $("#incorrectos").hide();
    $("#vacios").hide();
}