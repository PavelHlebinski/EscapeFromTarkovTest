using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class WikiSteps : BaseStep
    {
        public WikiSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open wiki page ""(.*)""")]
        public void GivenOpenWikiPage(string url) => MainPage.OpenPage(url);

        [Given(@"Find ""(.*)"" card")]
        public void GivenFindCard(string weaponName) => WikiPage.OpenCard(weaponName);

        [Then(@"Caliber is equal ""(.*)""")]
        public void ThenCaliberIsEqual(string caliber) => WeaponPage.CheckCaliber(caliber);
    }
}
