using Xamarin.Forms;

namespace Smarties
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabs = new TabbedPage();

            var tab1 = new NavigationPage(new SmartiesPage());
            tab1.Title = "Home";


            var generalSettingsPage = new GeneralSettingsPage();
            generalSettingsPage.BindingContext = AppContext.GeneralSettings;
            var tab2 = new NavigationPage(generalSettingsPage);
            tab2.Title = "Settings";

            tabs.Children.Add(tab1);
            tabs.Children.Add(tab2);

            MainPage = tabs;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
