using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace TestWordPressBlog.PageObjects
{
    public class AddPostPage : UserPage
    {
        public static readonly string ADDPOST_URL = @"http://localhost:8080/wp-admin/post-new.php";
        By addNewLocator = By.XPath("//a[contains(text(), 'Add New')]");
        By titleLocator = By.XPath("//*[@id = 'title']");
        By textLocator = By.XPath("//*[@id = 'tinymce']");
        By publishButtonLocator = By.XPath("//*[@id = 'publish']");
        string frameId = "content_ifr";
        public AddPostPage(IWebDriver browser) : base(browser) { }

        public IWebElement TitleBox
        {
            get
            {
                return driver.FindElement(titleLocator);
            }
        }
        public IWebElement TextBox
        {
            get
            {
                return driver.FindElement(textLocator);
            }
        }
        public IWebElement PublishButton
        {
            get
            {
                return driver.FindElement(publishButtonLocator);
            }
        }
        /// <summary>
        /// Opens AddNewPost page.
        /// </summary>
        /// <returns></returns>
        public AddPostPage OpenAddPostPage()
        {
            this.driver.Navigate().GoToUrl(ADDPOST_URL);
            return this;
        }
        /// <summary>
        /// Enters title for post.
        /// </summary>
        /// <param name="title">An entered text</param>
        /// <returns>This page after entering title</returns>
        public AddPostPage EnterTitle(string title)
        {
            TitleBox.Clear();
            TitleBox.SendKeys(title);
            return new AddPostPage(driver);
        }
        /// <summary>
        /// Enters text for post.
        /// </summary>
        /// <param name="text">Entered text</param>
        /// <returns>This page after entering text</returns>
        public AddPostPage EnterText(string text)
        {
            driver.SwitchTo().Frame(frameId);
            TextBox.Clear();
            TextBox.SendKeys(text);
            driver.SwitchTo().DefaultContent();
            return new AddPostPage(driver);
        }
        /// <summary>
        /// Submits publish button.
        /// </summary>
        /// <returns>New edit edit page after adding element.</returns>
        public EditPostPage SubmitPublishButton()
        {
            var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(publishButtonLocator));
            PublishButton.Click();
            return new EditPostPage(driver);
        }
        /// <summary>
        /// Adds a new post to the blog.
        /// </summary>
        /// <param name="title">Title of the post</param>
        /// <param name="text">Text of the post</param>
        /// <returns></returns>
        public EditPostPage AddPost(string title, string text)
        {
            EnterTitle(title);
            EnterText(text);
            return SubmitPublishButton();
        }
    }
}
