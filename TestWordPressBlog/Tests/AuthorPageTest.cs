using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class AuthorPageTest : BaseTest
    {
        private AuthorPage authorPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("Author", "1qaz@WSXa", UserRole.Author));
            authorPage = new AuthorPage(Driver);
        }
        [Test]
        public void EditingAuthorPostByAuthorTest()
        {
            Assert.IsTrue(authorPage.EditPost("Epam","").MessageBox.Displayed);
        }
    }
}
