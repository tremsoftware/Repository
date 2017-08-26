using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
   public class Clientes
    {
        [Key]
        public int IdCli { get; set; }
        public string NomeCli { get; set; }
        public string CpfCli { get; set; }
        public string RgCli { get; set; }
        public string TelCli { get; set; }
        public string EmailCli { get; set; }
        public string TratamentoCli { get; set; }
        public string ObservacaoCli { get; set; }
        public DateTime DataCadCli { get; set; }
        public DateTime DataNascCli { get; set; }
        public string EnderecoCli { get; set; }
    }
}