using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class ErrorPage : BasePage
    {
        public ErrorPage(IWebDriver driver) : base(driver) { }

        private WebElement PageTittle => new WebElement(Driver, By.XPath("//*[@itemprop=\"name headline\"]"));

        public void CheckPageTittle(string errorName) => Assert.IsTrue(IsPageCorrect(errorName));

        private bool IsPageCorrect(string errorName) => PageTittle.GetText().Contains(errorName);
    }
}
