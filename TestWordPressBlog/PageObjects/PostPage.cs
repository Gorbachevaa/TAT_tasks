using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Represents page with posts.
    /// </summary>
    public class PostPage : UserPage
    {
        public static readonly string POST_URL = @"http://localhost:8080/wp-admin/edit.php";
        By allPostLocator = By.XPath("//a[contains(text(), 'All Posts')]");
        By addNewLocator = By.XPath("//a[contains(text(), 'Add New')]");
        By firstPostLocator = By.XPath("//*[@id = 'the-list']/descendant::a[1]");
        public PostPage(IWebDriver browser) : base(browser) { }
        public IWebElement AddPostButton
        {
            get
            {
                return driver.FindElement(addNewLocator);
            }
        }
        public IWebElement FirstPostButton
        {
            get
            {
                return driver.FindElement(firstPostLocator);
            }
        }
        /// <summary>
        /// Opens Post page.
        /// </summary>
        /// <returns>This page.</returns>
        public PostPage OpenPostPage()
        {
            this.driver.Navigate().GoToUrl(POST_URL);
            return this;
        }
        public EditPostPage FirstPostClick()
        {
            FirstPostButton.Click();
            return new EditPostPage(driver);
        }
        /// <summary>
        /// Click to "Add new"
        /// </summary>
        /// <returns></returns>
        public AddPostPage AddPostClick()
        {
            AddPostButton.Click();
            return new AddPostPage(driver);
        }

    }
}
