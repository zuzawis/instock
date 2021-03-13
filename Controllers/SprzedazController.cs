using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InStock.Database;
using Microsoft.EntityFrameworkCore;


namespace InStock.Controllers
{
    public class SprzedazController : Controller
    {
        private InStockDatabase database;
        private ManagerPowiadomien managerPowiadomien;
        private SprawdzaniePowiadomien sprawdzaniePowiadomien;
        public SprzedazController(InStockDatabase db, ManagerPowiadomien managerPowiadomien, SprawdzaniePowiadomien sprawdzaniePowiadomien)
        {
            this.database = db;
            this.managerPowiadomien = managerPowiadomien;
            this.sprawdzaniePowiadomien = sprawdzaniePowiadomien;
        }

        public IActionResult Index()
        {
            var model = this.database.Sprzedaz.Include(x => x.Produkt).OrderByDescending(x => x.Data).ToList();
            return View(model);
        }

        public IActionResult Sprzedaj(int id)
        {
            var sprzedany = this.database.StanSklepu.FirstOrDefault(x => x.StanSklepuId.Equals(id));
            if (sprzedany == null)
            {
                return RedirectToAction("Index");
            }
            return View(sprzedany);
        }

        [HttpPost]
        public IActionResult Sprzedaj(Sprzedaz sprzedawanie)
        {
            var stanSklepu = this.database.StanSklepu.Include(x => x.Produkt).FirstOrDefault(x => x.StanSklepuId.Equals(sprzedawanie.StanSklepuId));
            if (stanSklepu == null)
            {
                return RedirectToAction("Index");
            }
            sprzedawanie.PokazRozmiary(stanSklepu).ForEach(x => { ModelState.AddModelError("", x); });

            if (!ModelState.IsValid)
            {
                return View(stanSklepu);
            }
            stanSklepu.OdejmijStan(sprzedawanie);
            sprzedawanie.Data = DateTime.Now;
            this.database.Sprzedaz.Add(sprzedawanie);
            this.database.SaveChanges();

            sprawdzaniePowiadomien.JakSieSprzedaje(stanSklepu.ProduktId);

            sprawdzaniePowiadomien.CzyBrakujeNaSklepie(stanSklepu.ProduktId, SprawdzaniePowiadomien.Rozmiar.XS);
            sprawdzaniePowiadomien.CzyBrakujeNaSklepie(stanSklepu.ProduktId, SprawdzaniePowiadomien.Rozmiar.S);
            sprawdzaniePowiadomien.CzyBrakujeNaSklepie(stanSklepu.ProduktId, SprawdzaniePowiadomien.Rozmiar.M);
            sprawdzaniePowiadomien.CzyBrakujeNaSklepie(stanSklepu.ProduktId, SprawdzaniePowiadomien.Rozmiar.L);
            sprawdzaniePowiadomien.CzyBrakujeNaSklepie(stanSklepu.ProduktId, SprawdzaniePowiadomien.Rozmiar.XL);

            return RedirectToAction("Index");
        }

    }
}