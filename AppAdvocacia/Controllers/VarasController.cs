using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;

namespace AppAdvocacia.Controllers
{
    public class VarasController : Controller
    {
        // GET: Varas
        public ActionResult Varas()
        {
            var varas = new Varas() { Name = "Varas" };
            return View(varas);
        }
    }
}