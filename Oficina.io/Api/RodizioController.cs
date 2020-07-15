using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Oficina.io.Data.Repository;

namespace Oficina.io.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RodizioController : ControllerBase
    {
        private readonly IRodizioRepository rodizioRepository;

        public RodizioController(IRodizioRepository rodizioRepository)
        {
            this.rodizioRepository = rodizioRepository;
        }
        [HttpGet("{placa}")]
        public async Task<IActionResult> DiaSemana(string placa)
        {
            int placaFinal = int.TryParse(placa.Substring(placa.Length - 1), out placaFinal) ? placaFinal : 0;
            var diaSemana = await rodizioRepository.RetornarDiaRodizio(placaFinal);
            return new JsonResult(diaSemana);
        }
        [HttpGet]
        public async Task<IActionResult> Tabela()
        {
            var tabela = await rodizioRepository.ObterTabelaRodizio();
            return new JsonResult(new { data = tabela });
        }
    }
}
