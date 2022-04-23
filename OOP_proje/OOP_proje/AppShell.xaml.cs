using OOP_proje.ViewModels;
using OOP_proje.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OOP_proje
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
