using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class StanSklepu
    {
        public int StanSklepuId { get; set; }

        public int ProduktId { get; set; }
        public Produkt Produkt { get; set; }

        public int RozmiarXS { get; set; }
        public int RozmiarS { get; set; }
        public int RozmiarM { get; set; }
        public int RozmiarL { get; set; }
        public int RozmiarXL { get; set; }
        public int Ilosc { get; set; }


        public void DodajStan(Przeniesienie przeniesienie)
        {
            this.RozmiarXS += przeniesienie.RozmiarXS;
            this.RozmiarS += przeniesienie.RozmiarS;
            this.RozmiarM += przeniesienie.RozmiarM;
            this.RozmiarL += przeniesienie.RozmiarL;
            this.RozmiarXL += przeniesienie.RozmiarXL;
        }

        public void OdejmijStan(Sprzedaz sprzedany)
        {
            this.RozmiarXS -= sprzedany.RozmiarXS;
            this.RozmiarS -= sprzedany.RozmiarS;
            this.RozmiarM -= sprzedany.RozmiarM;
            this.RozmiarL -= sprzedany.RozmiarL;
            this.RozmiarXL -= sprzedany.RozmiarXL;
        }
    }
}
