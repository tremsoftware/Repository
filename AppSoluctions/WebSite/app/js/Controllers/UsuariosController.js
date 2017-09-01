//app.controller('UsuariosController', function ($scope, UsuariosService) {
//    getAll();

//    function getAll() {
//        var servCall = UsuariosService.getUsuarios();
//        servCall.then(function (d) {
//            $scope.usuarios = d.data;
//        }, function (error) {
//                $log.error('Erro ao pesquisar Usuários')
//            })
//    }
//})
app.controller("UsuariosController", ['$scope', '$http', '$location', '$routeParams', function ($scope, $http, $location, $routeParams) {
    $scope.ListOfUsuarios;
    $scope.Status;

    $scope.Close = function () {
        $location.path('/frmCadUsuarios');
    }

    //Get all employee and bind with html table
    $http.get("http://localhost:9000/api/usuarios/").success(function (data) {
        $scope.ListOfUsuarios = data;

    }).error(function (data) {
            $scope.Status = "User not found";
        });

    //Add new employee
    $scope.Add = function () {
        var UsuariosData = {
            Id: $scope.IdUsu,
            Login: $scope.LoginUsu,
            Senha: $scope.SenhaUsu,
            DataCadUsu: $scope.DataCadUsu,
          
            // DepartmentID: $scope.DepartmentID
        };
        debugger;
        $http.post("http://localhost:9000/api/usuarios/", UsuarioData).success(function (data) {
            $location.path('/frmCadUsuarios');
        }).error(function (data) {
            console.log(data);
            $scope.error = "Something wrong when adding new employee " + data.ExceptionMessage;
        });
    }

    //Fill the employee records for update

    if ($routeParams.empId) {
        $scope.Id = $routeParams.empId;

        $http.get('http://localhost:9000/api/usuarios/' + $scope.Id).success(function (data) {
            $scope.IdUsu = data.IdUsu;
            $scope.LoginUsu = data.LoginUsu;
            $scope.SenhaUsu = data.SenhaUsu;
            $scope.DataCadUsu = data.DataCadUsu;
            //$scope.DepartmentID = data.DepartmentID
        });

    }

    //Update the employee records
    $scope.Update = function () {
        debugger;
        var UsuariosData = {
            Id: $scope.IdUsu,
            Login: $scope.LoginUsu,
            Senha: $scope.SenhaUsu,
            DataCadUsu: $scope.DataCadUsu,
            //DepartmentID: $scope.DepartmentID
        };
        if ($scope.Id > 0) {

            $http.put("http://localhost:9000/api/usuarios/", UsuariosData).success(function (data) {
                $location.path('/frmCadUsuarios');
            }).error(function (data) {
                console.log(data);
                $scope.error = "Something wrong when adding updating employee " + data.ExceptionMessage;
            });
        }
    }


    //Delete the selected employee from the list
    $scope.Delete = function () {
        if ($scope.Id > 0) {

            $http.delete("http://localhost:9000/api/usuarios/" + $scope.Id).success(function (data) {
                $location.path('/frmCadUsuarios');
            }).error(function (data) {
                console.log(data);
                $scope.error = "Something wrong when adding Deleting employee " + data.ExceptionMessage;
            });
        }

    }
}]);