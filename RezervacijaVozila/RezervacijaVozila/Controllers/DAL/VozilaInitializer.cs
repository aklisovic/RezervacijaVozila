using RezervacijaVozila.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RezervacijaVozila.DAL
{
    public class VozilaInitializer : DropCreateDatabaseAlways<VozilaContext>
    {
        protected override void Seed(VozilaContext context)
        {
            var marka1 = new Marka() { MarkaID = 1, Naziv = "AUDI" };
            var marka2 = new Marka() { MarkaID = 2, Naziv = "BMW" };
            var marka3 = new Marka() { MarkaID = 3, Naziv = "CITROEN" };
            var marka4 = new Marka() { MarkaID = 4, Naziv = "FIAT" };
            context.Marke.Add(marka1);
            context.Marke.Add(marka2);
            context.Marke.Add(marka3);
            context.Marke.Add(marka4);

            var vozilo1 = new Vozilo() { VoziloID = 1, Naziv = "PUNTO", GodinaProizvodnje = 2004 , Registracija = "123 AB" , BrojSjedecihMjesta = 5 , MarkaID = 4};
            var vozilo2 = new Vozilo() { VoziloID = 2, Naziv = "UNO", GodinaProizvodnje = 1997 , Registracija = "124 AB", BrojSjedecihMjesta = 4 , MarkaID = 4};
            var vozilo3 = new Vozilo() { VoziloID = 3, Naziv = "A5 Coupe", GodinaProizvodnje = 2008 , Registracija = "133 AB", BrojSjedecihMjesta = 5, MarkaID = 1 };
            var vozilo4 = new Vozilo() { VoziloID = 4, Naziv = "Berlingo", GodinaProizvodnje = 2001 , Registracija = "142 AB", BrojSjedecihMjesta = 5, MarkaID = 3 };
            var vozilo5 = new Vozilo() { VoziloID = 5, Naziv = "M5", GodinaProizvodnje = 2006 , Registracija = "153 AB", BrojSjedecihMjesta = 5, MarkaID = 2 };
            context.Vozila.Add(vozilo1);
            context.Vozila.Add(vozilo2);
            context.Vozila.Add(vozilo3);
            context.Vozila.Add(vozilo4);
            context.Vozila.Add(vozilo5);

            var Zupanija1 = new Zupanija() { ZupanijaID = 1, Naziv = "ZAGREBAČKA", PostanskiBroj = "10000", PozivniBroj = "01" };
            var Zupanija2 = new Zupanija() { ZupanijaID = 13, Naziv = "ZADARSKA", PostanskiBroj = "23000", PozivniBroj = "023" };
            var Zupanija3 = new Zupanija() { ZupanijaID = 15, Naziv = "ŠIBENSKO-KNINSKA", PostanskiBroj = "22000", PozivniBroj = "022" };
            var Zupanija4 = new Zupanija() { ZupanijaID = 17, Naziv = "SPLITSKO-DALMATINSKA", PostanskiBroj = "21000", PozivniBroj = "021" };
            var Zupanija5 = new Zupanija() { ZupanijaID = 21, Naziv = "GRAD ZAGREB", PostanskiBroj = "10000", PozivniBroj = "01" };
            context.Zupanije.Add(Zupanija1);
            context.Zupanije.Add(Zupanija2);
            context.Zupanije.Add(Zupanija3);
            context.Zupanije.Add(Zupanija4);
            context.Zupanije.Add(Zupanija5);

            var mjesto1 = new Mjesto() { MjestoID = 128, TipMjesta = "GRAD", SifraOpcine = "0175", Naziv = "Benkovac", ZupanijaID = 13 };
            var mjesto2 = new Mjesto() { MjestoID = 131, TipMjesta = "OPĆINA", SifraOpcine = "0205", Naziv = "Bibinje", ZupanijaID = 13 };
            var mjesto3 = new Mjesto() { MjestoID = 133, TipMjesta = "GRAD", SifraOpcine = "0221", Naziv = "Biograd na Moru", ZupanijaID = 13 };
            var mjesto4 = new Mjesto() { MjestoID = 199, TipMjesta = "GRAD", SifraOpcine = "0957", Naziv = "DRNIŠ", ZupanijaID = 15 };
            var mjesto5 = new Mjesto() { MjestoID = 205, TipMjesta = "GRAD", SifraOpcine = "1015", Naziv = "DUGO SELO", ZupanijaID = 1 };
            var mjesto6 = new Mjesto() { MjestoID = 233, TipMjesta = "GRAD", SifraOpcine = "1333", Naziv = "GRAD ZAGREB", ZupanijaID = 21 };
            var mjesto7 = new Mjesto() { MjestoID = 286, TipMjesta = "GRAD", SifraOpcine = "1961", Naziv = "KNIN", ZupanijaID = 15 };
            var mjesto8 = new Mjesto() { MjestoID = 1376, TipMjesta = "GRAD", SifraOpcine = "4065", Naziv = "SOLIN", ZupanijaID = 17 };
            var mjesto9 = new Mjesto() { MjestoID = 1378, TipMjesta = "GRAD", SifraOpcine = "4090", Naziv = "SPLIT", ZupanijaID = 17 };
            var mjesto10 = new Mjesto() { MjestoID = 1410, TipMjesta = "GRAD", SifraOpcine = "4448", Naziv = "ŠIBENIK", ZupanijaID = 15 };
            var mjesto11 = new Mjesto() { MjestoID = 1426, TipMjesta = "GRAD", SifraOpcine = "4634", Naziv = "TROGIR", ZupanijaID = 17 };
            var mjesto12 = new Mjesto() { MjestoID = 1476, TipMjesta = "GRAD", SifraOpcine = "5207", Naziv = "ZADAR", ZupanijaID = 13 };
            context.Mjesta.Add(mjesto1);
            context.Mjesta.Add(mjesto2);
            context.Mjesta.Add(mjesto3);
            context.Mjesta.Add(mjesto4);
            context.Mjesta.Add(mjesto5);
            context.Mjesta.Add(mjesto6);
            context.Mjesta.Add(mjesto7);
            context.Mjesta.Add(mjesto8);
            context.Mjesta.Add(mjesto9);
            context.Mjesta.Add(mjesto10);
            context.Mjesta.Add(mjesto11);
            context.Mjesta.Add(mjesto12);

            var osoba1 = new Osoba() { OsobaID = 1, Ime = "Ana", Prezime = "Anić", OIB = "12345698723", BrojVozackeDozvole = "123654", DatumRodenja = new DateTime(1990,3,10) , Adresa = "Put gimnazije 20", MjestoID = 1410 };
            var osoba2 = new Osoba() { OsobaID = 2, Ime = "Iva", Prezime = "Ivić", OIB = "12345698776", BrojVozackeDozvole = "123456", DatumRodenja = new DateTime(1980,10,16) , Adresa = "Spinutska 9", MjestoID = 1476 };
            var osoba3 = new Osoba() { OsobaID = 3, Ime = "Ante", Prezime = "Antić", OIB = "12346487231", BrojVozackeDozvole = "321654", DatumRodenja = new DateTime(1974,6,29) , Adresa = "Vukovarska 82", MjestoID = 1426 };
            var osoba4 = new Osoba() { OsobaID = 4, Ime = "Mia", Prezime = "Mikulandra", OIB = "12344659876", BrojVozackeDozvole = "321456", DatumRodenja = new DateTime(1962,12,1), Adresa = "Velimira Škorpika 63", MjestoID = 1378 };
            context.Osobe.Add(osoba1);
            context.Osobe.Add(osoba2);
            context.Osobe.Add(osoba3);
            context.Osobe.Add(osoba4);

            var rezervacija1 = new Rezervacija() { RezervacijaID = 1, VrijemeRezervacije = new DateTime(2014,4,4,4,4,4), OsobaID = 4, VoziloID = 5, BrojPrijedenihKm = 500, VrijemePreuzimanja = new DateTime(2017,7,28,8,0,0), MjestoID = 1410, AdresaPreuzimanja = "Draga 14" };
            var rezervacija2 = new Rezervacija() { RezervacijaID = 2, VrijemeRezervacije = new DateTime(2016,5,30,20,31,51), OsobaID = 2, VoziloID = 3, BrojPrijedenihKm = 200, VrijemePreuzimanja = new DateTime(2017,7,17,16,0,0), MjestoID = 1410, AdresaPreuzimanja = "Draga 14" };
            context.Rezervacije.Add(rezervacija1);
            context.Rezervacije.Add(rezervacija2);

            base.Seed(context);
        }
    }
}