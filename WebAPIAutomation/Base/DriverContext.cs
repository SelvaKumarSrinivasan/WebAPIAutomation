using OpenQA.Selenium;

namespace WebAPIAutomation.Base
{
    /// <summary>
    /// Sets driver context which can be accessible in all classes.
    /// </summary>
    public static class DriverContext
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }
    }
}
