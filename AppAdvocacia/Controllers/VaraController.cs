using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;
using AppAdvocacia.ViewModels;

namespace AppAdvocacia.Controllers
{
    public class VaraController : Controller
    {

        private ApplicationDbContext _context;

        public VaraController()
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
            var vara = _context.Vara.ToList();
            return View(vara);
        }

        public ActionResult Details(int id)
        {
            var vara = _context.Vara.SingleOrDefault(c => c.Id == id);

            if (vara == null)
                return HttpNotFound();

            return View(vara);
        }

        public ActionResult New()
        {

            var viewModel = new VaraFormViewModel { };

            return View("VaraForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Vara vara) // recebemos um cliente
        {
            if (vara.Id == 0)
            {
                // armazena o cliente em memória
                _context.Vara.Add(vara);
            }
            else
            {
                var customerInDb = _context.Vara.Single(c => c.Id == vara.Id);

                customerInDb.Nome = vara.Nome;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var vara = _context.Vara.SingleOrDefault(c => c.Id == id);

            if (vara == null)
                return HttpNotFound();

            var viewModel = new VaraFormViewModel
            {
                Vara = vara,
            };

            return View("VaraForm", viewModel);
        }


    }
}