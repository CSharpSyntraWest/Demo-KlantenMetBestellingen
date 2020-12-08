using Demo_KlantenMetBestellingen.Utilities;
using System;

namespace Demo_KlantenMetBestellingen.Models
{
    public class Bestelling : ObservableObject
    {
        //TO DO : lijst van producten bv
        private Klant _klant;
        private int _bestelNr;
        private DateTime _bestelDatum;
        private int _leveringsPeriode; //in aantal dagen
        private string _bestelCode;
        private string _omschrijving;
        private double _prijs;
        private bool _isGeleverd;
        private bool _isBetaald;

        public Klant Klant { get { return _klant; } set { OnPropertyChanged(ref _klant, value); } }
        public int BestelNr { get { return _bestelNr; } set { OnPropertyChanged(ref _bestelNr, value); } }
        public DateTime BestelDatum { get { return _bestelDatum; } set { OnPropertyChanged(ref _bestelDatum, value); } }
        public int LeveringsPeriode { get { return _leveringsPeriode; } set { OnPropertyChanged(ref _leveringsPeriode, value); } }
        public string BestelCode { get { return _bestelCode; } set { OnPropertyChanged(ref _bestelCode, value); } }
        public string Omschrijving { get { return _omschrijving; } set { OnPropertyChanged(ref _omschrijving, value); } }
        public double Prijs { get { return _prijs; } set { OnPropertyChanged(ref _prijs, value); } }
        public bool IsGeleverd { get { return _isGeleverd; } set { OnPropertyChanged(ref _isGeleverd, value); } }
        public bool IsBetaald { get { return _isBetaald; } set { OnPropertyChanged(ref _isBetaald, value); } }
    }
}