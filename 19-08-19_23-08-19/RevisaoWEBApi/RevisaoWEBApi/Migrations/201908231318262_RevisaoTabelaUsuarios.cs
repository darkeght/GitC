namespace RevisaoWEBApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevisaoTabelaUsuarios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String(maxLength: 16));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Senha", c => c.String());
        }
    }
}
