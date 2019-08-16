namespace WPFAppNew.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Livros")]
    public partial class Livro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livro()
        {
            Locacaos = new HashSet<Locacao>();
            Autores = new HashSet<Autore>();
        }

        public int Id { get; set; }

        public int Registro { get; set; }

        [Required]
        [StringLength(1200)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(15)]
        public string Isbn { get; set; }

        public int Genero { get; set; }

        public int Editora { get; set; }

        public string Sinopse { get; set; }

        [StringLength(1000)]
        public string Observacoes { get; set; }

        public bool Ativo { get; set; }

        public int UsuInc { get; set; }

        public int UsuAlt { get; set; }

        public DateTime DatInc { get; set; }

        public DateTime DatAlt { get; set; }

        public virtual Editora Editora1 { get; set; }

        public virtual Genero Genero1 { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Usuario Usuario1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locacao> Locacaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autore> Autores { get; set; }
    }
}
