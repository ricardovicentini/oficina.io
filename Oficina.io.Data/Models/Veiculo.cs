using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oficina.io.Data.Models
{
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Requirido"),
            MinLength(2,ErrorMessage ="mínimo de 2"), 
            MaxLength(20,ErrorMessage ="máximo de 20"),
            Display(Name ="Marca")]
        
        public string Marca { get; set; }
        [Required(ErrorMessage = "Requirido")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Requirido"),Display(Name ="Ano de Fabricação"),Range(1965,2040,ErrorMessage ="Ano inválido")]
        public int AnoFabricacao { get; set; }
        [Required(ErrorMessage = "Requirido"),Display(Name = "Ano do Modelo"), Range(1965, 2040, ErrorMessage = "Ano inválido")]
        public int AnoModelo { get; set; }
        [Required(ErrorMessage = "Requirido"), StringLength(8)]
        public string Placa { get; set; }
    }
}
