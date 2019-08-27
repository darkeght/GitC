using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Bicicleta
    {
        [Key]
        public int BiciletaID { get; set; }
        public string Descricao { get; set; }
        public virtual Roda Roda { get; set; }

    }
}