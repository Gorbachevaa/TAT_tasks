using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Represents subscriber's page.
    /// </summary>
    public class SubscriberPage : BasePage
    {
        By manageProfilePage =  By.XPath("(//*[@class= 'wp-menu-name'])[2]");
        By firstNameLocator = By.XPath("(//*[@name= 'first_name'])");
        By updateProfileLocator = By.XPath("//*[@name= 'submit']");
        By messageUpdatedLocator = By.XPath("//*[contains(text(),'Profile updated')]");
        public SubscriberPage(IWebDriver driver) : base(driver) { }
        public IWebElement UpdateMessage
        {
            get
            {
                return driver.FindElement(messageUpdatedLocator);
            }
        }
        public IWebElement FirstNameBox
        {
            get
            {
                return driver.FindElement(firstNameLocator);
            }
        }
        public SubscriberPage ChangeSubscriberName(string name)
        {
            driver.FindElement(manageProfilePage).Click();
            FirstNameBox.Clear();
            FirstNameBox.SendKeys(name);
            driver.FindElement(updateProfileLocator).Click();
            return this;
        }
    }
}
