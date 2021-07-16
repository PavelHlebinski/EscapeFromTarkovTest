using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class SupportSteps : BaseStep
    {
        public SupportSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open support page ""(.*)""")]
        public void GivenOpenSupportPage(string url) => MainPage.OpenPage(url);

        [Given(@"Find ""(.*)""")]
        public void GivenFind(string errorMessage) => SupportPage.EnterError(errorMessage);

        [When(@"Open information about error")]
        public void WhenOpenInformationAboutError() => SupportPage.OpenErrorPage();

        [Then(@"Opened correct page about ""(.*)""")]
        public void ThenOpenedCorrectPageAbout(string errorName) => ErrorPage.CheckPageTittle(errorName);
    }
}
