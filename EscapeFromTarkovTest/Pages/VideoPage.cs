using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class VideoPage
    {
        private readonly IWebDriver _driver;

        public VideoPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement Frame => _driver.FindElement(By.Id("widget7"));

        private void Switch() => _driver.SwitchTo().Frame(Frame);

        private IWebElement PlayButton =>
            _driver.FindElement(By.XPath("//*[@id=\"blueimp-gallery\"]/div/div[1]/div/a"));

        private IWebElement StopButton =>
            _driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[29]/div[2]/div[1]/button"));

        private IWebElement Timer =>
            _driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[29]/div[2]/div[1]/div[1]/span[1]"));

        public void PlayVideo() => PlayButton.Click();

        public void CheckVideoPlaying(string text) => Assert.True(IsVideoPlaying(text));

        private bool IsVideoPlaying(string text) => GetButtonText().Contains(text);

        private string GetButtonText()
        {
            Switch();
            return StopButton.GetAttribute("title");
        }
    }
}
