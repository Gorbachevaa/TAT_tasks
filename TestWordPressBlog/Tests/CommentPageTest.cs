using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class CommentPageTest : BaseTest
    {
        public CommentPage commentPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            commentPage = new CommentPage(Driver).OpenCommentPage();
        }
        [Test]
        public void EditCommentTest()
        {
            Assert.IsTrue(commentPage.EditFirstComment("SuperName").ActualText == "SuperName");
        }
    }
}
