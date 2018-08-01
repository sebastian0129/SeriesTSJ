$(function () {
    console.log("Estoy aca");
    $("#tablaTemporadas").DataTable({
        columnDefs: [{
            targets: -1,
            visible: true
        }]
    });
});