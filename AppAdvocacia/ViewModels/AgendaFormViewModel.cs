using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAdvocacia.Models;

namespace AppAdvocacia.ViewModels
{
    public class AgendaFormViewModel
    {

        public Agenda Agenda{ get; set; }
        public string Titulo
        {
            get
            {
                if (Agenda != null && Agenda.Id != 0)
                    return "Editar Agenda";

                return "Nova Agenda";
            }
        }

    }
}