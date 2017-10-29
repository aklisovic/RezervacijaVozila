using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.Models
{
    public class Marka
    {
        [Required]
        public int MarkaID { get; set; }

        [Required(ErrorMessage = "Polje Naziv marke je obvezno polje za unos!")]
        [Display(Name = "Naziv marke")]
        public string Naziv { get; set; }
    }
}