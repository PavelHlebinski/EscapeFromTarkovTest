using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class VideoPage : BasePage
    {
        public VideoPage(IWebDriver driver) : base(driver) { }

        private const string StopButtonLocator = "//*[@id=\"movie_player\"]/div[29]/div[2]/div[1]/button";

        private WebElement Frame => new WebElement(Driver, By.Id("widget7"));

        private WebElement PlayButton => new WebElement(Driver, By.XPath("//*[@id=\"blueimp-gallery\"]/div/div[1]/div/a"));

        private WebElement StopButton => new WebElement(Driver, By.XPath(StopButtonLocator));

        public void PlayVideo() => PlayButton.Click();

        public void CheckVideoPlaying(string text) => Assert.True(IsVideoPlaying(text));

        private bool IsVideoPlaying(string text) => GetButtonText().Contains(text);

        private string GetButtonText()
        {
            do
            {
                Driver.SwitchTo().DefaultContent();
                Frame.Switch();
            } while (Driver.FindElements(By.XPath(StopButtonLocator)).Count == 0);
            return StopButton.GetAttribute("title");
        }
    }
}
