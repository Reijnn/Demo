using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Demo.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void TrelloCardsDisplayed()
        {
            app.WaitForElement(c => c.Text("Get Cards"));
            app.Tap(c => c.Text("Get Cards"));
            AppResult[] results = app.WaitForElement(c => c.Text("Test Card"));
            Assert.IsTrue(results.Any());
        }
    }
}
