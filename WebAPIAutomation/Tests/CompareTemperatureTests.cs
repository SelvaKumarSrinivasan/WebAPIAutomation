using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIAutomation.APIMethods;
using WebAPIAutomation.Base;
using WebAPIAutomation.Comparator;
using WebAPIAutomation.Helpers;
using WebAPIAutomation.Pages;

namespace WebAPIAutomation.Tests
{
    /// <summary>
    /// Tests to compare temperature.
    /// </summary>
    [TestClass]
    public class CompareTemperatureTests
    {
        public TestContext TestContext { get; set; }
        HomePage homePage = new HomePage();
        WeatherPage weatherPage = new WeatherPage();
        ApiMethods apiMethods = new ApiMethods();
        [TestInitialize]
        public void Setup()
        {
            TestBase.Initialize(TestContext.TestName);
        }
        [TestMethod]
        public void CompareTemparture_01()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }

        [TestMethod]
        public void CompareTemparture_02()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_03()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_04()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_05()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_06()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }

        [TestMethod]
        public void CompareTemparture_07()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_08()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_09()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_10()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_11()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }

        [TestMethod]
        public void CompareTemparture_12()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_13()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_14()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_15()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_16()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }

        [TestMethod]
        public void CompareTemparture_17()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_18()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_19()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }
        [TestMethod]
        public void CompareTemparture_20()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareTemperature(webWeather, apiWeather, testData["QueryParameter_units"], testData["Variance"]), "Temperature difference is not within the specified range");
        }

        [TestCleanup]
        public void TearDown()
        {
            TestBase.TestCleanup();
        }
    }
}
