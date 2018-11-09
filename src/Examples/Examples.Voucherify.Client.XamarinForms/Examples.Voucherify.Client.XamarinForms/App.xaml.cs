using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Examples.Voucherify.Client.XamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage(new string[] {
                "<app-id>", "<app-token>", "<your-code>"
            });
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
