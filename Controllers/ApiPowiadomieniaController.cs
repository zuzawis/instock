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
    [ApiController]
    [Route("api/powiadomienia")]
    public class ApiPowiadomieniaController : ControllerBase
    {
        private InStockDatabase database;
        private ManagerPowiadomien managerPowiadomien;
        public ApiPowiadomieniaController(InStockDatabase db, ManagerPowiadomien managerPowiadomien)
        {
            this.database = db;
            this.managerPowiadomien = managerPowiadomien;
        }

        [HttpGet]
        [Route("SprawdzPowiadomienia")]
        public PowiadomieniaDTO SprawdzPowiadomienia()
        {
            managerPowiadomien.UsunStarsze();
            var powiadomienie = this.database.Powiadomienia.FirstOrDefault(x => x.CzyPrzyjete.Equals(false));
            if (powiadomienie != null)
            {
                powiadomienie.CzyPrzyjete = true;
                this.database.SaveChanges();
                return new PowiadomieniaDTO(powiadomienie);
            }
            else
            {
                return null;
            }

        }
    }
}