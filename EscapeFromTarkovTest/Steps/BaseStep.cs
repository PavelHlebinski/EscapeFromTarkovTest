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

        protected MainPage MainPage => new MainPage(Driver());

        protected VideoPage VideoPage => new VideoPage(Driver());

        protected BooksPage BooksPage => new BooksPage(Driver());

        protected RatingPage RatingPage => new RatingPage(Driver());

        protected SupportPage SupportPage => new SupportPage(Driver());

        protected ErrorPage ErrorPage => new ErrorPage(Driver());

        protected PreOrderPage PreOrderPage => new PreOrderPage(Driver());

        protected WikiPage WikiPage => new WikiPage(Driver());

        protected WeaponPage WeaponPage => new WeaponPage(Driver());
    }
}
