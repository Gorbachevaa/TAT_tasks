using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    class LoginPageTest : BaseTest
    {
        private static readonly User[] UserForLogining = 
        {
            new User ("admin", "1qaz@WSX", UserRole.Administrator),
            new User ("Author", "1qaz@WSXa", UserRole.Author),
            new User ("Contributor", "1qaz@WSXc", UserRole.Contributor),
            new User ("Editor", "1qaz@WSXe", UserRole.Editor),
            new User ("Subscriber", "1qaz@WSXs", UserRole.Subscriber)
        };
        private static readonly User[] UserWithWrongPasswords = 
        {
            new User ("admin", "1qaz@WS", UserRole.Administrator),
            new User ("Author", "1qaz@WSX", UserRole.Author),
            new User ("Contributor", "1qaz@WSX", UserRole.Contributor),
            new User ("Editor", "1qaz@WSX", UserRole.Editor),
            new User ("Subscriber", "1qaz@WSX", UserRole.Subscriber)
        };
        private LoginPage loginPage;
        [SetUp]
        public void InitializePage()
        {
            loginPage = new LoginPage(Driver);
        }
        /// <summary>
        /// To login as admin.
        /// </summary>
        [Test]
        public void WordpressLoginTest()
        {
            loginPage = new LoginPage(Driver);
            //this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
            IWebElement loginPageTitle = loginPage.LoginIntoBlog("admin", "1qaz@WSX");
            Assert.AreEqual(Driver.FindElement(By.XPath("//*[@title='My Account']")), loginPageTitle);
        }
        /// <summary>
        /// Checks every registered user in the blog.
        /// </summary>
        /// <param name="UserForLogining">Array of users</param>
        [Test, TestCaseSource("UserForLogining")]
        public void LoginForAllUsersTest(User UserForLogining)
        {
            User user = UserForLogining;
            UserPage userPage = loginPage.LoginAs(user);
            Assert.IsTrue(userPage.AccountBox.Displayed);
        }
        /// <summary>
        /// Checks users with wrong passwords.
        /// </summary>
        /// <param name="UserWithWrongPasswords"></param>
        [Test, TestCaseSource("UserWithWrongPasswords")]
        public void WrongPasswordForAllUsersTest(User UserWithWrongPasswords)
        {
            User user = UserWithWrongPasswords;
            loginPage = loginPage.LoginWithErrorAs(UserWithWrongPasswords);
            Assert.IsTrue(loginPage.ErrorBox.Displayed);
        }
    }
}
