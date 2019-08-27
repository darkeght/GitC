using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class ContextDB : DbContext
    {
        public DbSet<Bicicleta> Bicicletas { get; set; }
        public DbSet<Roda> Rodas { get; set; }
    }
}