using Microsoft.EntityFrameworkCore;
using Oficina.io.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oficina.io.Data.Context
{
    public class OficinaDbContext : DbContext
    {
        public OficinaDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .SeedVeiculos()
                .SeedRodizio();
            
            
        }

        public DbSet<Veiculo> Carros { get; set; }
        public DbSet<Rodizio> TabelaRodizio { get; set; }
    }
}
