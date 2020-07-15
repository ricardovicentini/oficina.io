using Oficina.io.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.io.Data.Repository
{
    public interface IRodizioRepository
    {
        Task<string> RetornarDiaRodizio(int finalPlaca);
        Task<List<Rodizio>> ObterTabelaRodizio();
    }
}
