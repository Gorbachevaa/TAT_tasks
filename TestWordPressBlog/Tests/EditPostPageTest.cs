using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class EditPostPageTest : BaseTest
    {
        private EditPostPage editPostPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            editPostPage = new PostPage(Driver).OpenPostPage().FirstPostClick();
        }
        [Test]
        public void PresenceEditPostTextTest()
        {
            Assert.IsTrue(editPostPage.EditPostText.Displayed);
        }
        [Test]
        public void MovingToTrashPostTest()
        {
            Assert.IsTrue(editPostPage.MoveToTrash().MovedToTrashMessageBox.Displayed);
        }
        [Test]
        public void EdittingFirstPostTest()
        {
            Assert.IsTrue(editPostPage.AddPost("New post", "New life.").MessageBox.Displayed);
        }
    }
}
