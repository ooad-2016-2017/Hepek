using Parkomania.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls.Maps;

namespace Parkomania.ViewModel
{
    class UserModel : INotifyPropertyChanged
    {
        System parent;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand exit { get; set; }
        public ICommand findme { get; set; }
        public Model.User user;
        MapControl mapa;

        private Geopoint trenutnaLokacija;
        public Geopoint TrenutnaLokacija
        {
            get { return trenutnaLokacija; }
            set
            {
                trenutnaLokacija = value;
                OnNotifyPropertyChanged("TrenutnaLokacija");
            }
        }

        private string _search;
        public string search
        {
            get { return _search; }
            set
            {
                _search = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(search)));
                }
            }
        }
        public UserModel(System s)
        {
            parent = s;
            exit = new RelayCommand<object>(Exit, check);
            findme = new RelayCommand<object>(findMe, check);
        }
        public bool check(object parametar)
        {
            return true;
        }
        public void Exit(object parametar)
        {
            parent.NavigationService.GoBack();
        }
        public async void findMe(object parametar)
        {
            Geoposition pos = null;
            var accessStatus = await Geolocator.RequestAccessAsync();
            if (accessStatus == GeolocationAccessStatus.Allowed)
            {
                Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = 10 };
                pos = await geolocator.GetGeopositionAsync();
            }
            TrenutnaLokacija = pos.Coordinate.Point;
            var lc = new Model.Location
            {
                x = (float)TrenutnaLokacija.Position.Latitude,
                y = (float)TrenutnaLokacija.Position.Longitude
            };

            /*MapLocationFinderResult result = await
            MapLocationFinder.FindLocationsAtAsync(pos.Coordinate.Point);
            if (result.Status == MapLocationFinderStatus.Success)
            {
                Adresa = "Adresa je " + result.Locations[0].Address.Street;
            }*/

            MapIcon mapIcon1 = new MapIcon();
            BasicGeoposition snPosition = new BasicGeoposition() { Latitude = TrenutnaLokacija.Position.Latitude, Longitude = TrenutnaLokacija.Position.Longitude};
            mapIcon1.Location = new Geopoint(snPosition);
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "I'm here!";
            mapIcon1.ZIndex = 0;
            mapa = test.mapa;
            mapa.MapElements.Add(mapIcon1);
            mapa.Center = trenutnaLokacija;
            mapa.ZoomLevel = 14;
        }
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}

