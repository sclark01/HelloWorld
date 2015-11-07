using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Caliburn.Micro;

namespace HelloWorld.ModelViews
{
    public class FirstViewModel : PropertyChangedBase
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

    }
}
