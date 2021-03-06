using EscapeFromTarkovTest.Elements;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        private WebElement FirstVideo => new WebElement(Driver, By.XPath("//*[@id=\"media_328\"]//a"));

        public void OpenVideo() => FirstVideo.Click();

        public void OpenPage(string url) => OpenUrl(url);
    }
}
