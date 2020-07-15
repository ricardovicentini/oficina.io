using Microsoft.EntityFrameworkCore;
using Oficina.io.Data.Context;
using Oficina.io.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.io.Data.Repository
{
    public class CarroRepository : ICarroRepository
    {
        private readonly OficinaDbContext db;
        public DbSet<Veiculo> Carros { get; }

        public CarroRepository(OficinaDbContext db)
        {
            this.db = db;
            Carros = db.Set<Veiculo>();
            db.Database.EnsureCreated();//só pq é inmemory db
        }


        public void Adicionar(Veiculo carro)
        {
            db.Add(carro);
        }

        public void Atualizar(Veiculo carro)
        {
            var entity = ObterPorId(carro.Id).Result;
            entity.Marca = carro.Marca;
            entity.Modelo = carro.Modelo;
            entity.AnoFabricacao = carro.AnoFabricacao;
            entity.AnoModelo = carro.AnoModelo;
            entity.Placa = carro.Placa;
        }

        public void Excluir(int id)
        {
            var carro = ObterPorId(id).Result;
            if (carro != null)
                Carros.Remove(carro);

        }

        public async Task<IEnumerable<Veiculo>> Listar()
        {
            return await Carros.ToListAsync();
        }

        public async Task Commit()
        {
            await db.SaveChangesAsync();
        }

        public async Task<Veiculo> ObterPorId(int id)
        {
            return await Carros.FindAsync(id);
        }
    }
}
