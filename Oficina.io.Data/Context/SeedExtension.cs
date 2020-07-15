using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oficina.io.Data.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Oficina.io.Data.Context
{
    public static class SeedExtension
    {
        public static ModelBuilder SeedRodizio(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rodizio>().HasData(
                new Rodizio() { Id = 1, PlacaFinal = 0, DiaSemanaRodizio = "Segunda-feira" },
                new Rodizio() { Id = 2, PlacaFinal = 1, DiaSemanaRodizio = "Segunda-feira" },
                new Rodizio() { Id = 3, PlacaFinal = 2, DiaSemanaRodizio = "Terça-feira" },
                new Rodizio() { Id = 4, PlacaFinal = 3, DiaSemanaRodizio = "Terça-feira" },
                new Rodizio() { Id = 5, PlacaFinal = 4, DiaSemanaRodizio = "Quarta-feira" },
                new Rodizio() { Id = 6, PlacaFinal = 5, DiaSemanaRodizio = "Quarta-feira" },
                new Rodizio() { Id = 7, PlacaFinal = 6, DiaSemanaRodizio = "Quinta-feira" },
                new Rodizio() { Id = 8, PlacaFinal = 7, DiaSemanaRodizio = "Quinta-feira" },
                new Rodizio() { Id = 9, PlacaFinal = 8, DiaSemanaRodizio = "Sexta-feira" },
                new Rodizio() { Id = 10, PlacaFinal = 9, DiaSemanaRodizio = "Sexta-feira" }
                );
            return modelBuilder;

        }
        public static ModelBuilder SeedVeiculos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().HasData(
                new Veiculo()
                {
                    Id = 1,
                    Marca = "Ford",
                    Modelo = "Ka",
                    AnoFabricacao = 2001,
                    AnoModelo = 2002,
                    Placa = "ABC1234"

                },
                new Veiculo()
                {
                    Id = 2,
                    Marca = "GM",
                    Modelo = "Corsa",
                    AnoFabricacao = 2011,
                    AnoModelo = 2011,
                    Placa = "CDE6789"

                },
                new Veiculo()
                {
                    Id = 3,
                    Marca = "Fiat",
                    Modelo = "Uno",
                    AnoFabricacao = 2020,
                    AnoModelo = 2021,
                    Placa = "FGH0041"

                });

            return modelBuilder;
        }
    }
}
