namespace AcessandoDadosDoBancoAsync.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UserContexDB : DbContext
    {
        public UserContexDB()
            : base("name=UserContexDB")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Senha)
                .IsUnicode(false);
        }
    }
}
