using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Class that represents page that manages users.
    /// </summary>
    public class ManageUsersPage : BasePage
    {
        By loginLocator = By.Id("user_login");
        By emailLocator = By.Id("email");
        By passwordFirstLocator = By.Id("pass1");
        By passwordSecondLocator = By.Id("pass2");
        By roleComboboxLocator = By.Id("role");
        By addUserLocator = By.XPath("//p/*[@name= 'createuser']");
        By addUserMessage = By.XPath("//*[contains(text(),'user created')]");
        By deleteAuthorLocator = By.XPath
            ("(//*[@class= 'role column-role' and contains(text(), 'Author')])[1]/preceding-sibling::td/descendant::*[@class = 'submitdelete']");
        By authorCheckboxLocator = By.XPath
            ("(//*[@class= 'role column-role' and contains(text(), 'Author')])[1]/preceding-sibling::*[@class = 'check-column']");
        By deleteOptionLocator = By.XPath("//*[@name = 'delete_option']");
        By confirmDeleteLocator = By.XPath("//*[@name = 'submit']");
        By deleteUserMessage = By.XPath("//*[contains(text(),'User deleted')]");
        By allUsersLocator = By.XPath("//*[contains(text(),'All Users')]");
        const string ADD_USERS_URL = @"http://localhost:8080/wp-admin/user-new.php";
        public ManageUsersPage(IWebDriver driver) : base(driver) { }
        public IWebElement AllUsersButton
        {
            get
            {
                return driver.FindElement(allUsersLocator);
            }
        }
        public IWebElement LoginBox
        {
            get
            {
                return driver.FindElement(loginLocator);
            }
        }
        public IWebElement MailBox
        {
            get
            {
                return driver.FindElement(emailLocator);
            }
        }
        public IWebElement PasswordFirstBox
        {
            get
            {
                return driver.FindElement(passwordFirstLocator);
            }
        }
        public IWebElement PasswordSecondBox
        {
            get
            {
                return driver.FindElement(passwordSecondLocator);
            }
        }
        public IWebElement RoleCombobox
        {
            get
            {
                return driver.FindElement(roleComboboxLocator);
            }
        }
        public IWebElement AddUserButton
        {
            get
            {
                return driver.FindElement(addUserLocator);
            }
        }
        public IWebElement AddUserMessage
        {
            get
            {
                return driver.FindElement(addUserMessage);
            }
        }
        public IWebElement AuthorCheckBox
        {
            get
            {
                return driver.FindElement(authorCheckboxLocator);
            }
        }
        public IWebElement DeleteAuthorButton
        {
            get
            {
                return driver.FindElement(deleteAuthorLocator);
            }
        }
        public IWebElement DeleteOptionButton
        {
            get
            {
                return driver.FindElement(deleteOptionLocator);
            }
        }
        public IWebElement ConfirmDeleteButton
        {
            get
            {
                return driver.FindElement(confirmDeleteLocator);
            }
        }
        public IWebElement DeleteUserMessage
        {
            get
            {
                return driver.FindElement(deleteUserMessage);
            }
        }
        /// <summary>
        /// Opens the list of all users.
        /// </summary>
        /// <returns>Page with all users.</returns>
        public ManageUsersPage OpenAllUsers()
        {
            AllUsersButton.Click();
            return this;
        }
        /// <summary>
        /// Opens page that manages users.
        /// </summary>
        /// <returns></returns>
        public ManageUsersPage OpenManageUsersPage()
        {
            driver.Navigate().GoToUrl(ADD_USERS_URL);
            return new ManageUsersPage(driver);
        }
        /// <summary>
        /// Adds new user to the blog.
        /// </summary>
        /// <param name="user">Added user.</param>
        /// <returns>This page after adding user.</returns>
        public ManageUsersPage AddUser(User user)
        {
            LoginBox.Clear();
            LoginBox.SendKeys(user.UserName);
            MailBox.Clear();
            MailBox.SendKeys(user.Mail);
            PasswordFirstBox.Clear();
            PasswordFirstBox.SendKeys(user.Password);
            PasswordSecondBox.Clear();
            PasswordSecondBox.SendKeys(user.Password);
            new SelectElement(RoleCombobox).SelectByValue(user.GetUserRole(user.Role));
            AddUserButton.Click();
            return this;
        }
        /// <summary>
        /// Deletes author in the list of users.
        /// </summary>
        /// <returns>This page after deleting.</returns>
        public ManageUsersPage DeleteAuthor()
        {
            AuthorCheckBox.Click();
            DeleteAuthorButton.Click();
            var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(deleteOptionLocator));
            DeleteOptionButton.Click();
            ConfirmDeleteButton.Click();
            return this;
        }

    }
}
