using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Parkomania
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ParkingRegister : Page
    {
        double x, y;
        public ParkingRegister()
        { 
            this.InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = (ViewModel.System)e.Parameter;
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new dbContext.Parking())
            {
                /*using (var db2 = new dbContext.Parking())
                {
                    Model.ParkingModel model = new Model.ParkingModel(100, 100);
                    var contact = new Model.Parking(1, textparkingime.Text, textpargrad.Text, comboboxpardrzava.SelectedItem.ToString(), 2, float.Parse(textparprice.Text), Int32.Parse(textparstart.Text), Int32.Parse(textparend.Text), Int32.Parse(textparkap.Text), Int32.Parse(textparfreep.Text), model);
                    db.parking.Add(contact);
                    //SaveChanges obavezno da se reflektuju izmjene u bazi, tek tada dolazi do komunikacije sa bazom
                    db.SaveChanges();
                    //reset polja za unos
                    textparkingime.Text = string.Empty;
                    textpargrad.Text = string.Empty;
                    textparend.Text = string.Empty;
                    textparkap.Text = string.Empty;
                    textparfreep.Text = string.Empty;
                    //refresh liste restorana
                    ViewModel.System.parkings.Add(contact);
                }*/
                var contact = new Model.Location { x = 1, y = 1 }; 
                db.location.Add(contact);
                db.SaveChanges();
            }
        }

        private void MapControl_MapTapped(Windows.UI.Xaml.Controls.Maps.MapControl sender, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs args)
        {
            var tappedGeoPosition = args.Location.Position;
            x = tappedGeoPosition.Longitude;
            y = tappedGeoPosition.Latitude;
        }
    }
}
