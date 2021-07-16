using EscapeFromTarkovTest.Elements;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class WikiPage : BasePage
    {
        public WikiPage(IWebDriver driver) : base(driver) { }

        private WebElement SearchField => new WebElement(Driver, By.XPath("//*[@type=\"search\"]"));

        public void OpenCard(string weaponName)
        {
            SearchField.SendKeys(weaponName);
            SearchField.SendKeys(Keys.Enter);
        }
    }
}
