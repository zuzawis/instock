using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InStock.Database;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace InStock.Controllers
{
    public class ProduktyController : Controller
    {
        private InStockDatabase database;
        private ManagerPowiadomien managerPowiadomien;
        private SprawdzaniePowiadomien sprawdzaniePowiadomien;
        public ProduktyController(InStockDatabase db, ManagerPowiadomien managerPowiadomien, SprawdzaniePowiadomien sprawdzaniePowiadomien)
        {
            this.database = db;
            this.managerPowiadomien = managerPowiadomien;
            this.sprawdzaniePowiadomien = sprawdzaniePowiadomien;
        }
        public IActionResult Index()
        {
            var lista = this.database.Produkty.OrderBy(x => x.ProduktId).ToList();
            return View(lista);
        }

        public IActionResult Dodaj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dodaj(Produkt nowyProdukt)
        {
            this.database.Produkty.Add(nowyProdukt);
            this.database.SaveChanges();

            sprawdzaniePowiadomien.CzyBrakuje(nowyProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XS);
            sprawdzaniePowiadomien.CzyBrakuje(nowyProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.S);
            sprawdzaniePowiadomien.CzyBrakuje(nowyProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.M);
            sprawdzaniePowiadomien.CzyBrakuje(nowyProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.L);
            sprawdzaniePowiadomien.CzyBrakuje(nowyProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XL);
            return RedirectToAction("Index");
        }

        public IActionResult Usun(int id)
        {
            var usuniety = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(id));
            var stanSklepu = this.database.StanSklepu.FirstOrDefault(x => x.ProduktId.Equals(id));
            if (usuniety != null)
            {
                this.database.Produkty.Remove(usuniety);
                this.database.StanSklepu.Remove(stanSklepu);
                this.database.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edycja(int id)
        {
            var edytowany = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(id));
            if (edytowany == null)
            {
                return RedirectToAction("Index");
            }

            return View(edytowany);
        }

        [HttpPost]
        public IActionResult Edycja(Produkt produkt)
        {
            var dbProdukt = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(produkt.ProduktId));
            if (dbProdukt != null)
            {
                dbProdukt.Kod = produkt.Kod;
                dbProdukt.Nazwa = produkt.Nazwa;
                dbProdukt.RozmiarXS = produkt.RozmiarXS;
                dbProdukt.RozmiarS = produkt.RozmiarS;
                dbProdukt.RozmiarM = produkt.RozmiarM;
                dbProdukt.RozmiarL = produkt.RozmiarL;
                dbProdukt.RozmiarXL = produkt.RozmiarXL;
                dbProdukt.Cena = produkt.Cena;



                this.database.SaveChanges();

                sprawdzaniePowiadomien.CzyBrakuje(dbProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XS);
                sprawdzaniePowiadomien.CzyBrakuje(dbProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.S);
                sprawdzaniePowiadomien.CzyBrakuje(dbProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.M);
                sprawdzaniePowiadomien.CzyBrakuje(dbProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.L);
                sprawdzaniePowiadomien.CzyBrakuje(dbProdukt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XL);

            }

            return RedirectToAction("Index");
        }

    }
}