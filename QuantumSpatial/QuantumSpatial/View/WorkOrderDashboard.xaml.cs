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
    public partial class WorkOrderDashboard : TabbedPage
    {
        public WorkOrderDashboard()
        {
            try
            {
                InitializeComponent();
                //var navigationPage = new NavigationPage(new MaintenanceList());
                //navigationPage.Title = "MaintenanceList";

                Children.Add(new WorkOrderList());
                Children.Add(new MaintenanceList());
            }
            catch (Exception ex)
            {
                DisplayAlert("", ex.Message, "Ok");
            }            
        }
    }
}