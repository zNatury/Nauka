using Nauka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nauka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var contacts = new List<Contact> { new Contact { Name = "Jakub", Surname = "Lipka", City = "Warszawa", Street = "Morro" },
                new Contact{ Name = "Wioletta", Surname = "WIlczek", City = "Warszawa", Street = "Anielewicza"},
                new Contact{ Name = "Marek", Surname = "Szewczyk", City = "Warszawa", Street = "Bryły"}        
            };
            string path = @"C:\Users\jakub.lipka\Pictures\Memory\";
            var pictures = new List<Picture> { new Picture { name = "Doda", sourcePath = @"doda.png" },
            new Picture { name = "Kuba", sourcePath = "kuba.png" } };            
            ViewBag.Pictures = pictures;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}