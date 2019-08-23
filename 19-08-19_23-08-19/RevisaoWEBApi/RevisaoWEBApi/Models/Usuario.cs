using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class Usuario : UserControls
    {
        [Key]
        public int Id { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaNome)]
        public string Nome { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaEmail)]
        public string Email { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaLogin)]
        public string Login { get; set; }

        [CustomValidFields(Enums.ValidFields.ValidaSenha)]
        public string Senha { get; set; }

    }
}