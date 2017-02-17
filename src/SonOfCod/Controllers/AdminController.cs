using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult MailingList()
        {
            return View(db.Recipients.ToList());
        }
    }
}
