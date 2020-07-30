using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using WebAPIAutomation.Base;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Extensions
{
    /// <summary>
    /// Webdriver extension methods.
    /// </summary>
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Click element using IJavaScriptExecutor.
        /// </summary>
        public static void ClickUsingJavaScript(this IWebDriver driver, IWebElement element)
        {
            try
            {
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)DriverContext.Driver;
                javaScriptExecutor.ExecuteScript("arguments[0].click();", element);
            }
            catch (Exception ex)
            {
                LogHelper.Write("Unable to locate element, error: " + ex.Message);
            }
        }
        /// <summary>
        /// Perform operations on element using IJavaScriptExecutor.
        /// </summary>
        public static object ExecuteJavaScript(this IWebDriver driver, string script)
        {
            return ((IJavaScriptExecutor)DriverContext.Driver).ExecuteScript(script);
        }
        /// <summary>
        /// Wait for page load.
        /// </summary>
        public static void WaitForPageLoad(this IWebDriver driver)
        {
            DriverContext.Driver.WaitForCondition(webDriver =>
            {
                return webDriver.ExecuteJavaScript("return document.readyState").ToString().Equals("complete");
            }, 10);
        }
        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            while (stopWatch.ElapsedMilliseconds < timeOut)
            {
                if (execute(obj))
                {
                    break;
                }
            }
        }
        /// <summary>
        /// FluentWait implementation, waits till the element is enabled and displayed.
        /// </summary>
        public static void FluentWait(this IWebDriver driver, By locator, int timeout = 20)
        {
            try
            {
                DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(DriverContext.Driver);
                fluentWait.Timeout = TimeSpan.FromSeconds(timeout);
                fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
                fluentWait.PollingInterval = TimeSpan.FromMilliseconds(350);
                fluentWait.Until((x => x.FindElement(locator).Displayed));
                fluentWait.Until((x => x.FindElement(locator).Enabled));
            }
            catch (Exception ex)
            {
                LogHelper.Write("Unable to locate element, error: " + ex.Message);
            }

        }
        /// <summary>
        /// Explicit wait implementation.
        /// </summary>
        public static void ExplicitWait(this IWebDriver driver, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(DriverContext.Driver, TimeSpan.FromSeconds(timeout));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
    }
}
