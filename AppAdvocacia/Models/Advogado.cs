using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppAdvocacia.Models
{
    public class Advogado
    {

        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        public string CPF { get; set; }

    }
}