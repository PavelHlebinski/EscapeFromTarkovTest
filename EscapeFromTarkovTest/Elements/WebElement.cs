using EscapeFromTarkovTest.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace EscapeFromTarkovTest.Elements
{
    public class WebElement
    {
        private readonly By _locator;
        private readonly IWebDriver _driver;
        private Actions Actions => new Actions(_driver);

        public WebElement(IWebDriver driver, By locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public IWebElement InnerWebElement
        {
            get
            {
                WaitForElementIsPresent();
                return _driver.FindElement(_locator);
            }
        }

        public void WaitForElementIsPresent() => new DriverFactory(null)
                .GetWait(_driver, 10)
                .Until(drv => drv.FindElements(_locator).Count > 0);

        public void Click() => InnerWebElement.Click();

        public void WaitVisibility() => new DriverFactory(null)
            .GetWait(_driver, 10)
            .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(_locator));

        public void SendKeys(string value) => InnerWebElement.SendKeys(value);

        public string GetText() => InnerWebElement.Text;

        public string GetAttribute(string name) => InnerWebElement.GetAttribute(name);

        public void Switch() => _driver.SwitchTo().Frame(InnerWebElement);

        public void ScrollToElement() => Actions.MoveToElement(InnerWebElement).Perform();
    }
}

