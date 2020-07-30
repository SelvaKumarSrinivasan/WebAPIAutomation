using RestSharp;
using System.Collections.Generic;

namespace WebAPIAutomation.Interfaces
{
    /// <summary>
    /// GET method interface, implemented in ApiMethods class.
    /// </summary>
    interface IRestGetMethod
    {
     IRestResponse GetMethod(string endpoint,string resource, Dictionary<string, string> queryParams);
    }
}
