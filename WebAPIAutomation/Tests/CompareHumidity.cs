using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPIAutomation.APIMethods;
using WebAPIAutomation.Base;
using WebAPIAutomation.Comparator;
using WebAPIAutomation.Helpers;
using WebAPIAutomation.Pages;

namespace WebAPIAutomation.Tests
{
    /// <summary>
    /// Tests to compare humidity.
    /// </summary>
    [TestClass]
    public class CompareHumidityTests
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
        public void CompareHumidity_01()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_02()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_03()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_04()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_05()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_06()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_07()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_08()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_09()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_10()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_11()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_12()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_13()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_14()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_15()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_16()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_17()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_18()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_19()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }
        [TestMethod]
        public void CompareHumidity_20()
        {
            var testData = ExcelHelper.GetTestData();
            homePage.ClickSubMenuLink();
            weatherPage = homePage.ClickWeatherLink();
            weatherPage.EnterCityName(testData["City"]);
            weatherPage.SelectCity();
            Assert.IsTrue(weatherPage.IsCityDisplayed(), "City not displayed in the Map");
            WebWeather webWeather = weatherPage.ViewCityWeather();
            ApiWeather apiWeather = apiMethods.GetCityTemperature(testData);
            Assert.IsTrue(CompareWeather.CompareHumidity(webWeather, apiWeather, testData["Variance"]), "Humidity difference is not within the specified range");
        }

        [TestCleanup]
        public void TearDown()
        {
            TestBase.TestCleanup();
        }
    }
}
