﻿app.service("UsuariosService", function ($http) {
    this.getUsuarios= function () {
        return $http.get("http://localhost:9000/api/usuarios/")
    }
}); 