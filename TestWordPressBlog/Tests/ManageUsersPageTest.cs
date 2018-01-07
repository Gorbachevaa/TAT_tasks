using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class ManageUsersPageTest : BaseTest
    {
        private ManageUsersPage manageUsersPage;

        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            manageUsersPage = new ManageUsersPage(Driver).OpenManageUsersPage();
        }
        [Test]
        public void AddingUserTest()
        {
            User user = new User("Me", "me", "Me@mail.ru", UserRole.Author);
            Assert.IsTrue(manageUsersPage.AddUser(user).AddUserMessage.Displayed);
        }
        [Test]
        public void DeletingAuthorUserTest()
        {
            Assert.IsTrue(manageUsersPage.OpenAllUsers().DeleteAuthor().DeleteUserMessage.Displayed);
        }
    }
}
