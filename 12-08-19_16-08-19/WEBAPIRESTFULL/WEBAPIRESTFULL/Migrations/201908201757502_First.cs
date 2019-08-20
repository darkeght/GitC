namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Registro = c.Int(nullable: false),
                        Titulo = c.String(nullable: false, maxLength: 1200, unicode: false),
                        Isbn = c.String(nullable: false, maxLength: 15, unicode: false),
                        Genero = c.Int(nullable: false),
                        Editora = c.Int(nullable: false),
                        Sinopse = c.String(),
                        Observacoes = c.String(maxLength: 1000, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Editoras", t => t.Editora)
                .ForeignKey("dbo.Generos", t => t.Genero)
                .ForeignKey("dbo.Usuarios", t => t.UsuAlt)
                .ForeignKey("dbo.Usuarios", t => t.UsuInc)
                .Index(t => t.Genero)
                .Index(t => t.Editora)
                .Index(t => t.UsuInc)
                .Index(t => t.UsuAlt);
            
            CreateTable(
                "dbo.Editoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Generos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Livro = c.Int(nullable: false),
                        Usuario = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Devolucao = c.DateTime(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuAlt)
                .ForeignKey("dbo.Usuarios", t => t.Usuario)
                .ForeignKey("dbo.Usuarios", t => t.UsuInc)
                .ForeignKey("dbo.Livros", t => t.Livro)
                .Index(t => t.Livro)
                .Index(t => t.Usuario)
                .Index(t => t.UsuInc)
                .Index(t => t.UsuAlt);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Login = c.String(nullable: false, maxLength: 50, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 50, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Ativo = c.Boolean(),
                        UsuInc = c.Int(),
                        UsuAlt = c.Int(),
                        DatInc = c.DateTime(),
                        DatAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LivroAutor",
                c => new
                    {
                        Autor = c.Int(nullable: false),
                        Livro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Autor, t.Livro })
                .ForeignKey("dbo.Autores", t => t.Autor, cascadeDelete: true)
                .ForeignKey("dbo.Livros", t => t.Livro, cascadeDelete: true)
                .Index(t => t.Autor)
                .Index(t => t.Livro);



            
        }
        
        public override void Down()
        {


            DropForeignKey("dbo.LivroAutor", "Livro", "dbo.Livros");
            DropForeignKey("dbo.LivroAutor", "Autor", "dbo.Autores");
            DropForeignKey("dbo.Locacao", "Livro", "dbo.Livros");
            DropForeignKey("dbo.Locacao", "UsuInc", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "Usuario", "dbo.Usuarios");
            DropForeignKey("dbo.Locacao", "UsuAlt", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "UsuInc", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "UsuAlt", "dbo.Usuarios");
            DropForeignKey("dbo.Livros", "Genero", "dbo.Generos");
            DropForeignKey("dbo.Livros", "Editora", "dbo.Editoras");
            DropIndex("dbo.LivroAutor", new[] { "Livro" });
            DropIndex("dbo.LivroAutor", new[] { "Autor" });
            DropIndex("dbo.Locacao", new[] { "UsuAlt" });
            DropIndex("dbo.Locacao", new[] { "UsuInc" });
            DropIndex("dbo.Locacao", new[] { "Usuario" });
            DropIndex("dbo.Locacao", new[] { "Livro" });
            DropIndex("dbo.Livros", new[] { "UsuAlt" });
            DropIndex("dbo.Livros", new[] { "UsuInc" });
            DropIndex("dbo.Livros", new[] { "Editora" });
            DropIndex("dbo.Livros", new[] { "Genero" });
            DropTable("dbo.LivroAutor");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacao");
            DropTable("dbo.Generos");
            DropTable("dbo.Editoras");
            DropTable("dbo.Livros");
            DropTable("dbo.Autores");
        }
    }
}
