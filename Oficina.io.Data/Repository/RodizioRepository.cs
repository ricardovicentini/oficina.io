using Microsoft.EntityFrameworkCore;
using Oficina.io.Data.Context;
using Oficina.io.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.io.Data.Repository
{
    public class RodizioRepository : IRodizioRepository
    {
        private readonly OficinaDbContext oficinaDbContext;

        public RodizioRepository(OficinaDbContext oficinaDbContext)
        {
            this.oficinaDbContext = oficinaDbContext;
            oficinaDbContext.Database.EnsureCreated();
        }

        public async Task<List<Rodizio>> ObterTabelaRodizio()
        {
            return await oficinaDbContext.TabelaRodizio.AsNoTracking().ToListAsync();
        }

        public async Task<string> RetornarDiaRodizio(int finalPlaca)
        {
            var rodizio = await oficinaDbContext.TabelaRodizio.Where(p => p.PlacaFinal == finalPlaca).SingleOrDefaultAsync();
            return rodizio.DiaSemanaRodizio;
        }
    }
}
