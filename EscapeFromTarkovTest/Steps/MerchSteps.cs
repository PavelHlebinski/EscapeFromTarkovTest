using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class MerchSteps : BaseStep
    {
        public MerchSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open books page ""(.*)""")]
        public void GivenOpenStartPage(string url) => MainPage.OpenPage(url);

        [Then(@"Book ""(.*)"" costs ""(.*)""")]
        public void ThenBookCosts(string price, string bookName) => BooksPage.CheckBookPrice(price, bookName);
    }
}
