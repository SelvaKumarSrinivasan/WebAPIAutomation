using OfficeOpenXml.FormulaParsing.Utilities;
using OpenQA.Selenium;
using System;
using WebAPIAutomation.Base;
using WebAPIAutomation.Extensions;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Pages
{
    /// <summary>
    /// Home page objects and related methods.
    /// </summary>
    public class HomePage
    {
        By LocatorSubMenu = By.Id("h_sub_menu");
        By LocatorWeather = By.LinkText("WEATHER");
        By LocatorNavigator = By.XPath("//div[@class='topnav_extra']");
        By LocatorNotification = By.XPath("//div[@class='noti_wrap']");
        By LocatorNoThanks = By.XPath("//a[contains(text(),'No Thanks')]");

        /// <summary>
        /// Method to click on Sub menu link.
        /// </summary>
        public void ClickSubMenuLink()
        {
            DriverContext.Driver.WaitForPageLoad();
            DriverContext.Driver.FluentWait(LocatorNavigator);
            DriverContext.Driver.FluentWait(LocatorSubMenu);
            DriverContext.Driver.FindElement(LocatorSubMenu).ClickAction();
            CheckForAlerts();
            LogHelper.Write("Clicked on Sub-menu link");
        }
        /// <summary>
        /// Method to click on Weather link.
        /// </summary>
        public WeatherPage ClickWeatherLink()
        {
            DriverContext.Driver.FindElement(LocatorWeather).ClickAction();
            LogHelper.Write("Clicked on Weather link");
            return new WeatherPage();
        }
        /// <summary>
        /// Method to check for alerts and click on Sub Menu.
        /// </summary>
        public void CheckForAlerts()
        {
            bool weatherLinkDisplayed=false;
            try
            {
                weatherLinkDisplayed=DriverContext.Driver.FindElement(LocatorWeather).Displayed;
            }
            catch(Exception)
            {
                DriverContext.Driver.FluentWait(LocatorNotification);
                DriverContext.Driver.FindElement(LocatorNoThanks).ClickAction();
                LogHelper.Write("Clicked on No Thanks");
                DriverContext.Driver.FindElement(LocatorSubMenu).ClickAction();
            }
        }
    }
}

