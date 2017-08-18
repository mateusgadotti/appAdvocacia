using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppAdvocacia.Models
{
    public class ContextoCliente : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        
    }
}