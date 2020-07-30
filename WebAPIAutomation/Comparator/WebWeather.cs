using WebAPIAutomation.Interfaces;

namespace WebAPIAutomation.Comparator
{ /// <summary>
  /// To store weather details from Web layer.
  /// </summary>
    public class WebWeather : IWeatherDetails
    {
        public float Degrees { get; set; }
        public float Fahrenheit { get; set; }
        public float Humidity { get; set; }
    }
}
