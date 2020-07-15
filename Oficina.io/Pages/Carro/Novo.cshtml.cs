using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oficina.io.Data.Models;
using Oficina.io.Data.Repository;

namespace Oficina.io.Pages.Carro
{
    public class NovoModel : PageModel
    {
        private readonly ICarroRepository carroRepository;

        public NovoModel(ICarroRepository carroRepository)
        {
            this.carroRepository = carroRepository;
        }
        [BindProperty]
        public Veiculo Carro { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                carroRepository.Adicionar(Carro);
                carroRepository.Commit();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
            
        }
    }
}