using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Newtonsoft.Json;
using System.Net.Http.Headers;
using QuantumSpatial.Common;
using Newtonsoft.Json.Linq;
using static QuantumSpatial.Common.InspectionResponce;
using Xamarin.Forms;

namespace QuantumSpatial.Services
{
    public static class WorkOrderService
    {
        public static async Task<List<Result>> GetWorkOrdersByUserId()
        {
            try
            {
                HttpClient client = new HttpClient();
                string UserId = Application.Current.Properties["UserId"] as string;
                var result = await client.GetAsync(Constants.WorkOrderServiceURL + "/UserId=" + UserId + "&Type=STRUCTURES");
                result.EnsureSuccessStatusCode();
                string stringJson = await result.Content.ReadAsStringAsync();
                stringJson = CommonFunctions.GetReplacedJSON(stringJson);
                var ObjRoot = JsonConvert.DeserializeObject<List<Result>>(stringJson);
                return ObjRoot;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
