using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class EditorPageTest : BaseTest
    {
        EditorPage editorPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("Editor", "1qaz@WSXe", UserRole.Editor));
            editorPage = new EditorPage(Driver);
        }
        [Test]
        public void EditingPostByEditorTest()
        {
            Assert.IsTrue(editorPage.EditPost("New", "Life").MessageBox.Displayed);
        }
        [Test]
        public void EditingCommentByEditorTest()
        {
            Assert.IsTrue(new CommentPage(Driver).OpenCommentPage().EditFirstComment("New name").ActualText == "New name");
        }
    }
}
