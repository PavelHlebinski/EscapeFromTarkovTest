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
        private MediaPage _mediaPage;
        private VideoPage _videoPage;

        public MediaStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"Open page ""(.*)""")]
        public void GivenOpenPage(string url)
        {
            _driver = _scenarioContext.Get<DriverFactory>("SeleniumDriver").GetDriver();
            _mediaPage = new MediaPage(_driver);
            _videoPage = new VideoPage(_driver);
            _mediaPage.OpenPage(url);
        }

        [Given(@"Select first video")]
        public void GivenSelectFirstVideo() => _mediaPage.OpenVideo();

        [When(@"Play is pressed")]
        public void WhenPlayIsPressed() => _videoPage.PlayVideo();

        [Then(@"Stop video button contains text ""(.*)""")]
        public void ThenStopVideoButtonContainsText(string text) => _videoPage.CheckVideoPlaying(text);
    }
}
