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
        public List<Processo> Processo = new List<Processo>
        {
            new Processo {Nome = "Gyzz", Id = 1},
            new Processo {Nome = "Jeff Seid", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new ProcessoIndexViewModel
            {
                Processo = Processo
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Processo.Count < id)
            {
                return HttpNotFound();
            }

            var processo = Processo[id - 1];

            return View(processo);
        }
    }
}