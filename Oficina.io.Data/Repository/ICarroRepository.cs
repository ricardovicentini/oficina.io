using Microsoft.EntityFrameworkCore;
using Oficina.io.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oficina.io.Data.Repository
{
    public interface ICarroRepository
    {
        DbSet<Veiculo> Carros { get; }
        void Adicionar(Veiculo carro);
        Task<IEnumerable<Veiculo>> Listar();
        Task<Veiculo> ObterPorId(int id);
        void Atualizar(Veiculo carro);
        void Excluir(int id);
        Task Commit();
    }
}
