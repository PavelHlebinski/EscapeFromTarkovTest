using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class WeaponPage : BasePage
    {
        public WeaponPage(IWebDriver driver) : base(driver) { }

        private WebElement Caliber => new WebElement(Driver, By.XPath("//*[@title=\"5.45x39mm\"]"));

        public void CheckCaliber(string caliber) => Assert.IsTrue(IsCaliberCorrect(caliber));

        private bool IsCaliberCorrect(string caliber) => Caliber.GetText().Contains(caliber);
    }
}
