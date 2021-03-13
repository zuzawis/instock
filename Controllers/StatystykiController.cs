using Microsoft.AspNetCore.Mvc;
using InStock.Database;
using System.Linq;
using InStock.Models;

namespace InStock.Controllers
{
    public class StatystykiController : Controller
    {
        private InStockDatabase database;
        private ManagerPowiadomien managerPowiadomien;
        public StatystykiController(InStockDatabase db, ManagerPowiadomien managerPowiadomien)
        {
            this.database = db;
            this.managerPowiadomien = managerPowiadomien;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SprzedazDnia()
        {
            var sprzedaze = this.database.Sprzedaz.ToList();
            var sprzedazdzienna = new SprzedazDzienna();
            var zmienna = sprzedazdzienna.SprawdzSprzedazDzienna(sprzedaze);
            return View(zmienna);
        }

        public IActionResult SprzedazRozmiarowek()
        {
            var sprzedaze = this.database.Sprzedaz.ToList();
            var sprzedazdzienna = new SprzedazDzienna();
            var rozmiar = sprzedazdzienna.SprawdzSprzedazRozmiarow(sprzedaze);   
            return View(rozmiar);
        }

        public IActionResult SprzedazMiesieczna()
        {
            var sprzedaze = this.database.Sprzedaz.ToList();
            var sprzedazmiesieczna = new SprzedazMiesieczna();
            var sprzedaneprodukty = sprzedazmiesieczna.SprawdzSprzedazMiesieczna(sprzedaze, database);
            return View(sprzedaneprodukty);
        }
    }
}