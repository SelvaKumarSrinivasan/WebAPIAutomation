namespace WebAPIAutomation.Interfaces
{
    /// <summary>
    /// Weather details interface common to API and UI layers.
    /// </summary>
    interface IWeatherDetails
    {
        float Degrees { get; set; }
        float Fahrenheit { get; set; }
        float Humidity { get; set; }
    }
}
