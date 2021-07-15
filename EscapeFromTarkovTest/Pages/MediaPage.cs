﻿using EscapeFromTarkovTest.Elements;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class MediaPage : BasePage
    {
        public MediaPage(IWebDriver driver) : base(driver) { }

        private WebElement FirstVideo => new WebElement(Driver, By.XPath("//*[@id=\"media_328\"]//a"));

        public void OpenVideo() => FirstVideo.Click();

        public void OpenPage(string url) => OpenUrl(url);
    }
}
