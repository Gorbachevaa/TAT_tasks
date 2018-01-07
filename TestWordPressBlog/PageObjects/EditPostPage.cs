using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Represents page that edits posts.
    /// </summary>
    public class EditPostPage : AddPostPage
    {
        By messageAfterAddingPostLocator = By.XPath("//*[contains(text(), 'Post updated')]");
        By editPostTextLocator = By.XPath("//div/*[contains(text(), 'Edit Post')]");
        By moveToTrashLocator = By.XPath("//*[@id = 'delete-action']/a");
        By movedToTheTrashMessageLocator = By.XPath("//*[@id = 'message']/p");
        public EditPostPage(IWebDriver driver) : base(driver) { }
        public IWebElement MessageBox
        {
            get
            {
                var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(messageAfterAddingPostLocator));
                return driver.FindElement(messageAfterAddingPostLocator);
            }
        }
        public IWebElement MovedToTrashMessageBox
        {
            get
            {
                return driver.FindElement(movedToTheTrashMessageLocator);
            }
        }
        public IWebElement EditPostText
        {
            get
            {
                return driver.FindElement(editPostTextLocator);
            }
        }
        public IWebElement MoveToTrashLink
        {
            get
            {
                return driver.FindElement(moveToTrashLocator);
            }
        }
        /// <summary>
        /// Opens edit post page.
        /// </summary>
        /// <returns></returns>
        public EditPostPage OpenEditPostPage()
        {
            new PostPage(driver).FirstPostClick();
            return this;
        }
        /// <summary>
        /// Moves post to the trash.
        /// </summary>
        /// <returns>This page</returns>
        public EditPostPage MoveToTrash()
        {
            MoveToTrashLink.Click();
            return new EditPostPage(driver);
        }

    }
}
