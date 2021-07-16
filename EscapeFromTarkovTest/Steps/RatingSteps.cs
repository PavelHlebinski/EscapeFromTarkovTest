using TechTalk.SpecFlow;

namespace EscapeFromTarkovTest.Steps
{
    [Binding]
    public sealed class RatingSteps : BaseStep
    {
        public RatingSteps(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"Open rating page ""(.*)""")]
        public void GivenOpenRatingPage(string url) => MainPage.OpenPage(url);

        [When(@"Sort by kills")]
        public void WhenSortByKills() => RatingPage.SortPlayers();

        [Then(@"Shown 100 rows")]
        public void ThenShownRows() => RatingPage.CheckRowsCount();

        [Then(@"Player lvl is valid")]
        public void ThenPlayerLvlIsValid() => RatingPage.CheckValidLvl();
    }
}
