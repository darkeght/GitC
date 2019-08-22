using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebMvcApp.Models
{
    public class Carro : UserControls
    {
        [Key]
        public int Id { get; set; }

        public string Placa { get; set; }
    }
}