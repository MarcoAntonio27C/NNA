

$(document).ready(function () {

    $("#usuarios").hover(
        function () {
            $("#menu-usuarios").show();
        }
    );


    $("#menu-usuarios").hover(
            function () {
                $(this).show();
            },
            function () {
                $(this).hide();
            }
    );

    $("#denuncias").hover(
        function () {
            $("#menu-denuncias").show();
        }
    );


    $("#menu-denuncias").hover(
        function () {
            $(this).show();
        },
        function () {
            $(this).hide();
        }
    );

    $("#cuenta").hover(
        function () {
            $("#menu-cuenta").show();
        }
    );


    $("#menu-cuenta").hover(
        function () {
            $(this).show();
        },
        function () {
            $(this).hide();
        }
    );

});