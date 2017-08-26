using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPI.Models
{
    public class Reservas
    {   [Key]
        public int IdRes { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int SalaId { get; set; }
        public DateTime DataRes { get; set; }
        public Boolean AtivoRes { get; set; }
    }
}