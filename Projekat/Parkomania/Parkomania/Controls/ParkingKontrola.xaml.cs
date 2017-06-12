﻿using System;
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
        public ParkingKontrola(String x)
        {
            this.InitializeComponent();
            ime.Text = x;
        }

        private void image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            test.Height = Window.Current.Bounds.Height;
            test.IsOpen = true;
        }
    }
}
