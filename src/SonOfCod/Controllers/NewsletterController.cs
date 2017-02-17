using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enroll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Enroll(NewsletterRecipient newRecipient)
        {
            db.Recipients.Add(newRecipient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
