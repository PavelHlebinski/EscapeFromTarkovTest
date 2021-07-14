using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class MediaPage
    {
        private readonly IWebDriver _driver;

        public MediaPage(IWebDriver driver) => _driver = driver;

        private IWebElement FirstVideo => _driver.FindElement(By.XPath("//*[@id=\"media_328\"]//a"));

        public void OpenVideo() => FirstVideo.Click();

    }
}
