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
using System.Windows;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Parkomania
{
    public sealed partial class PModelxaml : UserControl
    {
        public Button[] dugmad = new Button[6];
        int brojp = 0;
        public PModelxaml()
        {
            this.InitializeComponent();
            dugmad[0] = b1;
            dugmad[1] = b2;
            dugmad[2] = b3;
            dugmad[3] = b4;
            dugmad[4] = b5;
            dugmad[5] = b6;
            for (int i = 0; i < 6; i++)
                dugmad[i].Visibility = Visibility.Collapsed;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            if (brojp < 6)
                dugmad[brojp].Visibility = Visibility.Visible;
            if (brojp < 5)
                brojp++;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            if (brojp >= 0)
                dugmad[brojp].Visibility = Visibility.Collapsed;
            if (brojp > 0)
                brojp--;
        }
    }
}
