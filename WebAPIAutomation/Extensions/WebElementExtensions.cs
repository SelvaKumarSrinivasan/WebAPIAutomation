using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using WebAPIAutomation.Base;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Extensions
{
    /// <summary>
    ///Webelemnt extension methods.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Method to click element using Action class.
        /// </summary>
        public static void ClickAction(this IWebElement element)
        {
            try
            {
                Actions actions = new Actions(DriverContext.Driver);
                actions.MoveToElement(element).Click(element).Build().Perform();
            }
            catch (Exception ex)
            {
                LogHelper.Write("Page loading error: " + ex.Message);
            }

        }
        /// <summary>
        /// Method to enter data in textbox/searchbox.
        /// </summary>
        public static void EnterText(this IWebElement element, string text)
        {
            try
            {
                element.SendKeys(text);
            }
            catch (Exception ex)
            {
                LogHelper.Write("Unable to enter data: " + ex.Message);
            }

        }

    }
}
