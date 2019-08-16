namespace WebApiTesteErro.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locacao")]
    public partial class Locacao
    {
        public int Id { get; set; }

        public int Livro { get; set; }

        public int Usuario { get; set; }

        public int Tipo { get; set; }

        public DateTime Devolucao { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        public virtual Livro Livro1 { get; set; }

        public virtual Usuario Usuario1 { get; set; }

        public virtual Usuario Usuario2 { get; set; }

        public virtual Usuario Usuario3 { get; set; }
    }
}
