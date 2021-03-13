$(document).ready(function () {
    if (toastr) {
        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-center",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
    }


    setInterval(function () {

        console.log("10s")
        $.get("/api/powiadomienia/sprawdzpowiadomienia", function (data) {
            if (data != null) {
                toastr.info(data.opis, data.tytul);
            }
        })

    }, 10000)
})
