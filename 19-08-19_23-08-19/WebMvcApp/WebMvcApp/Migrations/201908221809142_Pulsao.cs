namespace WebMvcApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pulsao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pessoas", "UsuarioCriacao", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "UsuarioAlteracao", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "DataCriacao", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pessoas", "DataAlteracao", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "DataAlteracao");
            DropColumn("dbo.Pessoas", "DataCriacao");
            DropColumn("dbo.Pessoas", "UsuarioAlteracao");
            DropColumn("dbo.Pessoas", "UsuarioCriacao");
            DropColumn("dbo.Pessoas", "Ativo");
        }
    }
}
