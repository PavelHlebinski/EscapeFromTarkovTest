using EscapeFromTarkovTest.Elements;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class MerchPage : BasePage
    {
        public MerchPage(IWebDriver driver) : base(driver) { }

        private WebElement BooksButton => new WebElement(Driver, By.XPath("//*[@class=\"category__title\"][text()=\"Книги\"]"));

        public void OpenBooksPage() => BooksButton.Click();
    }
}
