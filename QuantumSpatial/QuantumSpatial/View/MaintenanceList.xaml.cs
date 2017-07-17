using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuantumSpatial.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaintenanceList : ContentPage
    {
        public MaintenanceList()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                DisplayAlert("", ex.Message, "Ok");
            }
            
        }
    }
}