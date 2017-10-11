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

        private ApplicationDbContext _context;

        public AgendaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var agenda = _context.Agenda.ToList();
            return View(agenda);
        }

        public ActionResult Details(int id)
        {
            var agenda = _context.Agenda.SingleOrDefault(c => c.Id == id);

            if (agenda == null)
                return HttpNotFound();

            return View(agenda);
        }

        public ActionResult New()
        {

            var viewModel = new AgendaFormViewModel { };

            return View("AgendaForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Agenda agenda) // recebemos um cliente
        {
            if (agenda.Id == 0)
            {
                // armazena o cliente em memória
                _context.Agenda.Add(agenda);
            }
            else
            {
                var customerInDb = _context.Agenda.Single(c => c.Id == agenda.Id);

                customerInDb.Nome = agenda.Nome;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var agenda = _context.Agenda.SingleOrDefault(c => c.Id == id);

            if (agenda == null)
                return HttpNotFound();

            var viewModel = new AgendaFormViewModel
            {
                Agenda = agenda,
            };

            return View("AgendaForm", viewModel);
        }


    }
}