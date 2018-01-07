using System;
using OpenQA.Selenium;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Page represents page for comments.
    /// </summary>
    public class CommentPage : BasePage
    {
        By commentCheckbox = By.XPath("(//*[@class = 'check-column'])[1]");
        By editCommentLocator = By.XPath("//*[@title= 'Edit comment']");
        By editNameLocator = By.XPath("//*[@name= 'newcomment_author']");
        By updateCommentLocator = By.XPath("//*[@value = 'Update']");
        By actualTextLocator = By.XPath("//*[@class= 'author column-author']/.//strong");
        const string COMMENT_URL = "http://localhost:8080/wp-admin/edit-comments.php";
        public CommentPage(IWebDriver driver) : base(driver) { }
        public IWebElement EditNameBox
        {
            get
            {
                return driver.FindElement(editNameLocator);
            }
        }
        public IWebElement EditCommentButton
        {
            get
            {
                return driver.FindElement(editCommentLocator);
            }
        }
        public IWebElement UpdateCommentButton
        {
            get
            {
                return driver.FindElement(updateCommentLocator);
            }
        }
        public IWebElement CommentCheckbox
        {
            get
            {
                return driver.FindElement(commentCheckbox);
            }
        }
        public string ActualText
        {
            get
            {
                return driver.FindElement(actualTextLocator).Text;
            }
        }
        /// <summary>
        /// Opens page with comments.
        /// </summary>
        public CommentPage OpenCommentPage()
        {
            driver.Navigate().GoToUrl(COMMENT_URL);
            return this;
        }
        /// <summary>
        /// Types name to the comment.
        /// </summary>
        /// <param name="name">Inputed name.</param>
        /// <returns>This page.</returns>
        public CommentPage TypeNewName(string name)
        {
            EditNameBox.Clear();
            EditNameBox.SendKeys(name);
            return new CommentPage(driver);
        }
        public CommentPage UpdateButtonClick()
        {
            UpdateCommentButton.Click();
            return this;
        }
        /// <summary>
        /// Edit first comment in the list of comments.
        /// </summary>
        /// <param name="name">Changed name in the comment.</param>
        /// <returns>This page.</returns>
        public CommentPage EditFirstComment(string name)
        {
            CommentCheckbox.Click();
            EditCommentButton.Click();
            TypeNewName(name);
            return UpdateButtonClick();
        }
    }
}
