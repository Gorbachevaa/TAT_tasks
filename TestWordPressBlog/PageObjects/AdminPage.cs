using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    public class AdminPage : UserPage
    {
        public static readonly string ADMIN_URL = @"http:\\localhost:8080\wp-admin\";
        By postsLocator = By.XPath("//div[contains(text(), 'Posts')]");
        By usersLocator = By.XPath("//div[contains(text(), 'Users')]");
        By commentsLocator = By.XPath("//div[contains(text(), 'Comments')]");
        By pagesLocator = By.XPath("//div[contains(text(), 'Pages')]");
        By addPostLocator = By.XPath("//*[contains(text(), 'blog post')]");
        public AdminPage(IWebDriver driver) : base(driver) { }

        public IWebElement PostButton
        {
            get
            {
                return driver.FindElement(postsLocator);
            }
        }
        public IWebElement UserButton
        {
            get
            {
                return driver.FindElement(usersLocator);
            }
        }
       
        public IWebElement CommentButton
        {
            get
            {
                return driver.FindElement(commentsLocator);
            }
        }
        public IWebElement PageButton
        {
            get
            {
                return driver.FindElement(pagesLocator);
            }
        }
        public IWebElement AddPostLink
        {
            get
            {
                return driver.FindElement(addPostLocator);
            }
        }

        public AdminPage OpenAdminPage()
        {
            driver.Url = ADMIN_URL;
            return this;
        }
        /// <summary>
        /// Submit Post button and goes to Post Page.
        /// </summary>
        /// <returns>Post page</returns>
        public PostPage SubmitPost()
        {
            PostButton.Click();
            return new PostPage(driver);
        }
        public AddPostPage Add()
        {
            AddPostLink.Click();
            return new AddPostPage(driver);
        }

    }
}
