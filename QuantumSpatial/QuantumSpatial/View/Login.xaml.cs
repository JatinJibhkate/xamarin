using QuantumSpatial.Common;
using QuantumSpatial.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static QuantumSpatial.Common.LoginResponce;

namespace QuantumSpatial.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async Task btnLogin_ClickedAsync(object sender, EventArgs e)
        {
            try
            {
                using (var scope = new ActivityIndicatorScope(syncIndicator, true))
                {
                    UserDetails ObjUser = await UserService.DoLogin(entUserName.Text, entPassword.Text);
                    Application.Current.Properties["UserId"] = ObjUser.Id;
                    Application.Current.Properties["UserGSSA"] = ObjUser.GeoSpatialServiceAddress;
                    Application.Current.MainPage = new WorkOrderDashboard();

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}