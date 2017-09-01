//var app;
//(function () {
//    app = angular.module("UsuariosModule", []);
//})();   
var app = angular.module('UsuariosModule', ['ngRoute']);

app.config(['$locationProvider', '$routeProvider', function ($locationProvider, $routeProvider) {

    $routeProvider.when('/frmCadUsuarios', { //Routing for show list of employee
        templateUrl: '/app/Views/FrmCadUsuario.html',
        controller: 'UsuariosController'
    }).when('/Usuarios', { //Routing for add employee
        templateUrl: '/app/Views/AddEmployee.html',
        controller: 'UsuariosController'
    })
        .when('/Usuarios/:empId', { //Routing for geting single employee details
            templateUrl: '/app/Views/EditUsuarios.html',
            controller: 'UsuariosController'
        })
        .when('/Usuarios/:empId', { //Routing for delete employee
            templateUrl: '/app/Views/DeleteUsuarios.html',
            controller: 'UsuariosController'
        })
        .otherwise({ //Default Routing
            controller: 'UsuariosController'
        })
}]);