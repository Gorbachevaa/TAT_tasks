using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;


namespace TestWordPressBlog.Tests
{
    [TestFixture]
    public class AddPostPageTest : BaseTest
    {
        private static readonly Object[][] PostsForAdding = 
        {
            new Object[] {"Post", "True story"},
            new Object[] {"Post", ""},
        };
        private AddPostPage addPostPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("admin", "1qaz@WSX", UserRole.Administrator));
            addPostPage = new AddPostPage(Driver).OpenAddPostPage();
        }
        /// <summary>
        /// Tests adding new post for admin rights.
        /// </summary>
        /// <param name="PostsForAdding">List of posts</param>
        [Test, TestCaseSource("PostsForAdding")]
        public void AddPostTest(string title, string text)
        {
            Assert.IsTrue(addPostPage.AddPost(title, text).MessageBox.Displayed);
        }
    }
}
