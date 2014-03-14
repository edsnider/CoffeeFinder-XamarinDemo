using Cirrious.MvvmCross.ViewModels;
using CoffeeFinder.Core.Models;
using CoffeeFinder.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeFinder.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IFoursquareService _foursquareService;
        private ILocationService _locationService;

        public string ViewTitle { get; set; }

        private ObservableCollection<Venue> _venues;
        public ObservableCollection<Venue> Venues
        {
            get { return _venues; }
            set
            {
                _venues = value;
                RaisePropertyChanged(() => Venues);
            }
        }

        private bool _isBusy = false;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public MainViewModel(IFoursquareService foursquareService, ILocationService locationService)
        {
            this._foursquareService = foursquareService;
            this._locationService = locationService;
        }

        public void Init()
        {
            this.ViewTitle = "COFFEE FINDER XAMARIN DEMO";

            LoadVenues();
        }

        private async void LoadVenues()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            this.Venues = new ObservableCollection<Venue>();

            var coords = await this._locationService.GetLocationAsync();

            try
            {
                var response = await this._foursquareService.GetVenues("coffee", coords);

                foreach (var v in response.Venues)
                {
                    this.Venues.Add(v);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
