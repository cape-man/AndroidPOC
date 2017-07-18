using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
   // [TestFixture(Platform.iOS)]
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
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void NewTest()
        {
            app.Screenshot("Screenshot");
            app.DoubleTap(x => x.Text("Flight Status"));
            app.Tap(x => x.Id("text1"));
            app.EnterText(x => x.Class("EditText"), "B");
            app.EnterText(x => x.Class("EntryEditText"), "S");
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "1234");
            app.DoubleTap(x => x.Text("18/07/2017"));
            app.DoubleTap(x => x.Id("button1"));
            app.DoubleTap(x => x.Text("Brussels Airlines"));
            app.Tap(x => x.Text("Lufthansa Airlines"));
            app.EnterText(x => x.Class("EditText").Text("Brussels Airlines"), "s");
            app.ClearText(x => x.Class("EntryEditText").Text("1234"));
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "56");
            app.DoubleTap(x => x.Class("AppCompatButton").Text("Search"));
            app.Tap(x => x.Class("FormsImageView").Index(4));
            app.Screenshot("Tapped on view with class: FormsImageView");
            app.Tap(x => x.Class("FormsImageView").Index(8));
        }
    }
}

