using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class VideoPage : BasePage
    {
        public VideoPage(IWebDriver driver) : base(driver) { }

        private IWebElement Frame => Driver.FindElement(By.Id("widget7"));

        private void Switch() => Driver.SwitchTo().Frame(Frame);

        private IWebElement PlayButton =>
            Driver.FindElement(By.XPath("//*[@id=\"blueimp-gallery\"]/div/div[1]/div/a"));

        private IWebElement StopButton =>
            Driver.FindElement(By.XPath("//*[@id=\"movie_player\"]/div[29]/div[2]/div[1]/button"));

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
