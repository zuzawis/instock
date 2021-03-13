using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InStock.Database;
using Microsoft.EntityFrameworkCore;

namespace InStock.Controllers
{
    public class SklepController : Controller
    {
        private InStockDatabase database;
        private ManagerPowiadomien managerPowiadomien;
        private SprawdzaniePowiadomien sprawdzaniePowiadomien;
        public SklepController(InStockDatabase db, ManagerPowiadomien managerPowiadomien, SprawdzaniePowiadomien sprawdzaniePowiadomien)
        {
            this.database = db;
            this.managerPowiadomien = managerPowiadomien;
            this.sprawdzaniePowiadomien = sprawdzaniePowiadomien;
        }
        public IActionResult Index()
        {
            var model = this.database.StanSklepu.Include(x => x.Produkt).ToList();
            return View(model);
        }

        public IActionResult Przenies(int id)
        {
            var produkt = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(id));
            if (produkt != null)
            {
                return View(produkt);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Przenies(Przeniesienie przeniesienie)
        {
            var produkt = this.database.Produkty.FirstOrDefault(x => x.ProduktId.Equals(przeniesienie.ProduktId));
            if (produkt == null)
            {
                return RedirectToAction("Index");
            }
            przeniesienie.PobierzBledy(produkt).ForEach(x => { ModelState.AddModelError("", x); });
            if (!ModelState.IsValid)
            {
                return View(produkt);
            }
            produkt.OdejmijStan(przeniesienie);

            sprawdzaniePowiadomien.CzyBrakuje(produkt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XS);
            sprawdzaniePowiadomien.CzyBrakuje(produkt.ProduktId, SprawdzaniePowiadomien.Rozmiar.S);
            sprawdzaniePowiadomien.CzyBrakuje(produkt.ProduktId, SprawdzaniePowiadomien.Rozmiar.M);
            sprawdzaniePowiadomien.CzyBrakuje(produkt.ProduktId, SprawdzaniePowiadomien.Rozmiar.L);
            sprawdzaniePowiadomien.CzyBrakuje(produkt.ProduktId, SprawdzaniePowiadomien.Rozmiar.XL);

            var stanSklepu = this.database.StanSklepu.FirstOrDefault(x => x.ProduktId.Equals(przeniesienie.ProduktId));
            if (stanSklepu == null)
            {
                stanSklepu = new StanSklepu();
                stanSklepu.ProduktId = przeniesienie.ProduktId;
                this.database.StanSklepu.Add(stanSklepu);
            }
            stanSklepu.DodajStan(przeniesienie);
            this.database.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Usun(int id)
        {
            var usuniety = this.database.StanSklepu.FirstOrDefault(x => x.StanSklepuId.Equals(id));
            if (usuniety != null)
            {
                this.database.StanSklepu.Remove(usuniety);
                this.database.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}