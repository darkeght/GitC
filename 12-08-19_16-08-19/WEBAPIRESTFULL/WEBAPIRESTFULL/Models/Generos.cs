namespace WEBAPIRESTFULL.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Generos : UserControls
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Generos()
        {
            Livros = new HashSet<Livros>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Tipo { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Livros> Livros { get; set; }
    }
}
