using EscapeFromTarkovTest.Elements;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class SupportPage : BasePage
    {
        public SupportPage(IWebDriver driver) : base(driver) { }

        private WebElement SearchField => new WebElement(Driver, By.Id("main_search"));

        private WebElements ResultList => new WebElements(Driver, By.XPath("//*[@id=\"knowledge_results\"]//li"));

        public void EnterError(string errorMessage) => SearchField.SendKeys(errorMessage);

        public void OpenErrorPage()
        {
            SearchField.SendKeys(Keys.Enter);
            ResultList.GetFirstElement().Click();
        }
    }
}
