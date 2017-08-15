using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;

namespace AppAdvocacia.Controllers
{
    public class ProcessosController : Controller
    {
        // GET: Processos
        public ActionResult Processos()
        {
            var processos = new Processos() { Name = "Processos" };
            return View(processos);
        }
    }
}