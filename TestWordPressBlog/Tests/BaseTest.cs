using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected const string BASE_URL = @"http:\\localhost:8080\wp-login.php";
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait Wait { get; set; }
        [OneTimeSetUp]
        public void SetupTest()
        {
            this.Driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            Driver.Manage().Window.Maximize();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(100));
        }
        [SetUp]
        public void BeforeTest()
        {
            Driver.Navigate().GoToUrl(BASE_URL);
        }
        [OneTimeTearDown]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }
    }
}
