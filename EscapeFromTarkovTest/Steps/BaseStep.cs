using Dynamitey.DynamicObjects;
using EscapeFromTarkovTest.Drivers;
using EscapeFromTarkovTest.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    public class BaseStep
    {
        private readonly ScenarioContext _scenarioContext;

        public BaseStep(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;

        private IWebDriver Driver() => _scenarioContext.Get<DriverFactory>("SeleniumDriver").GetDriver();

        protected MediaPage MediaPage => new MediaPage(Driver());

        protected VideoPage VideoPage => new VideoPage(Driver());
    }
}
