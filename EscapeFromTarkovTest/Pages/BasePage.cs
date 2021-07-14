using System;
using System.Collections.Generic;
using System.Text;
using EscapeFromTarkovTest.Drivers;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver) => Driver = driver;

        protected void OpenUrl(string url)
        {
            try
            {
                Driver.Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }
    }
}
