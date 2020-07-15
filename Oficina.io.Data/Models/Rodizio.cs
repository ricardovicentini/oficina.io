using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oficina.io.Data.Models
{
    public class Rodizio
    {
        [Key]
        public int Id { get; set; }
        [Range(0,9)]
        public int PlacaFinal { get; set; }
        public string DiaSemanaRodizio { get; set; }
    }
}
