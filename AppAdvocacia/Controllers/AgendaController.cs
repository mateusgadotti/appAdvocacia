using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;
using AppAdvocacia.ViewModels;

namespace AppAdvocacia.Controllers
{
    public class AgendaController : Controller
    {

        public List<Agenda> Agendas = new List<Agenda>
        {
            new Agenda {nome = "Ir ao mercado", Id = 1},
            new Agenda {nome = "Ir ao banheiro", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new AgendaIndexViewModel
            {
                Agendas = Agendas
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Agendas.Count < id)
            {
                return HttpNotFound();
            }

            var agenda = Agendas[id - 1];

            return View(agenda);
        }
    }
}