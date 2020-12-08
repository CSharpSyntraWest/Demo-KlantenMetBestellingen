using Demo_KlantenMetBestellingen.Models;
using System.Collections.Generic;

namespace Demo_KlantenMetBestellingen.Services
{
    public interface IDataService
    {
        IList<Bestelling> GeefAlleBestellingen();
        IList<Klant> GeefAlleKlanten();
        IList<Bestelling> VoegBestellingToeVoorKlant(Bestelling bestelling, Klant klant);
        IList<Klant> VoegKlantToe(Klant klant);
    }
}