using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.Models
{
    public class Rezervacija
    {
        [Required]
        public int RezervacijaID { get; set; }

        [Required(ErrorMessage = "Polje Vrijeme rezervacije je obvezno polje za unos!")]
        [Display(Name = "Vrijeme rezervacije")]
        public DateTime VrijemeRezervacije { get; set; }

        [Required]
        public int OsobaID { get; set; }
        public virtual Osoba Osoba { get; set; }

        [Required]
        public int VoziloID { get; set; }
        public virtual Vozilo Vozilo { get; set; }

        [Required(ErrorMessage = "Polje Broj pređenih km je obvezno polje za unos!")]
        [Display(Name = "Broj prijeđenih km")]
        public int BrojPrijedenihKm { get; set; }

        [Required(ErrorMessage = "Polje Vrijeme preuzimanja je obvezno polje za unos!")]
        [Display(Name = "Vrijeme preuzimanja")]
        public DateTime VrijemePreuzimanja { get; set; }

        [Required]
        [Display(Name = "Mjesto preuzimanja")]
        public int MjestoID { get; set; }
        public virtual Mjesto Mjesto { get; set; }

        [Required(ErrorMessage = "Polje Adresa preuzimanja je obvezno polje za unos!")]
        [Display(Name = "Adresa preuzimanja")]
        public string AdresaPreuzimanja { get; set; }
    }
}