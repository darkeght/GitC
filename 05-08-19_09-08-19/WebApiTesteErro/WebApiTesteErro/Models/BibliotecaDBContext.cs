namespace WebApiTesteErro.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext()
            : base("name=BibliotecaDBContext")
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<Editora> Editoras { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<Locacao> Locacaos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autore>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Autore>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Autore>()
                .HasMany(e => e.Livros)
                .WithMany(e => e.Autores)
                .Map(m => m.ToTable("LivroAutor").MapLeftKey("Autor").MapRightKey("Livro"));

            modelBuilder.Entity<Editora>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Editora>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Editora>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Editora1)
                .HasForeignKey(e => e.Editora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Genero>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Genero1)
                .HasForeignKey(e => e.Genero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Isbn)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .Property(e => e.Observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<Livro>()
                .HasMany(e => e.Locacaos)
                .WithRequired(e => e.Livro1)
                .HasForeignKey(e => e.Livro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Livros1)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Locacaos)
                .WithRequired(e => e.Usuario1)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Locacaos1)
                .WithRequired(e => e.Usuario2)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Locacaos2)
                .WithRequired(e => e.Usuario3)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);
        }
    }
}
