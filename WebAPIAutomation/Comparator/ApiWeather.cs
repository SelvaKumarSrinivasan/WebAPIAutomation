using WebAPIAutomation.Interfaces;

namespace WebAPIAutomation.Comparator
{
    /// <summary>
    /// To store weather details from API response.
    /// </summary>
    public class ApiWeather : IWeatherDetails
    {
        public float Degrees { get; set; }
        public float Fahrenheit { get; set; }
        public float Humidity { get; set; }
    }
}
