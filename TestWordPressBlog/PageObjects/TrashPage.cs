using System;
using OpenQA.Selenium;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Class presents page that stores posts moved to trash.
    /// On this page is possible to  delete posts.
    /// </summary>
    public class TrashPage : BasePage
    {
        public static readonly string TRASH_URL = @"http://localhost:8080/wp-admin/edit.php?post_status=trash&post_type=post";
        By trashEmptyButtonLocator = By.XPath("//*[@value= 'Filter']/following-sibling::input");
        By deletePostLocator = By.XPath("//*[@class= 'delete']/.//a");
        By restorePostLocator = By.XPath("//*[@class= 'untrash']/.//a");
        By deletePostMessage = By.XPath("//*[contains( text(), 'Item permanently deleted.')]");
        By emptyTrashMessage = By.XPath("//*[contains(text(), 'No posts')]");
        By restorePostMessage = By.XPath("//*[contains( text(), 'Item restored')]");
        By checkboxPostLocator = By.XPath("(//*[@class= 'check-column'])[1]");
        public TrashPage(IWebDriver driver) : base(driver) { }
        public IWebElement TrashEmptyButton
        {
            get
            {
                return driver.FindElement(trashEmptyButtonLocator);
            }
        }
        public IWebElement DeletePostButton
        {
            get
            {
                return driver.FindElement(deletePostLocator);
            }
        }
        public IWebElement RestorePostButton
        {
            get
            {
                return driver.FindElement(restorePostLocator);
            }
        }
        public IWebElement RestorePostMessage
        {
            get
            {
                return driver.FindElement(restorePostMessage);
            }
        }
        public IWebElement DeletePostMessage
        {
            get
            {
                return driver.FindElement(deletePostMessage);
            }
        }
        public IWebElement EmptyTrashMessage
        {
            get
            {
                return driver.FindElement(emptyTrashMessage);
            }
        }
        public IWebElement PostCheckbox
        {
            get
            {
                return driver.FindElement(checkboxPostLocator);
            }
        }
        /// <summary>
        /// Opens the page that stores posts in the trash.
        /// </summary>
        /// <returns>Page with posts in the trash.</returns>
        public TrashPage OpenTrashPage()
        {
            driver.Navigate().GoToUrl(TRASH_URL);
            return this;
        }
        /// <summary>
        /// Click to the checkbox on page that chooses first post.
        /// </summary>
        /// <returns></returns>
        public TrashPage CheckBoxClick()
        {
            PostCheckbox.Click();
            return this;
        }
        /// <summary>
        /// Deletes post from the trash.
        /// </summary>
        /// <returns>This page ater deleting the post.</returns>
        public TrashPage DeletePost()
        {
            CheckBoxClick();
            DeletePostButton.Click();
            return new TrashPage(driver);
        }
        /// <summary>
        /// Deletes all posts from the trash.
        /// </summary>
        /// <returns>This page after deleting all posts.</returns>
        public TrashPage DeleteAllPosts()
        {
            TrashEmptyButton.Click();
            return new TrashPage(driver);
        }
        /// <summary>
        /// Restores first post from the trash.
        /// </summary>
        /// <returns>This page after restoring the post.</returns>
        public TrashPage RestorePost()
        {
            CheckBoxClick();
            RestorePostButton.Click();
            return new TrashPage(driver);
        }
    }
}
