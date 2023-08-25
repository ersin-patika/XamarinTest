using System;
using System.Collections.Generic;
using SecureSafe.ViewModels;
using SecureSafe.Views;
using Xamarin.Forms;

namespace SecureSafe
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));            
        }

    }
}

