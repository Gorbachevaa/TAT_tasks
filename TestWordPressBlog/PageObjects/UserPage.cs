using System;
using OpenQA.Selenium;
using NUnit.Framework;

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

        //private IWebDriver driver;
        public UserPage(IWebDriver driver) : base(driver) { }
        public IWebElement AccountBox
        {
            get
            {
                return driver.FindElement(accountLocator);
            }
        }
    }
}
