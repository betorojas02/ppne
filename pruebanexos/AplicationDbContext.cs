using Microsoft.EntityFrameworkCore;
using pruebanexos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebanexos
{
    public class AplicationDbContext: DbContext
    {

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Camarero> Camarero { get; set; }


        public AplicationDbContext()
        {

        }
        public AplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=prueba;user=root;Password=");
            }
     
        }
    }
}
