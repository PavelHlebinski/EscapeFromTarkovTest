using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class PreOrderSteps : BaseStep
    {
        public PreOrderSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open pre-order page ""(.*)""")]
        public void GivenOpenPre_OrderPage(string url) => MainPage.OpenPage(url);

        [When(@"Try to get pre-order without registration")]
        public void WhenTryToGetPre_OrderWithoutRegistration() => PreOrderPage.CreatePreOrder();


        [Then(@"Registration alert is shown ""(.*)""")]
        public void ThenRegistrationAlertIsShown(string alertMessage) => PreOrderPage.CheckAlertWindow(alertMessage);
    }
}
