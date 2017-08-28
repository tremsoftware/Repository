using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Salas
    {
        [Key]
        public int IdSal { get; set; }
        public Boolean ReservadaSal { get; set; }
        public Boolean AtivoSal { get; set; }
        public DateTime DataAluguelSal { get; set; }
        public int IdFunSal { get; set; }
        public string DescricaoSal { get; set; }
    }
}