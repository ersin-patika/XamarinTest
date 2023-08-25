using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SecureSafe.Services;
using SecureSafe.Views;
using Xamarin.Essentials;

namespace SecureSafe
{
    public partial class App : Application
    {
        public static object myCustomPopup;

        public App ()
        {
            InitializeComponent();
            DependencyService.Register<BeerService>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        protected override void OnSleep ()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        protected override void OnResume ()
        {
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        /// <summary>
        /// Internet Control
        /// </summary>
        /// <returns>Network States .</returns>        
        /// 
        void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            // You must create a warning screen in the app        
            var networkStatus = e.NetworkAccess.ToString();
            if (e.NetworkAccess == NetworkAccess.Internet)
            {                
                Console.Write("Internet Status:" + "Internet is available.");
            }
            else
            {
                Console.Write("Internet Status:" + "No internet connection.");
            }
        }

    }
}

