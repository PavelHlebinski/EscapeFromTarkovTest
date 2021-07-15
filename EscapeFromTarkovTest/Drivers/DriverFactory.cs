using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Drivers
{
    public class DriverFactory
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private readonly ScenarioContext _scenarioContext;

        public DriverFactory(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        public IWebDriver GetDriver() => _driver ??= SetupDriver();

        private IWebDriver SetupDriver()
        {
            var driver = new ChromeDriver(GetOptions());
            _scenarioContext.Set(driver, "WebDriver");
            return driver;
        }

        private static ChromeOptions GetOptions()
        {
            var options = new ChromeOptions();
            options.AddArguments("start-maximized");
            return options;
        }

        public WebDriverWait GetWait(IWebDriver driver, int timeOutInSeconds) => _wait ??= SetupWait(driver, timeOutInSeconds);

        private static WebDriverWait SetupWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
    }
}
