using Demo_KlantenMetBestellingen.Models;
using Demo_KlantenMetBestellingen.Services;
using Demo_KlantenMetBestellingen.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo_KlantenMetBestellingen.ViewModels
{
    public class KlantenViewModel:ObservableObject
    {
        private IDataService _dataService;
        private ObservableCollection<Klant> _klanten;
        public KlantenViewModel(IDataService dataService)
        {
            _dataService = dataService;
            Klanten = new ObservableCollection<Klant>(_dataService.GeefAlleKlanten());
        }

        public ObservableCollection<Klant> Klanten
        {
            get { return _klanten; }
            set { OnPropertyChanged(ref _klanten, value); }
        }
    }
}
