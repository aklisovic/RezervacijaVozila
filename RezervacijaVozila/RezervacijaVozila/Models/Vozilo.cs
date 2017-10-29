using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RezervacijaVozila.Models
{
    public class Vozilo
    {
        [Required]
        public int VoziloID { get; set; }

        [Required(ErrorMessage = "Polje Model je obvezno polje za unos!")]
        [Display(Name = "Model")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Polje Godina proizvodnje je obvezno polje za unos!")]
        [Display(Name = "Godina proizvodnje")]
        [Range(1900, int.MaxValue)]
        public int GodinaProizvodnje { get; set; }

        [Required(ErrorMessage = "Polje Registracija je obvezno polje za unos!")]
        public string Registracija { get; set; }

        [Required(ErrorMessage = "Polje Broj sjedećih mjesta je obvezno polje za unos!")]
        [Display(Name = "Broj sjedećih mjesta")]
        public int BrojSjedecihMjesta { get; set; }

        [Required]
        public int MarkaID { get; set; }
        public virtual Marka Marka { get; set; }
    }
}