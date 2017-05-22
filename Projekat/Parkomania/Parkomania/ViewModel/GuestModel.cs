using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Parkomania.ViewModel
{
    public class GuestModel
    {
        public System Parent { get; set; }
        public GuestModel(System p)
        {
            this.Parent = p;
        }         
    }
}

