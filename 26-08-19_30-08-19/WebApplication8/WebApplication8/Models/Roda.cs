using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Roda
    {
        [Key]
        public int RodaID { get; set; }
        public string Descricao { get; set; }
    }
}