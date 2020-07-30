using OpenQA.Selenium;
using System;
using WebAPIAutomation.Base;
using WebAPIAutomation.Comparator;
using WebAPIAutomation.Extensions;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Pages
{
    /// <summary>
    /// Weather page objects and related methods.
    /// </summary>
    public class WeatherPage
    {
        private string _city;
        By LocatorSearchBox = By.Id("searchBox");
        By LocatorHumidity = By.XPath("//b[contains(text(),'Humidity')]");
        By LocatorDegrees = By.XPath("//b[contains(text(),'Degrees')]");
        By LocatorFahrenheit = By.XPath("//b[contains(text(),'Fahrenheit')]");
        By LocatorMap = By.Id("map_canvas");
        By LocatorMapPane=By.XPath("//div[@class='leaflet-pane leaflet-marker-pane']");
        /// <summary>
        /// Enter city name in search box.
        /// </summary>
        public void EnterCityName(string city)
        {
            DriverContext.Driver.WaitForPageLoad();
            DriverContext.Driver.FluentWait(LocatorSearchBox);
            DriverContext.Driver.FluentWait(LocatorMap);
            DriverContext.Driver.FluentWait(LocatorMapPane);
            DriverContext.Driver.FindElement(LocatorSearchBox).EnterText(city);
            LogHelper.Write("Entered city name: "+ city+" in search box");
            _city = city;
        }
        /// <summary>
        /// Select city check box.
        /// </summary>
        public void SelectCity()
        {
            By LocatorCity = By.XPath("//label[@for='" + _city + "']");
            DriverContext.Driver.WaitForPageLoad();
            DriverContext.Driver.FluentWait(LocatorCity);
            DriverContext.Driver.FindElement(LocatorCity).ClickAction();
            LogHelper.Write(_city+" checkbox selected");
        }
        /// <summary>
        /// Check whether city is displayed in the map.
        /// </summary>
        public bool IsCityDisplayed()
        {
            bool isCityVisible = false;
            By LocatorCityMap = By.XPath("//div[@class='cityText' and contains(text(),'" + _city + "')]");
            DriverContext.Driver.WaitForPageLoad();
            DriverContext.Driver.FluentWait(LocatorCityMap);
            if (DriverContext.Driver.FindElement(LocatorCityMap).Displayed)
                isCityVisible = true;
            DriverContext.Driver.FindElement(LocatorCityMap).ClickAction();
            if(isCityVisible)
                LogHelper.Write(_city +" is displayed in the map");
            return isCityVisible;
        }
        /// <summary>
        /// Extract city weather details from the map.
        /// </summary>
        public WebWeather ViewCityWeather()
        {
            DriverContext.Driver.FluentWait(LocatorDegrees);
            LogHelper.Write("Temperaure details in Weather Page");
            var degrees = DriverContext.Driver.FindElement(LocatorDegrees).Text;
            LogHelper.Write(degrees);
            var fahrenheit = DriverContext.Driver.FindElement(LocatorFahrenheit).Text;
            LogHelper.Write(fahrenheit);
            var humidity = DriverContext.Driver.FindElement(LocatorHumidity).Text;
            LogHelper.Write(humidity);
            return new WebWeather
            {
                Degrees = FormatWeather(degrees),
                Fahrenheit = FormatWeather(fahrenheit),
                Humidity = FormatWeather(humidity)
            };
        }
        /// <summary>
        /// Method to format weather details.
        /// </summary>
        public float FormatWeather(string temperature)
        {
            var tempArray = temperature.Split(':');
            var tempfield = tempArray[1].Replace(" ",String.Empty).Replace("%",String.Empty);
            return (float.Parse(tempfield));
        }

    }
}
