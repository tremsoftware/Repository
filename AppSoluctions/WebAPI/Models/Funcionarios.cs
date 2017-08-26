using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Funcionarios
    {
        [Key]
        
        public int IdFun { get; set; }
        public string NomeFun { get; set; }
        public int CargoFun { get; set; }
        public Boolean AtivoFun { get; set; }
        public string TelFun { get; set; }
        public string EmailFun { get; set; }
        public string CpfFun { get; set; }
        public string RgFun { get; set; }
        public string EnderecoFun { get; set; }
        public DateTime DataCadFun { get; set; }

        
    }
}