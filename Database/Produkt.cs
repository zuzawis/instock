using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class Produkt
    {
        public int ProduktId { get; set; }
        [Required]
        public string Nazwa { get; set; }
        [Required]
        public string Kod { get; set; }
        public string Opis { get; set; }

        [Required]
        public decimal Cena { get; set; }

        public int RozmiarXS { get; set; }
        public int RozmiarS { get; set; }
        public int RozmiarM { get; set; }
        public int RozmiarL { get; set; }
        public int RozmiarXL { get; set; }

        public void OdejmijStan(Przeniesienie przeniesienie)
        {
            this.RozmiarXS -= przeniesienie.RozmiarXS;
            this.RozmiarS -= przeniesienie.RozmiarS;
            this.RozmiarM -= przeniesienie.RozmiarM;
            this.RozmiarL -= przeniesienie.RozmiarL;
            this.RozmiarXL -= przeniesienie.RozmiarXL;
        }
    }
}
