using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class Powiadomienie
    {
        public int PowiadomienieId { get; set; }

        [Required]
        public string Tytul { get; set; }

        [Required]
        public string Opis { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public bool CzyPrzyjete { get; set; }

    }
}