using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;

namespace AppAdvocacia.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Agenda()
        {
            var agenda = new Agenda() { Name = "Agenda" };
            return View(agenda);
        }
    }
}