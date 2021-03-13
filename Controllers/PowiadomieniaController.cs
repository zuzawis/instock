using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InStock.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Razor;

namespace InStock.Controllers
{
    public class PowiadomieniaController : Controller
    {
        private InStockDatabase database;
        public PowiadomieniaController(InStockDatabase db)
        {
            this.database = db;
        }
        public IActionResult Index()
        {
            var lista = this.database.Powiadomienia.OrderByDescending(x => x.Data).ToList();
            return View(lista);
        }

        public IActionResult Usun(int id)
        {
            var usuniety = this.database.Powiadomienia.FirstOrDefault(x => x.PowiadomienieId.Equals(id));
            if (usuniety != null)
            {
                this.database.Powiadomienia.Remove(usuniety);
                this.database.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}