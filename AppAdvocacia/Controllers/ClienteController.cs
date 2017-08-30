using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;
using AppAdvocacia.ViewModels;


namespace AppAdvocacia.Controllers
{
    public class ClienteController : Controller
    {
        public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {Nome = "Gyzz", Id = 1},
            new Cliente {Nome = "Jeff Seid", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new ClienteIndexViewModel
            {
                Clientes = Clientes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Clientes.Count < id)
            {
                return HttpNotFound();
            }

            var cliente = Clientes[id - 1];

            return View(cliente);
        }
    }
}