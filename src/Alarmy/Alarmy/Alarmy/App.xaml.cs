using Alarmy.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alarmy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // TODO : Read more documentation about stack on pages and etc.....         
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new NavigationPage(new ListAlarmPages());
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
