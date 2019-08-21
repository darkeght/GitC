namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovendoUserControl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropForeignKey("dbo.Livros", "UsuAlt", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "UsuInc", "dbo.Usuarios");
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            DropIndex("dbo.Livros", new[] { "UsuInc" });
            DropIndex("dbo.Livros", new[] { "UsuAlt" });
            AddColumn("dbo.Livros", "Usuarios_Id", c => c.Int());
            AddColumn("dbo.Livros", "Usuarios_Id1", c => c.Int());
            AddColumn("dbo.Livros", "Editoras_Id", c => c.Int());
            AddColumn("dbo.Livros", "Generos_Id", c => c.Int());
            AlterColumn("dbo.Livros", "UsuInc", c => c.Int());
            AlterColumn("dbo.Livros", "UsuAlt", c => c.Int());
            CreateIndex("dbo.Livros", "Usuarios_Id");
            CreateIndex("dbo.Livros", "Usuarios_Id1");
            CreateIndex("dbo.Livros", "Editoras_Id");
            CreateIndex("dbo.Livros", "Generos_Id");
            AddForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras", "Id");
            AddForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos", "Id");
            AddForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livros", "Usuarios_Id1", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Usuarios_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Generos_Id", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editoras_Id", "dbo.Editoras");
            DropIndex("dbo.Livros", new[] { "Generos_Id" });
            DropIndex("dbo.Livros", new[] { "Editoras_Id" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id1" });
            DropIndex("dbo.Livros", new[] { "Usuarios_Id" });
            AlterColumn("dbo.Livros", "UsuAlt", c => c.Int(nullable: false));
            AlterColumn("dbo.Livros", "UsuInc", c => c.Int(nullable: false));
            DropColumn("dbo.Livros", "Generos_Id");
            DropColumn("dbo.Livros", "Editoras_Id");
            DropColumn("dbo.Livros", "Usuarios_Id1");
            DropColumn("dbo.Livros", "Usuarios_Id");
            CreateIndex("dbo.Livros", "UsuAlt");
            CreateIndex("dbo.Livros", "UsuInc");
            CreateIndex("dbo.Livros", "Editora");
            CreateIndex("dbo.Livros", "Genero");
            AddForeignKey("dbo.Livros", "UsuInc", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "UsuAlt", "dbo.Usuarios", "Id");
            AddForeignKey("dbo.Livros", "Genero", "dbo.Generos", "Id");
            AddForeignKey("dbo.Livros", "Editora", "dbo.Editoras", "Id");
        }
    }
}
