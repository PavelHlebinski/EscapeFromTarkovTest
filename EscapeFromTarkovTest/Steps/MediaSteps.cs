using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class MediaSteps : BaseStep
    {
        public MediaSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open page ""(.*)""")]
        public void GivenOpenPage(string url) => MainPage.OpenPage(url);

        [Given(@"Select first video")]
        public void GivenSelectFirstVideo() => MainPage.OpenVideo();

        [When(@"Play is pressed")]
        public void WhenPlayIsPressed() => VideoPage.PlayVideo();

        [Then(@"Stop video button contains text ""(.*)""")]
        public void ThenStopVideoButtonContainsText(string text) => VideoPage.CheckVideoPlaying(text);
    }
}
