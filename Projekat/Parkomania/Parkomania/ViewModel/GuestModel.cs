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
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace Parkomania.ViewModel
{
    public class GuestModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public System Parent { get; set; }
        public ICommand exit { get; set; }
        public ICommand findme { get; set; }
        public MapControl mapa;

        private string _search;
        public string searchparkingguest
        {
            get { return _search; }
            set
            {
                _search = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(searchparkingguest)));
                }
            }
        }
        public GuestModel()
        {

        }
        public GuestModel(System p)
        {
            this.Parent = p;
            
            exit = new RelayCommand<object>(closeGuestForm, Check);
            findme = new RelayCommand<object>(findMeGps, Check);
        }
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
        public async void findMeGps(object parametar)
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
                x = (float)trenutnaLokacija.Position.Latitude,
                y = (float)trenutnaLokacija.Position.Longitude
            };

            /*MapLocationFinderResult result = await
            MapLocationFinder.FindLocationsAtAsync(pos.Coordinate.Point);
            if (result.Status == MapLocationFinderStatus.Success)
            {
                Adresa = "Adresa je " + result.Locations[0].Address.Street;
            }*/

            MapIcon mapIcon = new MapIcon();
            BasicGeoposition snPosition = new BasicGeoposition()
            {   Latitude = trenutnaLokacija.Position.Latitude,
                Longitude = trenutnaLokacija.Position.Longitude
            };
            mapIcon.Location = new Geopoint(snPosition);
            mapIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon.Title = "I'm here!";
            mapIcon.ZIndex = 0;
            mapa = test.gmapa;
            mapa.MapElements.Add(mapIcon);
            mapa.Center = trenutnaLokacija;
            mapa.ZoomLevel = 14;
        }
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }

        public bool Check(object parametar)
        {
            return true;
        }
        public void closeGuestForm(object parametar)
        {
            Parent.NavigationService.GoBack();
        }
    }

}

