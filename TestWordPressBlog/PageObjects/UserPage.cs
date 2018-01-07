using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Class contains properties of all necessary web elements of the User page. 
    /// Also, there you can find all actions that can be performed.
    /// All validations can be placed here too. 
    /// </summary>
    public class UserPage : BasePage
    {
        By accountLocator = By.XPath("//*[@title='My Account']");
        By logoutLocator = By.XPath("//*[contains(text(), 'Log Out')]");
        //private IWebDriver driver;
        public UserPage(IWebDriver driver) : base(driver) { }
        public IWebElement AccountBox
        {
            get
            {
                return driver.FindElement(accountLocator);
            }
        }
        public IWebElement LogOutLink
        {
            get
            {
                var dynamicElement = (new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
                .Until(ExpectedConditions.ElementIsVisible(logoutLocator));
                return driver.FindElement(logoutLocator);
            }
        }
        /// <summary>
        /// Click to the account box.
        /// </summary>
        /// <returns>This page.</returns>
        public UserPage AccountBoxClick()
        {
            AccountBox.Click();
            return this;
        }
        /// <summary>
        /// Click to the logout
        /// </summary>
        /// <returns>Login page</returns>
        public LoginPage LogOut()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(AccountBox).Perform();
            LogOutLink.Click();
            return new LoginPage(driver);
        }
    }
}
