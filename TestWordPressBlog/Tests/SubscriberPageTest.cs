using System;
using NUnit.Framework;
using TestWordPressBlog.PageObjects;

namespace TestWordPressBlog.Tests
{
    public class SubscriberPageTest : BaseTest
    {
        SubscriberPage subscriberPage;
        [SetUp]
        public void InitializePage()
        {
            new LoginPage(Driver).LoginAs(new User("Subscriber", "1qaz@WSXs", UserRole.Subscriber));
            subscriberPage = new SubscriberPage(Driver);
        }
        [Test]
        public void ManageSubscriberInfo()
        {
            Assert.IsTrue(subscriberPage.ChangeSubscriberName("Anna").UpdateMessage.Displayed);
        }
    }
}
