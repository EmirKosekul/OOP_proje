using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OOP_proje.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private async void Domates_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveVeSebze());
        }
        private async void Icecek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Icecek());
        }
        private async void Mutfak_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mutfak());
        }
        private async void UnluMamuller_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnluMamuller());
        }
    }
}