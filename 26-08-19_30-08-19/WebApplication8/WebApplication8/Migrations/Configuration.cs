namespace WebApplication8.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication8.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication8.Models.ContextDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication8.Models.ContextDB context)
        {
            var listRodas = new List<Roda>()
            {
                new Roda(){Descricao = "Rebaxei aro 16"},
                new Roda(){Descricao = "Rebaxei aro 20"},
            };

            listRodas.ForEach(s => context.Rodas.AddOrUpdate(p => p.Descricao, s));
            context.SaveChanges();
        }
    }
}
