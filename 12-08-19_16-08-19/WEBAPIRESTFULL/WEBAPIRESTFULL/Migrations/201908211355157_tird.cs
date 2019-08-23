namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tird : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Livros", "Ativo", c => c.Boolean());
            AlterColumn("dbo.Livros", "DatInc", c => c.DateTime());
            AlterColumn("dbo.Livros", "DatAlt", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Livros", "DatAlt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Livros", "DatInc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Livros", "Ativo", c => c.Boolean(nullable: false));
        }
    }
}
