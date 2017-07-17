using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static QuantumSpatial.Common.InspectionResponce;
using QuantumSpatial.Common;
using QuantumSpatial.Services;

namespace QuantumSpatial.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkOrderList : ContentPage
    {
        List<InspectionResponce.Result> ObjRoot;
        public WorkOrderList()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }

        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                using (var scope = new ActivityIndicatorScope(syncIndicator, true))
                {
                    Task.Factory.StartNew(async () =>
                    {
                        await GetWorkOrdersAsync();
                        lstWorkOrder.ItemsSource = ObjRoot;
                    });
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }

        }

        public async Task GetWorkOrdersAsync()
        {
            try
            {
                ObjRoot = await WorkOrderService.GetWorkOrdersByUserId();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

    }
}