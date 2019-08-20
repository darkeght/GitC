namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEditorasGeneros : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Editoras", "Ativo", c => c.Boolean());
            AddColumn("dbo.Editoras", "UsuInc", c => c.Int());
            AddColumn("dbo.Editoras", "UsuAlt", c => c.Int());
            AddColumn("dbo.Editoras", "DatInc", c => c.DateTime());
            AddColumn("dbo.Editoras", "DatAlt", c => c.DateTime());
            AddColumn("dbo.Generos", "Ativo", c => c.Boolean());
            AddColumn("dbo.Generos", "UsuInc", c => c.Int());
            AddColumn("dbo.Generos", "UsuAlt", c => c.Int());
            AddColumn("dbo.Generos", "DatInc", c => c.DateTime());
            AddColumn("dbo.Generos", "DatAlt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Generos", "DatAlt");
            DropColumn("dbo.Generos", "DatInc");
            DropColumn("dbo.Generos", "UsuAlt");
            DropColumn("dbo.Generos", "UsuInc");
            DropColumn("dbo.Generos", "Ativo");
            DropColumn("dbo.Editoras", "DatAlt");
            DropColumn("dbo.Editoras", "DatInc");
            DropColumn("dbo.Editoras", "UsuAlt");
            DropColumn("dbo.Editoras", "UsuInc");
            DropColumn("dbo.Editoras", "Ativo");
        }
    }
}
