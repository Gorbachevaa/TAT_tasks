using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Class contains properties of all necessary web elements of the Login page. 
    /// Also, there you can find all actions that can be performed (OpenPage, FindElement).
    /// </summary>
    public class LoginPage : BasePage
    {
        
        public static readonly string LOGIN_URL = @"http:\\localhost:8080\wp-login.php";
        By userNameLocator = By.Id("user_login");
        By passwordLocator = By.Id("user_pass");
        By loginButtonLocator = By.Id("wp-submit");
        By errorLocator = By.Id("login_error");

        public LoginPage(IWebDriver driver) : base(driver) { }
        /// <summary>
        /// Gets username box's locator.
        /// </summary>
        public IWebElement UserNameBox
        {
            get
            {
                return driver.FindElement(userNameLocator);
            }
        }
        /// <summary>
        /// Gets password box's locator.
        /// </summary>
        public IWebElement PasswordBox
        {
            get
            {
                return driver.FindElement(passwordLocator);
            }
        }
        /// <summary>
        /// Gets login button locator.
        /// </summary>
        public IWebElement LoginButton
        {
            get
            {
                return driver.FindElement(loginButtonLocator);
            }
        }
        public IWebElement ErrorBox
        {
            get
            {
                return driver.FindElement(errorLocator);
            }
        }
        /// <summary>
        /// Opens login page.
        /// </summary>
        /// <returns></returns>
        public LoginPage OpenLoginPage()
        {
            this.driver.Navigate().GoToUrl(LOGIN_URL);
            return this;
        }
        /// <summary>
        /// Method types username.
        /// </summary>
        /// <param name="username">Inputed username</param>
        /// <returns>Login page after changes</returns>
        public LoginPage TypeUserName(string username)
        {
            UserNameBox.Clear();
            UserNameBox.SendKeys(username);
            return this;
        }
        /// <summary>
        /// Method types password.
        /// </summary>
        /// <param name="password">Inputed password</param>
        /// <returns>Login page after change</returns>
        public LoginPage TypePassword(string password)
        {
            PasswordBox.Clear();
            PasswordBox.SendKeys(password);
            return this;
        }
        public UserPage SubmitLogin()
        {
            LoginButton.Click();
            return new UserPage(driver);
        }
        public LoginPage SubmitLoginExpectingFailure()
        {
            LoginButton.Click();
            return new LoginPage(driver);
        }
        /// <summary>
        /// Method logs into blog.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="passwd">Password</param>
        /// <returns>LoginPage title</returns>
        public IWebElement LoginIntoBlog(string username, string passwd)
        {
            TypeUserName(username);
            TypePassword(passwd);
            LoginButton.Click();
            IWebElement accountLocator = driver.FindElement(By.XPath("//*[@title='My Account']"));
            return accountLocator;
        }
        /// <summary>
        /// Logins as user with right login and password.
        /// </summary>
        /// <param name="user">User</param>
        /// <returns>User page.</returns>
        public UserPage LoginAs(User user)
        {
            var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(userNameLocator));
            TypeUserName(user.UserName);
            TypePassword(user.Password);
            return SubmitLogin();
        }
        /// <summary>
        /// Logins as users with wrong password.
        /// </summary>
        /// <param name="user">List of users</param>
        /// <returns>This page</returns>
        public LoginPage LoginWithErrorAs(User user)
        {
            var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(userNameLocator));
            TypeUserName(user.UserName);
            TypePassword(user.Password);
            return SubmitLoginExpectingFailure();
        }
    }
}
