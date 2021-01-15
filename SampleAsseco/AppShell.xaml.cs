using System;
using System.Collections.Generic;
using SampleAsseco.ViewModels;
using SampleAsseco.Views;
using Xamarin.Forms;

namespace SampleAsseco
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
