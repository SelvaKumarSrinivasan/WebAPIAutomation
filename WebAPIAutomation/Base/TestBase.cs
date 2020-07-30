using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using WebAPIAutomation.Helpers;

namespace WebAPIAutomation.Base
{
    public abstract class TestBase
    {
        public static string TestName { get; set; }
        /// <summary>
        /// Initialize test settings.
        /// </summary>
        public static void Initialize(string testName)
        {
            TestName = testName;
            LogHelper.CreateLogFile(TestName);
            LogHelper.Write("Initialized framework");
            OpenBrowser(TestSettings.BrowserType);
            LogHelper.Write("Launched " + TestSettings.BrowserType + "Browser");
            DriverContext.Driver.Navigate().GoToUrl(TestSettings.URL);
            LogHelper.Write("Navigated to " + TestSettings.URL);
        }
        /// <summary>
        /// Select browser based on the value from App.config file.
        /// </summary>
        private static void OpenBrowser(string browserType)
        {
            switch (browserType)
            {
                case "IE":
                    DriverContext.Driver = new InternetExplorerDriver();

                    break;
                case "Chrome":
                    DriverContext.Driver = new ChromeDriver();
                    break;
            }
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            DriverContext.Driver.Manage().Cookies.DeleteAllCookies();
            DriverContext.Driver.Manage().Window.Maximize();
        }
        /// <summary>
        /// Closing driver instance and log file.
        /// </summary>
        public static void TestCleanup()
        {
            DriverContext.Driver.Quit();
            LogHelper.CloseLogfile();
        }
    }
}
