using System;
using OpenQA.Selenium;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Represents author page.
    /// </summary>
    public class AuthorPage : UserPage
    {
        By postsLocator = By.XPath("//div[contains(text(), 'Posts')]");
        By mineLocator = By.XPath("//*[contains(text(), 'Mine')]");
        By allLocator = By.XPath("//*[@class = 'all']");
        By editPostLocator = By.XPath("//*[@id = 'the-list']/.//a[1]");
        public AuthorPage(IWebDriver driver) : base(driver) { }
        public IWebElement PostButton
        {
            get
            {
                return driver.FindElement(postsLocator);
            }
        }
        public IWebElement MineButton
        {
            get
            {
                return driver.FindElement(mineLocator);
            }
        }
        public IWebElement AllButton
        {
            get
            {
                return driver.FindElement(allLocator);
            }
        }
        public IWebElement EditPostButton
        {
            get
            {
                return driver.FindElement(editPostLocator);
            }
        }
        /// <summary>
        /// Clicks to the button, then appera page to edditing post.
        /// </summary>
        /// <returns>Page for edditing</returns>
        public EditPostPage EditPostClick()
        {
            EditPostButton.Click();
            return new EditPostPage(driver);
        }
        /// <summary>
        /// Edits post.
        /// </summary>
        /// <param name="text">New text</param>
        /// <param name="title">New title</param>
        /// <returns>New </returns>
        public EditPostPage EditPost(string text, string title)
        {
            PostButton.Click();
            EditPostClick();
            return new EditPostPage(driver).AddPost(text,title);
        }
    }
}
