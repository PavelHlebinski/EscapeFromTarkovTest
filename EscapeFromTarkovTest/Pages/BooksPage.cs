using EscapeFromTarkovTest.Elements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace EscapeFromTarkovTest.Pages
{
    public class BooksPage : BasePage
    {
        public BooksPage(IWebDriver driver) : base(driver) { }

        private const string BooksLocator = "//*[@class=\"title\"][contains(text(),'Хозяин')]";

        private WebElements BooksList =>
            new WebElements(Driver, By.XPath(BooksLocator));

        private WebElements BooksPriceList =>
            new WebElements(Driver, By.XPath($"{BooksLocator}/..//..//span[text()=\"260₽\"]"));

        public void CheckBookPrice(string price, string bookName) => Assert.IsTrue(IsBookNameCorrect(bookName) == IsPriceCorrect(price));

        private bool IsPriceCorrect(string price) => BooksPriceList.FirstElement().Text.Contains(price);

        private bool IsBookNameCorrect(string bookName) => BooksList.FirstElement().Text.Contains(bookName);
    }
}
