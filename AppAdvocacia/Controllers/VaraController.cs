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

        public List<Vara> Vara = new List<Vara>
        {
            new Vara {Nome = "jaragua", Id = 1},
            new Vara {Nome = "joinva", Id = 2}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new VaraIndexViewModel
            {
                Vara = Vara
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Vara.Count < id)
            {
                return HttpNotFound();
            }

            var vara = Vara[id - 1];

            return View(vara);
        }

    }
}