using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace Demo {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new DemoPage());
        }

        protected override void OnStart() {
            MobileCenter.Start("android=fc4836ed-9aa4-4f47-9467-33bb0c616f61;" +
                               "ios=6e83aec0-067d-4855-8a7f-58a0b40c27dc;",
                   typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
