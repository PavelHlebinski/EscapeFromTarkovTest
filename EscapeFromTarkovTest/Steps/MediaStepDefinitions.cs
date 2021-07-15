using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class MediaStepDefinitions : BaseStep
    {
        public MediaStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open page ""(.*)""")]
        public void GivenOpenPage(string url) => MediaPage.OpenPage(url);
        
        [Given(@"Select first video")]
        public void GivenSelectFirstVideo() => MediaPage.OpenVideo();

        [When(@"Play is pressed")]
        public void WhenPlayIsPressed() => VideoPage.PlayVideo();

        [Then(@"Stop video button contains text ""(.*)""")]
        public void ThenStopVideoButtonContainsText(string text) => VideoPage.CheckVideoPlaying(text);
    }
}
