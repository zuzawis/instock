using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class TestData
    {
        public static void AddTestData(InStockDatabase context)
        {
            List<Produkt> produkty = new List<Produkt>()
            {
                new Produkt() { ProduktId = 1, Kod = "111111", Nazwa = "Tshirt basic", Cena = 34.90m, RozmiarXS = 3, RozmiarS = 2, RozmiarM = 1, RozmiarL = 2, RozmiarXL = 1 },
                new Produkt() { ProduktId = 2, Kod = "222222", Nazwa = "Spodnie jeansowe", Cena = 79.90m, RozmiarXS = 2, RozmiarS = 2, RozmiarM = 2, RozmiarL = 1, RozmiarXL = 2 },
                new Produkt() { ProduktId = 3, Kod = "333333", Nazwa = "Spodnie baggy", Cena = 99.90m, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 2, RozmiarXL = 2 },
                new Produkt() { ProduktId = 4, Kod = "444444", Nazwa = "Sweter oversize", Cena = 89.90m, RozmiarXS = 2, RozmiarS = 1, RozmiarM = 3, RozmiarL = 2, RozmiarXL = 1 },
                new Produkt() { ProduktId = 5, Kod = "555555", Nazwa = "Spodnie straight", Cena = 99.90m, RozmiarXS = 3, RozmiarS = 1, RozmiarM = 2, RozmiarL = 3, RozmiarXL = 3 },
                new Produkt() { ProduktId = 6, Kod = "666666", Nazwa = "Trencz", Cena = 149.90m, RozmiarXS = 3, RozmiarS = 3, RozmiarM = 2, RozmiarL = 2, RozmiarXL = 2 }
            };
            context.Produkty.AddRange(produkty);

            List<StanSklepu> sklep = new List<StanSklepu>()
            {
                new StanSklepu() { StanSklepuId = 1, ProduktId = 1, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
                new StanSklepu() { StanSklepuId = 2, ProduktId = 2, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
                new StanSklepu() { StanSklepuId = 3, ProduktId = 3, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
                new StanSklepu() { StanSklepuId = 4, ProduktId = 4, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
                new StanSklepu() { StanSklepuId = 5, ProduktId = 5, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
                new StanSklepu() { StanSklepuId = 6, ProduktId = 6, RozmiarXS = 1, RozmiarS = 1, RozmiarM = 1, RozmiarL = 1, RozmiarXL = 1 },
            };
            context.StanSklepu.AddRange(sklep);

            List<Sprzedaz> sprzedaz = new List<Sprzedaz>()
            {
                new Sprzedaz() { Cena=20, Data = DateTime.Now.AddHours(-5),  RozmiarXL=0, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 1, ProduktId=1 },
                new Sprzedaz() { Cena=30, Data = DateTime.Now.AddHours(-4),  RozmiarXL=0, RozmiarL=0, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 3, ProduktId=3 },
                new Sprzedaz() { Cena=50, Data = DateTime.Now.AddHours(-3),  RozmiarXL=0, RozmiarL=1, RozmiarM=0, RozmiarS=1, RozmiarXS=0, StanSklepuId = 2, ProduktId=2 },
                new Sprzedaz() { Cena=37, Data = DateTime.Now.AddHours(-2),  RozmiarXL=1, RozmiarL=0, RozmiarM=1, RozmiarS=0, RozmiarXS=0, StanSklepuId = 1, ProduktId=1 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddHours(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 4, ProduktId=4 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddHours(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 5, ProduktId=5 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddHours(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 6, ProduktId=6 },
                
                new Sprzedaz() { Cena=20, Data = DateTime.Now.AddDays(-5),  RozmiarXL=0, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 1, ProduktId=1 },
                new Sprzedaz() { Cena=30, Data = DateTime.Now.AddDays(-4),  RozmiarXL=0, RozmiarL=0, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 3, ProduktId=3 },
                new Sprzedaz() { Cena=50, Data = DateTime.Now.AddDays(-3),  RozmiarXL=0, RozmiarL=1, RozmiarM=0, RozmiarS=1, RozmiarXS=0, StanSklepuId = 2, ProduktId=2 },
                new Sprzedaz() { Cena=37, Data = DateTime.Now.AddDays(-2),  RozmiarXL=1, RozmiarL=0, RozmiarM=1, RozmiarS=0, RozmiarXS=0, StanSklepuId = 1, ProduktId=1 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 4, ProduktId=4 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 5, ProduktId=5 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-1),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 6, ProduktId=6 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-25),  RozmiarXL=1, RozmiarL=1, RozmiarM=1, RozmiarS=1, RozmiarXS=1, StanSklepuId = 6, ProduktId=6 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-20),  RozmiarXL=1, RozmiarL=1, RozmiarM=0, RozmiarS=1, RozmiarXS=0, StanSklepuId = 6, ProduktId=6 },
                new Sprzedaz() { Cena=70, Data = DateTime.Now.AddDays(-19),  RozmiarXL=0, RozmiarL=0, RozmiarM=1, RozmiarS=1, RozmiarXS=0, StanSklepuId = 6, ProduktId=6 },
            };
            context.Sprzedaz.AddRange(sprzedaz);

            List<Powiadomienie> powiadomienie = new List<Powiadomienie>()
            {
                new Powiadomienie() { Tytul="testowe powiadomienie", Opis="testowe powiadomienie", Data=DateTime.Now.AddDays(-2), CzyPrzyjete=false },
                new Powiadomienie() { Tytul="testowe powiadomienie", Opis="testowe powiadomienie", Data=DateTime.Now.AddDays(-1), CzyPrzyjete=false },
                new Powiadomienie() { Tytul="testowe powiadomienie", Opis="testowe powiadomienie", Data=DateTime.Now.AddDays(-5), CzyPrzyjete=false },
                new Powiadomienie() { Tytul="testowe powiadomienie", Opis="testowe powiadomienie", Data=DateTime.Now.AddDays(-7), CzyPrzyjete=false },
                new Powiadomienie() { Tytul="testowe powiadomienie", Opis="testowe powiadomienie", Data=DateTime.Now.AddDays(-8), CzyPrzyjete=false },
            };
            context.Powiadomienia.AddRange(powiadomienie);

            context.SaveChanges();
        }
    }
}
