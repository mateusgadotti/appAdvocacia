using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppAdvocacia.Models
{
    public class ContextoAgenda : DbContext
    {
        public DbSet<Agenda> Agenda{ get; set; }

    }
}