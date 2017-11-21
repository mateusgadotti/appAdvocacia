﻿using AppAdvocacia.Models;
using AppAdvocacia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppAdvocacia.Controllers
{
    public class AdvogadoController : Controller
    {
        private ApplicationDbContext _context;

        public AdvogadoController()
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
            var advogado = _context.Advogado.ToList();
            return View(advogado);
        }

        public ActionResult Details(int id)
        {
            var advogado = _context.Advogado.SingleOrDefault(c => c.Id == id);

            if (advogado == null)
                return HttpNotFound();

            return View(advogado);
        }

        public ActionResult New()
        {

            var viewModel = new AdvogadoFormViewModel { };

            return View("Advogado", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Advogado advogado) // recebemos um advogado
        {
            if (advogado.Id == 0)
            {
                // armazena o cliente em memória
                _context.Advogado.Add(advogado);
            }
            else
            {
                var customerInDb = _context.Advogado.Single(c => c.Id == advogado.Id);

                customerInDb.Nome = advogado.Nome;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var advogado = _context.Advogado.SingleOrDefault(c => c.Id == id);

            if (advogado == null)
                return HttpNotFound();

            var viewModel = new AdvogadoFormViewModel
            {
                Advogado = advogado,
            };

            return View("AdvogadoForm", viewModel);
        }

    }
}