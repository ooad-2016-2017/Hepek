using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Parkomania
{
    public sealed partial class ParkingKontrola : UserControl
    {

        private bool dalije = false;
        public ParkingKontrola(string x, string y, string z)
        {
            this.InitializeComponent();
            ime.Text = x;
            textBlock1.Text = y;
            textBlock2.Text = z;
        }
        public ParkingKontrola()
        {
            this.InitializeComponent();
        }
        private void image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!dalije)
            {
                //test.Height = Window.Current.Bounds.Height;
                dalije = true;
                test.IsOpen = true;

            }
            else
            {
                dalije = false;
                test.IsOpen = false;
            }
        }
    }
}
