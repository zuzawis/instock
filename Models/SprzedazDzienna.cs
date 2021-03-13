using System;
using InStock.Database;
using System.Collections.Generic;
using System.Linq;

namespace InStock.Models
{
    public class SprzedazDzienna
    {
        public List<SprzedazDniaElement> SprawdzSprzedazDzienna(List<Sprzedaz> sprzedaz)
        {
            var startDnia = DateTime.Now.Date;
            var koniecDnia = startDnia.AddDays(1);
            var sprzedazWyfiltrowana = sprzedaz.Where(x => x.Data >= startDnia && x.Data < koniecDnia).ToList();
            Dictionary<int, SprzedazDniaElement> dictionary = new Dictionary<int, SprzedazDniaElement>();
            foreach (var sprzedazPojedyncza in sprzedazWyfiltrowana)
            {
                if (!dictionary.ContainsKey(sprzedazPojedyncza.ProduktId))
                {
                    var elementsprzedazy = new SprzedazDniaElement();
                    elementsprzedazy.Ilosc = 0;
                    elementsprzedazy.Nazwa = sprzedazPojedyncza.Produkt.Nazwa;
                    elementsprzedazy.ProduktId = sprzedazPojedyncza.ProduktId;
                    dictionary.Add(sprzedazPojedyncza.ProduktId, elementsprzedazy);
                }

                dictionary[sprzedazPojedyncza.ProduktId].Ilosc = dictionary[sprzedazPojedyncza.ProduktId].Ilosc + sprzedazPojedyncza.RozmiarXS + sprzedazPojedyncza.RozmiarS + sprzedazPojedyncza.RozmiarM + sprzedazPojedyncza.RozmiarL + sprzedazPojedyncza.RozmiarXL;

            }
            var sprzedanyprodukt = dictionary.Values.ToList();
            return sprzedanyprodukt;
        }

        public class SprzedazDniaElement
        {
            public int Ilosc { get; set; }
            public string Nazwa { get; set; }
            public int ProduktId { get; set; }

        }

        public SprzedazDniaRozmiarow SprawdzSprzedazRozmiarow(List<Sprzedaz> sprzedaz)
        {
            var startDnia = DateTime.Now.Date;
            var koniecDnia = startDnia.AddDays(1);
            var sprzedazWyfiltrowana = sprzedaz.Where(x => x.Data >= startDnia && x.Data < koniecDnia).ToList();
            var sprzedanyrozmiar = new SprzedazDniaRozmiarow();

            foreach(var sprzedazPojedyncza in sprzedazWyfiltrowana)
            {
                sprzedanyrozmiar.IloscXS += sprzedazPojedyncza.RozmiarXS;
                sprzedanyrozmiar.IloscS += sprzedazPojedyncza.RozmiarS;
                sprzedanyrozmiar.IloscM += sprzedazPojedyncza.RozmiarM;
                sprzedanyrozmiar.IloscL += sprzedazPojedyncza.RozmiarL;
                sprzedanyrozmiar.IloscXL += sprzedazPojedyncza.RozmiarXL;
            }
          
            return sprzedanyrozmiar;
        }
        public class SprzedazDniaRozmiarow
        {
            public int IloscXS { get; set; } = 0;
            public int IloscS { get; set; } = 0;
            public int IloscM { get; set; } = 0;
            public int IloscL { get; set; } = 0;
            public int IloscXL { get; set; } = 0;

        }
    }
}