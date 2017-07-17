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
using static QuantumSpatial.Common.LoginResponce;

namespace QuantumSpatial.Services
{
    public static class UserService
    {
        public static async Task<UserDetails> DoLogin(string Username, string Password)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, Constants.LoginServiceURL);
                requestMessage.Content = new StringContent("{\"EmailAddress\":\""+ Username + "\",\"Password\":\""+ Password + "\"}", Encoding.UTF8, "application/json");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                requestMessage.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
                var result = await client.SendAsync(requestMessage);
                result.EnsureSuccessStatusCode();
                string stringJson = await result.Content.ReadAsStringAsync();
                //stringJson = stringJson.Replace("\\\"", "\"").Replace("\"{", "{").Replace("}\"", "}").Replace("\\", "");
                stringJson = CommonFunctions.GetReplacedJSON(stringJson);
                var rootObject = JsonConvert.DeserializeObject<RootObject>(stringJson);
                UserDetails ObjUserDetails = rootObject.GetValidMobileUserResult.UserDetails;
                return ObjUserDetails;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
