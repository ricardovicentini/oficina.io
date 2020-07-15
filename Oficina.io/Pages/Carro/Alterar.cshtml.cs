using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Oficina.io.Data.Models;
using Oficina.io.Data.Repository;

namespace Oficina.io.Pages.Carro
{
    public class AlterarModel : PageModel
    {
        private readonly ICarroRepository carroRepository;

        public AlterarModel(ICarroRepository carroRepository)
        {
            this.carroRepository = carroRepository;
        }
        [BindProperty]
        public Veiculo Carro { get; set; }
        public async Task OnGet(int id)
        {
            Carro = await carroRepository.ObterPorId(id);

        }

        public async Task<IActionResult> OnPost()
        {

            carroRepository.Atualizar(Carro);
            await carroRepository.Commit();
            return RedirectToPage("Index");

        }
    }
}