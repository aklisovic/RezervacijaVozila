using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.Models
{
    public class Mjesto
    {
        [Required]
        public int MjestoID { get; set; }

        [Required(ErrorMessage = "Polje Naziv mjesta je obvezno polje za unos!")]
        [Display(Name = "Naziv mjesta")]
        public string Naziv { get; set; }

        [Display(Name ="Tip mjesta")]
        public string TipMjesta { get; set; }

        [Required(ErrorMessage = "Polje Šifra općine je obvezno polje za unos!")]
        [Display(Name = "Šifra općine")]
        public string SifraOpcine { get; set; }

        [Required(ErrorMessage = "Polje Naziv županije je obvezno polje za unos!")]
        [Display(Name = "Naziv županije")]
        public int ZupanijaID { get; set; }
        public virtual Zupanija Zupanija { get; set; }
    }
}