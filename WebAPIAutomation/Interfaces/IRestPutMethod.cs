using RestSharp;
using System.Collections.Generic;

namespace WebAPIAutomation.Interfaces
{
    /// <summary>
    /// PUT method interface, not implemented.
    /// </summary>
    interface IRestPutMethod
    {
        IRestResponse PutMethod(string endpoint, string resource, Dictionary<string, string> queryParams);
    }
}
