using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.Model
{
    public class Livro : Informacao
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public int Genero { get; set; }
        public int Editora { get; set; }
        public string Sinopse { get; set; }
        public string Observacoes { get; set; }

    }
}
