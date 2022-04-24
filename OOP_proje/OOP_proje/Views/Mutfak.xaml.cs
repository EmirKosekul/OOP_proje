using OOP_proje.Models;
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
    public partial class Mutfak : ContentPage
    {
        List<Entity> mutfak1;
        List<Entity> mutfak2;
        List<Entity> z1 = new List<Entity> { };
        List<Entity> z2 = new List<Entity> { };
        List<Entity> ms1 = new List<Entity> { };
        List<Entity> ms2 = new List<Entity> { };
        public Mutfak()
        {
            InitializeComponent();
            mutfak1 = new List<Entity> {
             new Entity{Adi="Meşrubat Bardağı", Fiyati=17.35, Resimi="mesrubat.jpg", Tagi="z" , Navigationpage="Domates"},
             new Entity{Adi="Buzdolabı Poşeti", Fiyati=9.90, Resimi="buzdolabiposeti.jpg", Tagi="ms"},
            };
            mutfak2 = new List<Entity> {
            new Entity{Adi="Çay Bardağı", Fiyati=8.90, Resimi="caybardagi.jpg", Tagi="z"},
             new Entity{Adi="Karton Tabak", Fiyati=11.90, Resimi="kartontabak.jpg", Tagi="ms"},
            };
            z1 = new List<Entity> { };
            z2 = new List<Entity> { };
           ms1 = new List<Entity> { };
            ms2 = new List<Entity> { };

            foreach (var item in mutfak1)
            {
                if (item.Tagi == "z")
                {
                    z1.Add(item);
                }
            }
            foreach (var item in mutfak2)
            {
                if (item.Tagi == "z")
                {
                    z2.Add(item);
                }
            }
            foreach (var item in mutfak1)
            {
                if (item.Tagi == "ms")
                {
                    ms1.Add(item);
                }
            }
            foreach (var item in mutfak2)
            {
                if (item.Tagi == "ms")
                {
                    ms2.Add(item);
                }
            }
            lst1.ItemsSource = mutfak1;
            lst2.ItemsSource = mutfak2;
        }
        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as Entity));
        }
        private void lst2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as Entity));
        }
        private void zBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = z1;
            lst2.ItemsSource = z2;
        }
        private void mutfakSarfBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = ms1;
            lst2.ItemsSource = ms2;
        }
        private async void icecek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Icecek());
        }
        private async void meyve_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveVeSebze());
        }
        private async void mutfak_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mutfak());
        }
    }
}