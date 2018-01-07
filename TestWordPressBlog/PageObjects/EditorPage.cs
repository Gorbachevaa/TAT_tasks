using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    public class EditorPage : AuthorPage
    {
        By postsLocator = By.XPath("//div[contains(text(), 'Posts')]");
        By mineLocator = By.XPath("//*[contains(text(), 'Mine')]");
        By allLocator = By.XPath("//*[@class = 'all']");
        By editPostLocator = By.XPath("//*[@id = 'the-list']/.//a[1]");
        public EditorPage(IWebDriver driver) : base(driver) { }
        public IWebElement PostButton
        {
            get
            {
                return driver.FindElement(postsLocator);
            }
        }

    }
}
