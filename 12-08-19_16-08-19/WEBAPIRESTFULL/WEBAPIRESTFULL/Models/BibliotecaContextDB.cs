namespace WEBAPIRESTFULL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BibliotecaContextDB : DbContext
    {
        public BibliotecaContextDB()
            : base("name=BibliotecaContextDB")
        {
        }

        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<Editoras> Editoras { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Livros> Livros { get; set; }
        public virtual DbSet<Locacao> Locacao { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Autores>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Autores>()
                .HasMany(e => e.Livros)
                .WithMany(e => e.Autores)
                .Map(m => m.ToTable("LivroAutor").MapLeftKey("Autor").MapRightKey("Livro"));

            modelBuilder.Entity<Editoras>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Editoras>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Editoras>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Editoras)
                .HasForeignKey(e => e.Editora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Generos>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Generos>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Generos>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Generos)
                .HasForeignKey(e => e.Genero)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Livros>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Livros>()
                .Property(e => e.Isbn)
                .IsUnicode(false);

            modelBuilder.Entity<Livros>()
                .Property(e => e.Observacoes)
                .IsUnicode(false);

            modelBuilder.Entity<Livros>()
                .HasMany(e => e.Locacao)
                .WithRequired(e => e.Livros)
                .HasForeignKey(e => e.Livro)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Livros)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Livros1)
                .WithRequired(e => e.Usuarios1)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao)
                .WithRequired(e => e.Usuarios)
                .HasForeignKey(e => e.UsuAlt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao1)
                .WithRequired(e => e.Usuarios1)
                .HasForeignKey(e => e.Usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Locacao2)
                .WithRequired(e => e.Usuarios2)
                .HasForeignKey(e => e.UsuInc)
                .WillCascadeOnDelete(false);
        }
    }
}
