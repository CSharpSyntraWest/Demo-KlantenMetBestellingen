using Demo_KlantenMetBestellingen.Models;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Demo_KlantenMetBestellingen.Services
{
    public class MockDataService : IDataService
    {
        private IList<Klant> _klanten;
        private IList<Bestelling> _bestellingen;

        public MockDataService()
        {
            InitialiseerLijsten();
        }
        private void InitialiseerLijsten()
        {
            Klant klant1 = new Klant() { Id = 1, Voornaam = "Jan", Familienaam = "Jansen", Straat = "Kerstraat 1", PostCode = 9000, Gemeente = "Gent" };
            Klant klant2 = new Klant() { Id = 2, Voornaam = "Piet", Familienaam = "Pieters", Straat = "Molenstraat 10", PostCode = 9860, Gemeente = "Oosterzele" };
            Klant klant3 = new Klant() { Id = 3, Voornaam = "Joris", Familienaam = "Kornelis", Straat = "Sportstraat 44", PostCode = 8500, Gemeente = "Brugge" };
            Bestelling bestelling1Klant1 = new Bestelling()
            {
                BestelNr = 1,
                BestelCode = "S001",
                BestelDatum = new DateTime(2020, 12, 1),
                Omschrijving = "Strandsandalen"
                ,
                Prijs = 25.55,
                LeveringsPeriode = 14,
                IsBetaald = false,
                IsGeleverd = true,
                Klant = klant1
            };

            Bestelling bestelling2Klant1 = new Bestelling()
            {
                BestelNr = 2,
                BestelCode = "B002",
                BestelDatum = new DateTime(2020, 12, 5),
                Omschrijving = "WPF PRO boek"
                 ,
                Prijs = 55.65,
                LeveringsPeriode = 7,
                IsBetaald = false,
                IsGeleverd = false,
                Klant = klant1
            };

            Bestelling bestelling1Klant2 = new Bestelling()
            {
                BestelNr = 2,
                BestelCode = "S001",
                BestelDatum = new DateTime(2020, 12, 7),
                Omschrijving = "Strandsandalen"
               ,
                Prijs = 25.55,
                LeveringsPeriode = 14,
                IsBetaald = false,
                IsGeleverd = false,
                Klant = klant2
            };

            Bestelling bestelling1Klant3 = new Bestelling()
            {
                BestelNr = 3,
                BestelCode = "B003",
                BestelDatum = new DateTime(2020, 12, 7),
                Omschrijving = "Harry Potter boek 1"
               ,
                Prijs = 15.5,
                LeveringsPeriode = 7,
                IsBetaald = true,
                IsGeleverd = false,
                Klant = klant3
            };


            klant1.Bestellingen.Add(bestelling1Klant1);
            klant1.Bestellingen.Add(bestelling2Klant1);

            klant2.Bestellingen.Add(bestelling1Klant2);

            klant3.Bestellingen.Add(bestelling1Klant3);

            _klanten = new List<Klant>();
            _klanten.Add(klant1);
            _klanten.Add(klant2);
            _klanten.Add(klant3);


            _bestellingen = new List<Bestelling>();
            _bestellingen.Add(bestelling1Klant1);
            _bestellingen.Add(bestelling2Klant1);
            _bestellingen.Add(bestelling1Klant2);
            _bestellingen.Add(bestelling1Klant3);
        }

        public IList<Klant> GeefAlleKlanten()
        {
            return _klanten;
        }

        public IList<Bestelling> GeefAlleBestellingen()
        {
            return _bestellingen;
        }

        public IList<Klant> VoegKlantToe(Klant klant)
        {
            int newId = _klanten.Count==0? 1:_klanten.Max(k => k.Id) + 1;
            klant.Id = newId;
            _klanten.Add(klant);
            return _klanten;
        }
        public void WijzigKlant(Klant klant)
        {
            int index = _klanten.IndexOf(klant);
            if (index >= 0) _klanten[index] = klant;
        }
        public IList<Klant> VerwijderKlant(Klant klant)
        {
            _klanten.Remove(klant);
            return _klanten;
        }
        public IList<Bestelling> VoegBestellingToeVoorKlant(Bestelling bestelling, Klant klant)
        {
            int index = _klanten.IndexOf(klant);
            if (index < 0) throw new ArgumentException($"Klant id= {klant.Id} niet gevonden");
            _klanten[index].Bestellingen.Add(bestelling);
            return _klanten[index].Bestellingen;
        }
    }
}
