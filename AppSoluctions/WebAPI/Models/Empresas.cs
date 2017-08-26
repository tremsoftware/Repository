using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Empresas
    {
        [Key]
        public int IdEmp { get; set; }
        public string NomeFantasiaEmp { get; set; }
        public string EnderecoEmp { get; set; }
        public string cnpjEmp { get; set; }
        public DateTime DataCadEmp { get; set; }
    }
}