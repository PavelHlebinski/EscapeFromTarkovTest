using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class RatingPage : BasePage
    {
        public RatingPage(IWebDriver driver) : base(driver) { }

        private const string PlayerRowLocator = "//*[@id=\"ratingTable\"]/div/table/tbody/tr";
        private const string SortKillsLocator = "//*[@data-val=\"kills\"]";

        private WebElement SortDropDown =>
            new WebElement(Driver, By.XPath("//*[@data-current=\"experience\"]"));

        private WebElement SortByKills =>
            new WebElement(Driver, By.XPath(SortKillsLocator));

        private WebElements ListOfPlayers =>
            new WebElements(Driver, By.XPath(PlayerRowLocator));

        private WebElements ListOfPlayersLvl =>
            new WebElements(Driver, By.XPath($"{PlayerRowLocator}//td[@class=\"col-5\"]"));

        public void SortPlayers()
        {
            SortDropDown.Click();
            SortByKills.WaitVisibility();
            SortByKills.Click();
        }

        public void CheckRowsCount() => Assert.IsTrue(IsRowCountCorrect());

        public void CheckValidLvl() => Assert.IsTrue(IsPlayerLvlValid());

        private bool IsRowCountCorrect() => ListOfPlayers.CountElements().Equals(100);

        private bool IsPlayerLvlValid() => ListOfPlayersLvl.IsElementsValid();
    }
}
