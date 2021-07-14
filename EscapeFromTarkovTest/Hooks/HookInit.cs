using EscapeFromTarkovTest.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Hooks
{
    [Binding]
    public sealed class HookInit
    {
        private readonly ScenarioContext _scenarioContext;

        public HookInit(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        [BeforeScenario]
        public void BeforeScenario()
        {
            var seleniumDriver = new DriverFactory(_scenarioContext);
            _scenarioContext.Set(seleniumDriver, "SeleniumDriver");
        }

        [AfterScenario]
        public void AfterScenario() => _scenarioContext.Get<IWebDriver>("WebDriver").Quit();
    }
}
