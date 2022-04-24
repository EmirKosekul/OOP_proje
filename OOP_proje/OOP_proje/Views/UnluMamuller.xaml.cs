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
    public partial class UnluMamuller : ContentPage
    {
        List<Entity> um1;
        List<Entity> um2;
        List<Entity> tatli1 = new List<Entity> { };
        List<Entity> tatli2 = new List<Entity> { };
        List<Entity> ekmek1 = new List<Entity> { };
        List<Entity> ekmek2 = new List<Entity> { };
        List<Entity> hazir1 = new List<Entity> { };
        List<Entity> hazir2 = new List<Entity> { };
        public UnluMamuller()
        {
            InitializeComponent();
            um1 = new List<Entity> {
             new Entity{Adi="Künefe", Fiyati=17.35, Resimi="kunefe.jpg", Tagi="tatli" , Navigationpage="Domates"},
             new Entity{Adi="Ekmek", Fiyati=2.90, Resimi="ekmek.jpg", Tagi="ekmek"},
             new Entity{Adi="Hazır Pasta Keki", Fiyati=10.9, Resimi="hazirpasta.jpg", Tagi="hazir",Navigationpage="hazir"}
            };
            um2 = new List<Entity> {
            new Entity{Adi="Mozaik Pasta", Fiyati=8.90, Resimi="mozaik.jpg", Tagi="tatli"},
             new Entity{Adi="Lavaş", Fiyati=11.90, Resimi="lavas.jpg", Tagi="ekmek"},
             new Entity{Adi="Galeta", Fiyati=9.5, Resimi="galeta.jpg", Tagi="hazir"}
            };
            tatli1 = new List<Entity> { };
            tatli2 = new List<Entity> { };
            ekmek1 = new List<Entity> { };
            ekmek2 = new List<Entity> { };
            hazir1 = new List<Entity> { };
            hazir2 = new List<Entity> { };

            foreach (var item in um1)
            {
                if (item.Tagi == "tatli")
                {
                    tatli1.Add(item);
                }
            }
            foreach (var item in um2)
            {
                if (item.Tagi == "tatli")
                {
                    tatli2.Add(item);
                }
            }
            foreach (var item in um1)
            {
                if (item.Tagi == "ekmek")
                {
                    ekmek1.Add(item);
                }
            }
            foreach (var item in um2)
            {
                if (item.Tagi == "ekmek")
                {
                    ekmek2.Add(item);
                }
            }
            foreach (var item in um1)
            {
                if (item.Tagi == "hazir")
                {
                    hazir1.Add(item);
                }
            }
            foreach (var item in um2)
            {
                if (item.Tagi == "hazir")
                {
                    hazir2.Add(item);
                }
            }
            lst1.ItemsSource = um1;
            lst2.ItemsSource = um2;

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
        private void tatliBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = tatli1;
            lst2.ItemsSource = tatli2;
        }
        private void ekmekBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = ekmek1;
            lst2.ItemsSource = ekmek2;
        }
        private void hazirBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = hazir1;
            lst2.ItemsSource = hazir2;
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