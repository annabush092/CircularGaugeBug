using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCircularGauge
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzAzNDQyQDMxMzgyZTMyMmUzMGZVdTdGZGo3VUpSNGw2cDNtdjVnMlJyOGZDSWY4RDE5RTVHOHNMeFNYbVU9");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
