using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumSpatial.Common
{
    public static class CommonFunctions
    {
        public static string GetReplacedJSON(string Json)
        {
            try
            {
               return Json.Replace("\\\"", "\"").Replace("\"{", "{").Replace("}\"", "}").Replace("\\", "").Replace("\"[", "[").Replace("]\"", "]");
                            
            }
            catch (Exception)
            {
                throw;
            }            
              
        }
    }
}
