﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppAdvocacia.Models;
using AppAdvocacia.ViewModels;

namespace AppAdvocacia.Controllers
{
    public class ProcessoController : Controller
    {

        private ApplicationDbContext _context;

        public ProcessoController()
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
            var processo = _context.Processo.ToList();
            return View(processo);
        }

        public ActionResult Details(int id)
        {
            var processo = _context.Processo.SingleOrDefault(c => c.Id == id);

            if (processo == null)
                return HttpNotFound();

            return View(processo);
        }

        public ActionResult New()
        {

            var viewModel = new ProcessoFormViewModel { };

            return View("ProcessoForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Processo processo) // recebemos um cliente
        {
            if (processo.Id == 0)
            {
                // armazena o cliente em memória
                _context.Processo.Add(processo);
            }
            else
            {
                var customerInDb = _context.Processo.Single(c => c.Id == processo.Id);

                customerInDb.Nome = processo.Nome;
            }

            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var processo = _context.Processo.SingleOrDefault(c => c.Id == id);

            if (processo == null)
                return HttpNotFound();

            var viewModel = new ProcessoFormViewModel
            {
                Processo = processo,
            };

            return View("ProcessoForm", viewModel);
        }

    }
}