using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppAdvocacia.Models
{
    public class Agenda
    {

        [Key]
        public int codigo { get; set; }

        public string tarefa { get; set; }

        public DateTime data { get; set; }

        public string nomeAdvogado { get; set; }
    }
}