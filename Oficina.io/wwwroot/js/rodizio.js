function checkRodizio(placa) {
    $.ajax("/api/rodizio/" + placa,
        { method: "get" })
        .then(function (response) {
            
            toastr.success(response);
        });
}

function exibirTabelaRodizio() {
    $('#DT_RODIZIO').DataTable({
        "ajax": {
            "url": "/api/rodizio",
            "type": "get",
            "datatype": "json"
        },
        "columns": [
            { "data": "placaFinal" },
            { "data":"diaSemanaRodizio"}
        ]
    });
}
