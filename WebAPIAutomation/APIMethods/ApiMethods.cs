using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using WebAPIAutomation.Comparator;
using WebAPIAutomation.Helpers;
using WebAPIAutomation.Interfaces;

namespace WebAPIAutomation.APIMethods
{
    /// <summary>
    /// This contains all the methods related to API methods.
    /// </summary>
    public class ApiMethods : IRestGetMethod,IRestPutMethod
    {
        private IRestClient _restClient;
        private IRestRequest _restRequest;
        private IRestResponse _restResponse;
        /// <summary>
        /// Implemented GET method and returns the response.
        /// </summary>
        public IRestResponse GetMethod(string endpoint, string resource, Dictionary<string, string> queryParams)
        {
            try
            {
                _restClient = new RestClient(endpoint);
                LogHelper.Write("Endpoint: " + endpoint);
                _restRequest = new RestRequest(resource, Method.GET);
                LogHelper.Write("Resource: " + resource);
                foreach (var queryparam in queryParams)
                {
                    _restRequest.AddParameter(queryparam.Key, queryparam.Value);
                    LogHelper.Write("QueryParamater: " + queryparam.Key + " - " + queryparam.Value);
                }
                _restResponse = _restClient.Execute(_restRequest);
            }
            catch(Exception ex)
            {
                LogHelper.Write("Error getting response from the endpont: " + ex.Message);
            }
            return _restResponse;
        }
        /// <summary>
        /// Method to Get the temperature of City. Returns a new ApiWeather object using API response.
        /// </summary>

        public ApiWeather GetCityTemperature(Dictionary<string,string> testData)
        {
            string resource = null;
            string endPoint = null;
            Dictionary<string, string> queryParams = new Dictionary<string, string>(0);
            foreach (var field in testData)
            {
                if (field.Key.ToString().ToUpper().Equals("RESOURCE"))
                    resource = field.Value.ToString();
                if (field.Key.ToString().ToUpper().Contains("QUERYPARAMETER"))
                    queryParams.Add(FormatFieldKey(field.Key.ToString()), field.Value.ToString());
                if (field.Key.ToString().ToUpper().Contains("ENDPOINT"))
                    endPoint = field.Value.ToString();
            }
           var response= GetMethod(endPoint,resource, queryParams);
            LogHelper.Write("Response JSON: "+ response.Content.ToString());

            return new ApiWeather
            {
                Degrees = JSONField(response, "main.temp"),
                Fahrenheit = JSONField(response, "main.temp"),
                Humidity = JSONField(response, "main.humidity"),
            };
        }
        /// <summary>
        /// Method to format QueryParam/Header fields.
        /// </summary>
        public string FormatFieldKey(string fieldKey)
        {
            var fieldSplitArray = fieldKey.Split('_');
            return fieldSplitArray[1];
        }
        /// <summary>
        /// Method to get value from JSON response based on key.
        /// </summary>
        public float JSONField(IRestResponse restResponse, string key)
        {
            JObject jsonObject = JObject.Parse(restResponse.Content.ToString());
            return (float)jsonObject.SelectToken(key);
        }
        /// <summary>
        /// PUT method not implemented.
        /// </summary>
        public IRestResponse PutMethod(string endpoint, string resource, Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }
    }
}
