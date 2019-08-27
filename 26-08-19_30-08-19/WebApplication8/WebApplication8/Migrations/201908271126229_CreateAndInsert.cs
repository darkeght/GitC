namespace WebApplication8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAndInsert : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bicicletas",
                c => new
                    {
                        BiciletaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Roda_RodaID = c.Int(),
                    })
                .PrimaryKey(t => t.BiciletaID)
                .ForeignKey("dbo.Rodas", t => t.Roda_RodaID)
                .Index(t => t.Roda_RodaID);
            
            CreateTable(
                "dbo.Rodas",
                c => new
                    {
                        RodaID = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.RodaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bicicletas", "Roda_RodaID", "dbo.Rodas");
            DropIndex("dbo.Bicicletas", new[] { "Roda_RodaID" });
            DropTable("dbo.Rodas");
            DropTable("dbo.Bicicletas");
        }
    }
}
