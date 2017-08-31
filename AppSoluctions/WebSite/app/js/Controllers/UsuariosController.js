app.controller('UsuariosController', function ($scope, UsuariosService) {
    getAll();

    function getAll() {
        var servCall = UsuariosService.getUsuarios();
        servCall.then(function (d) {
            $scope.usuarios = d.data;
        }, function (error) {
                $log.error('Oops! Something went wrong while fetching the data.')
            })
    }
})