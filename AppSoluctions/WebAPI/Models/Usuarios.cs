using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsu { get; set; }
        public string loginUsu { get; set; }
        public string SenhaUsu { get; set; }
        public DateTime DataCadUsu { get; set; }
    }
}