// Documentation 
// https://datatables.net/reference/option/language
// https://datatables.net/extensions/buttons/examples/html5/columns.html

$(document).ready(function () {
    $('table').DataTable({
        language: {
            info: 'Mostrando registro _START_ hasta el _END_',
            infoEmpty: '',
            infoFiltered: '',
            zeroRecords: 'No se encontraron registros coincidentes',
            search: 'Buscar:',
            lengthMenu: 'Mostrar _MENU_ registros',
            paginate: {
                previous: 'Anterior',
                next: 'Siguiente'
            },
            buttons: {
                copyTitle: 'Copiado al portapapeles',
                copySuccess: {
                    _: '%d líneas copiadas',
                },
            }
        },
        dom: 'lBfrtip',
        buttons: [
            {
                extend: 'collection',
                text: 'Exportar',
                buttons: [
                    {
                        extend: 'copy',
                        text: 'Copiar',
                        exportOptions: {
                            columns: [0, 1, 2, 3, 4]
                        }
                    },
                    {
                        extend: 'csv',
                        exportOptions: {
                            columns: [0, 1, 2, 3, 4]
                        }
                    },
                    {
                        extend: 'excel',
                        exportOptions: {
                            columns: [0, 1, 2, 3, 4]
                        }
                    },
                    {
                        extend: 'pdf',
                        exportOptions: {
                            columns: [0, 1, 2, 3, 4]
                        },
                    },
                ],
            },
        ]
    });
});