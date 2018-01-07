using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class AdminPageTest : BaseTest
    {
        private AdminPage adminPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            adminPage = new AdminPage(Driver);
        }
        [Test]
        public void AddingPostsAbilityTest()
        {
            Assert.IsTrue(adminPage.PostButton.Displayed);
        }
        [Test]
        public void AddingUsersAbilityTest()
        {
            Assert.IsTrue(adminPage.UserButton.Displayed);
        }
        [Test]
        public void AddingCommentsAbilityTest()
        {
            Assert.IsTrue(adminPage.CommentButton.Displayed);
        }
        [Test]
        public void AddingPagesAbilityTest()
        {
            Assert.IsTrue(adminPage.PageButton.Displayed);
        }
        [Test]
        public void LinkForAddingUserTest()
        {
            Assert.IsTrue(adminPage.Add().GetUrl == "http://localhost:8080/wp-admin/post-new.php");
        }
    }
}
