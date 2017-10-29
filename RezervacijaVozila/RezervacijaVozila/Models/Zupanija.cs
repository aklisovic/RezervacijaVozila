using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.Models
{
    public class Zupanija
    {
        [Required]
        public int ZupanijaID { get; set; }

        [Required(ErrorMessage = "Polje Naziv županije je obvezno polje za unos!")]
        [Display(Name ="Naziv županije")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Polje Postanski broj je obvezno polje za unos!")]
        [Display(Name = "Postanski broj")]
        [MaxLength(5)]
        [MinLength(5)]
        [RegularExpression("\\d{5}", ErrorMessage = "Poštanski broj mora biti brojčana vrijednost od 5 znamenaka")]
        [DataType(DataType.PostalCode)]
        public string PostanskiBroj { get; set; }

        [Required(ErrorMessage = "Polje Pozivni broj je obvezno polje za unos!")]
        [Display(Name = "Pozivni broj")]
        [MaxLength(3)]
        [MinLength(2)]
        [RegularExpression("\\d{2,3}", ErrorMessage = "Pozivni broj mora biti brojčana vrijednost")]
        public string PozivniBroj { get; set; }
    }
}