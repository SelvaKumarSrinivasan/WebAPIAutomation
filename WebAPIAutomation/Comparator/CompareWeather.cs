using System.Collections.Generic;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Comparator
{ /// <summary>
  /// Compare weather details from Web and API layers.
  /// </summary>
    public static class CompareWeather
    {
        /// <summary>
        /// Method to compare temperature from Web and API layers.
        /// </summary>
        public static bool CompareTemperature(WebWeather webWeather, ApiWeather apiWeather, string temperatureFormat, string variance)
        {
            List<float> temperatures = new List<float>();
            switch(temperatureFormat)
            {
                case "imperial":
                    temperatures.Add(webWeather.Fahrenheit);
                    temperatures.Add(apiWeather.Fahrenheit);
                    break;
                case "metric":
                    temperatures.Add(webWeather.Degrees);
                    temperatures.Add(apiWeather.Degrees);
                    break;
                default:break;
            }
            CalculateVariance(temperatures);
            return CompareVariance(float.Parse(variance), CalculateVariance(temperatures));
        }
        /// <summary>
        /// Method to compare Humidity from Web and API layers.
        /// </summary>
        public static bool CompareHumidity(WebWeather webWeather, ApiWeather apiWeather,string variance)
        {
            bool humidityComparison = false;
            var humidityList = new List<float>() { webWeather.Humidity, apiWeather.Humidity };
            CalculateVariance(humidityList);
            if (CalculateVariance(humidityList) <= float.Parse(variance))
            {
                humidityComparison = true;
                LogHelper.Write("Humidity difference is within the specified range");
            }
            else
            {
                LogHelper.Write("Humidity difference is not within the specified range");
            }
            return humidityComparison;
        }
        /// <summary>
        /// Method to compare Variance.
        /// </summary>
        private static bool CompareVariance(float expectedVariance,float actualVariance)
        {
            bool varianceComparison = false;
            if (actualVariance < expectedVariance)
            {
                varianceComparison = true;
                LogHelper.Write("Temperature difference is within the specified range");
            }
            else
            {
                LogHelper.Write("Temperature difference is not within the specified range");
            }
            LogHelper.Write("Expected Variance: " + expectedVariance);
            LogHelper.Write("Actual Variance: " + actualVariance);
            return varianceComparison;
        }
        /// <summary>
        /// Method to calculate Variance.
        /// </summary>
        private static float CalculateVariance(List<float> temperatures)
        {
            float deviation = 0, sum = 0, sumSquare = 0, mean = 0;
            foreach (var temperature in temperatures)
            {
                sum += temperature;
            }
            mean = sum / (float)temperatures.Count;
            foreach (var temperature in temperatures)
            {
                deviation = temperature - mean;
                sumSquare += deviation * deviation;
            }
            return sumSquare / (float)temperatures.Count;
        }
    }
}
