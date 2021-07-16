using EscapeFromTarkovTest.Drivers;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace EscapeFromTarkovTest.Elements
{
    public class WebElements
    {
        private readonly By _locator;
        private readonly IWebDriver _driver;

        public WebElements(IWebDriver driver, By locator)
        {
            _driver = driver;
            _locator = locator;
        }

        public List<IWebElement> InnerWebElementsList
        {
            get
            {
                WaitForElementIsPresent();
                return _driver.FindElements(_locator).ToList();
            }
        }

        public void WaitForElementIsPresent() =>
            new DriverFactory(null).GetWait(_driver, 10).Until(drv => drv.FindElements(_locator).Count > 0);

        public bool IsTextContains(string name) => InnerWebElementsList.All(element => element.Text.Contains(name));

        public IWebElement FirstElement() => _driver.FindElements(_locator).ToList().FirstOrDefault();

        public int CountElements() => InnerWebElementsList.Count();

        public bool IsElementsValid() => InnerWebElementsList.All(element => int.TryParse(element.Text, out _));

        public IWebElement GetFirstElement() => InnerWebElementsList.FirstOrDefault();
    }
}
