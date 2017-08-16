using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;

namespace AppAdvocacia.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Cliente()
        {
            var cliente = new Cliente() { Nome = "Cliente"};
            return View(cliente);
        }
    }
}