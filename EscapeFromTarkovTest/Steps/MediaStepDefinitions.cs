using EscapeFromTarkovTest.Drivers;
using EscapeFromTarkovTest.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class MediaStepDefinitions
    {
        private IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;
        private MediaPage _mediaPage = null;
        private VideoPage _videoPage = null;

        public MediaStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I open media page")]
        public void GivenIOpenMediaPage()
        {
            _driver = _scenarioContext.Get<DriverFactory>("SeleniumDriver").GetDriver();
            _driver.Url = "https://www.escapefromtarkov.com/";
            _mediaPage = new MediaPage(_driver);
            _videoPage = new VideoPage(_driver);
        }

        [Given(@"Select first video")]
        public void GivenSelectFirstVideo() => _mediaPage.OpenVideo();


        [When(@"Play is pressed")]
        public void WhenPlayIsPressed() => _videoPage.PlayVideo();


        [Then(@"Stop video button contains text ""(.*)""")]
        public void ThenStopVideoButtonContainsText(string text) => _videoPage.CheckVideoPlaying(text);
    }
}
