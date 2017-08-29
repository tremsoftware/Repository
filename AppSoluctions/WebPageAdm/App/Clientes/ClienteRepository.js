appmodule.factory('ClientesRepository', function ($resource, $http) {
    var baseurl = 'http://localhost:83/WebApi';
    return {
        getClientes: function () {
            return $http({
                method: 'get', url: baseurl + '/api/Clientes/',
                headers: { 'Content-Type': 'aplication/json; charset = UTF-8' }
            });
        },

        PostClientes: function (modelClientes) {
            return $http({
                method: 'post', url: baseurl + '/api/Clientes/',
                param: modelClientes,
                headers: { 'Content-Type': 'aplication/json; charset = UTF-8' }
            });
        },
    };
});