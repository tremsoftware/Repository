using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Usuarios
    {
        [Key]
        public int IdUsu { get; set; }
        public string LoginUsu { get; set; }
        public string SenhaUsu { get; set; }
        public DateTime DataCadUsu { get; set; }
    }
}