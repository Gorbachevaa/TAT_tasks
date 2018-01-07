using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    public class UserPageTest : BaseTest
    {
        private static readonly User[] UserForLogining = 
        {
            new User ("admin", "1qaz@WSX", UserRole.Administrator),
            new User ("Author", "1qaz@WSXa", UserRole.Author),
            new User ("Contributor", "1qaz@WSXc", UserRole.Contributor),
            new User ("Editor", "1qaz@WSXe", UserRole.Editor),
            new User ("Subscriber", "1qaz@WSXs", UserRole.Subscriber)
        };
        UserPage userPage;
        [SetUp]
        public void InitializePage()
        {
            userPage = new UserPage(Driver);
        }
        [Test,TestCaseSource("UserForLogining")]
        public void LogoutUserTest(User UserForLogining)
        {
            User user = UserForLogining;
            new LoginPage(Driver).LoginAs(user);
            Assert.IsTrue(userPage.LogOut().LogOutText.Displayed);
        }
    }
}
