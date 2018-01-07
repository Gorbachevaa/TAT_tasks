using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class TrashPageTest : BaseTest
    {
        private TrashPage trashPage;
        [SetUp]
        public void InitialzePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            trashPage = new TrashPage(Driver).OpenTrashPage();
        }
        [Test]
        public void DeletingPostTest()
        {
            Assert.IsTrue(trashPage.DeletePost().DeletePostMessage.Displayed);
        }
        [Test]
        public void DeletingAllPostsTest()
        {
            Assert.IsTrue(trashPage.DeleteAllPosts().EmptyTrashMessage.Displayed);
        }
        [Test]
        public void RestoringPostTest()
        {
            Assert.IsTrue(trashPage.RestorePost().RestorePostMessage.Displayed);
        }
    }
}
