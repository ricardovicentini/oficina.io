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
    public class IndexModel : PageModel
    {
        private readonly ICarroRepository carroRepository;

        public IndexModel(ICarroRepository carroRepository)
        {
            this.carroRepository = carroRepository;
        }
        
        public IEnumerable<Veiculo> Carros { get; set; }

        public async Task OnGet()
        {
            Carros = await carroRepository.Listar();
        }

        public IActionResult OnPostExcluir(int id)
        {
            carroRepository.Excluir(id);
            carroRepository.Commit();
            return RedirectToPage("Index");
        }
    }
}