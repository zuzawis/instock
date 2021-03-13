using System;
using InStock.Database;
using System.Collections.Generic;
using System.Linq;

namespace InStock.Models
{
    public class SprzedazMiesieczna
    {
        public class SprzedazMiesiecznaPodsumowanie
        {
            public List<SprzedazMiesiecznaElement> SprzedazMiesieczna { get; set; } = new List<SprzedazMiesiecznaElement>();
            public string Data { get; set;}
        }

        public class SprzedazMiesiecznaElement
        {
            public int Ilosc { get; set; }
            public string Nazwa { get; set; }
            public int ProductId { get; set; }  
        }

        public List<SprzedazMiesiecznaPodsumowanie> SprawdzSprzedazMiesieczna(List<Sprzedaz> sprzedaz, InStockDatabase db)
        {
            var sprzedazMiesiecznaPodsumowanie = new List<SprzedazMiesiecznaPodsumowanie>();
            var koniecMiesiaca = DateTime.Now.Date.AddDays(1); 
            var startMiesiaca = koniecMiesiaca.AddDays(-30);
            var sprzedazWyfiltrowana = sprzedaz.Where(x => x.Data >= startMiesiaca && x.Data < koniecMiesiaca).ToList();
            
            var listaProduktow = db.Produkty.ToList();
            for (int i = 0; i <= 30; i++)
            {
                var dzien = DateTime.Now.AddDays(-i).Date;
                var sprzedazDnia = sprzedazWyfiltrowana.Where(x => x.Data.Date.Equals(dzien)).ToList();
                var pojedynczaSprzedazDzienna = new SprzedazMiesiecznaPodsumowanie();
                pojedynczaSprzedazDzienna.Data = dzien.ToString("yyyy-MM-dd");
                foreach (var produkt in listaProduktow)
                {
                    int ilosc = 0;
                    var sprzedazProduktu = sprzedazDnia.Where(x => x.ProduktId.Equals(produkt.ProduktId)).ToList();
                    sprzedazProduktu.ForEach(p => { ilosc = ilosc + p.RozmiarXS + p.RozmiarS + p.RozmiarM + p.RozmiarL + p.RozmiarXL; });
                    var sprzedazMiesiecznaElement = new SprzedazMiesiecznaElement();
                    sprzedazMiesiecznaElement.Nazwa = produkt.Nazwa;
                    sprzedazMiesiecznaElement.ProductId = produkt.ProduktId;
                    sprzedazMiesiecznaElement.Ilosc = ilosc;
                    pojedynczaSprzedazDzienna.SprzedazMiesieczna.Add(sprzedazMiesiecznaElement);
                }
                sprzedazMiesiecznaPodsumowanie.Add(pojedynczaSprzedazDzienna);
            }

            return sprzedazMiesiecznaPodsumowanie.OrderBy(x => x.Data).ToList();
        }
    }
}