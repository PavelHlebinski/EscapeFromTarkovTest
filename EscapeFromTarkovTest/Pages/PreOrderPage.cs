using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class PreOrderPage : BasePage
    {
        public PreOrderPage(IWebDriver driver) : base(driver) { }

        private WebElement PreOrderButton =>
            new WebElement(Driver, By.XPath("//*[@id=\"preorder_standard\"]//div//div//div//div//div"));

        private WebElement RegistrationAlert =>
            new WebElement(Driver, By.XPath("//*[@id=\"modal\"]//h4"));

        public void CreatePreOrder() => PreOrderButton.Click();

        public void CheckAlertWindow(string alertMessage) => Assert.IsTrue(IsAlertWindowShown(alertMessage));

        private bool IsAlertWindowShown(string alertMessage) => RegistrationAlert.GetText().Contains(alertMessage);
    }
}
