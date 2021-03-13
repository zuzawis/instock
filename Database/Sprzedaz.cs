using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class Sprzedaz
    {
        public int SprzedazId { get; set; }

        [Required]
        public int ProduktId { get; set; }
        public int StanSklepuId { get; set; }

        public Produkt Produkt { get; set; }
        public StanSklepu StanSklepu { get; set; }

        public int RozmiarXS { get; set; }
        public int RozmiarS { get; set; }
        public int RozmiarM { get; set; }
        public int RozmiarL { get; set; }
        public int RozmiarXL { get; set; }

        [Required]
        public decimal Cena { get; set; }


        [Required]
        public DateTime Data { get; set; }


        public List<string> PokazRozmiary(StanSklepu stanSklepu)
        {
            var List = new List<string>();

            if (this.RozmiarXS > stanSklepu.RozmiarXS)
            {
                List.Add("Za duzo sztuk XS");
            }
            if (this.RozmiarS > stanSklepu.RozmiarS)
            {
                List.Add("Za duzo sztuk S");
            }
            if (this.RozmiarM > stanSklepu.RozmiarM)
            {
                List.Add("Za duzo sztuk M");
            }
            if (this.RozmiarL > stanSklepu.RozmiarL)
            {
                List.Add("Za duzo sztuk L");
            }
            if (this.RozmiarXL > stanSklepu.RozmiarXL)
            {
                List.Add("Za duzo sztuk XL");
            }
            return List;

        }
    }
}

