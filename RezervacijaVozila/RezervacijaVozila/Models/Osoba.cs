using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.Models
{
    public class Osoba
    {
        [Required]
        public int OsobaID { get; set; }

        [Required(ErrorMessage = "Polje Ime je obvezno polje za unos!")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Polje Prezime je obvezno polje za unos!")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Polje OIB je obvezno polje za unos!")]
        [MaxLength(11)]
        [MinLength(11)]
        [RegularExpression("\\d{11}", ErrorMessage = "OIB mora biti brojčana vrijednost od 11 znamenaka")]
        public string OIB { get; set; }

        [Required(ErrorMessage = "Polje Broj vozaćke dozvole je obvezno polje za unos!")]
        [Display(Name = "Broj vozaćke dozvole")]
        public string BrojVozackeDozvole { get; set; }

        [Required(ErrorMessage = "Polje Datum rođenja je obvezno polje za unos!")]
        [Display(Name = "Datum rođenja")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DatumRodenja { get; set; }

        [Required(ErrorMessage = "Polje Adresa je obvezno polje za unos!")]
        public string Adresa { get; set; }

        [Required]
        public int MjestoID { get; set; }
        public virtual Mjesto Mjesto { get; set; }
    }
}