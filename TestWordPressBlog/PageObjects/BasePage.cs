using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TestWordPressBlog.PageObjects
{
    /// <summary>
    /// Class contains necessary methods for every page. 
    /// </summary>
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver browser)
        {
            this.driver = browser;
        }
        /// <summary>
        /// Gets url of the page.
        /// </summary>
        public string GetUrl
        {
            get
            {
                return driver.Url;
            }
        }
    }
}
