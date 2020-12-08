using Demo_KlantenMetBestellingen.Models;
using Demo_KlantenMetBestellingen.Services;
using Demo_KlantenMetBestellingen.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_KlantenMetBestellingen.ViewModels
{
    public class BestellingenViewModel: ObservableObject
    {
        private IDataService _dataService;
        private ObservableCollection<Bestelling> _bestellingen;
        public BestellingenViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _bestellingen = new ObservableCollection<Bestelling>(_dataService.GeefAlleBestellingen());
        }


        public ObservableCollection<Bestelling> Bestellingen
        {
            get { return _bestellingen; }
            set { OnPropertyChanged(ref _bestellingen,value); }
        }
    }
}
