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
    public partial class EtTavuk : ContentPage
    {
        List<Entity> at1;
        List<Entity> at2;
        List<Entity> beyaz1 = new List<Entity> { };
        List<Entity> beyaz2 = new List<Entity> { };
        List<Entity> kir1 = new List<Entity> { };
        List<Entity> kir2 = new List<Entity> { };
        List<Entity> deniz1 = new List<Entity> { };
        List<Entity> deniz2 = new List<Entity> { };
        public EtTavuk()
        {
            InitializeComponent();
            at1 = new List<Entity> {
             new Entity{Adi="Piliç Tavuk", Fiyati=7.35, Resimi="tavuk.jpg", Tagi="beyaz" , Navigationpage="Domates"},
             new Entity{Adi="Köfte", Fiyati=2.90, Resimi="kofte.jpg", Tagi="kirmizi"},
             new Entity{Adi="Balık", Fiyati=10.9, Resimi="balik.jpg", Tagi="deniz",Navigationpage="hazir"}
            };
            at2 = new List<Entity> {
            new Entity{Adi="Şinitzel", Fiyati=8.90, Resimi="sinitzel.jpg", Tagi="beyaz"},
             new Entity{Adi="Kokoreç", Fiyati=11.90, Resimi="kokorec.jpg", Tagi="kirmizi"},
             new Entity{Adi="Ton Balığı", Fiyati=9.5, Resimi="ton.jpg", Tagi="deniz"}
            };
            beyaz1 = new List<Entity> { };
            beyaz2 = new List<Entity> { };
            kir1 = new List<Entity> { };
            kir2 = new List<Entity> { };
            deniz1 = new List<Entity> { };
            deniz2 = new List<Entity> { };

            foreach (var item in at1)
            {
                if (item.Tagi == "beyaz")
                {
                    beyaz1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "beyaz")
                {
                    beyaz2.Add(item);
                }
            }
            foreach (var item in at1)
            {
                if (item.Tagi == "kirmizi")
                {
                    kir1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "kirmizi")
                {
                    kir2.Add(item);
                }
            }
            foreach (var item in at1)
            {
                if (item.Tagi == "deniz")
                {
                    deniz1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "deniz")
                {
                    deniz2.Add(item);
                }
            }
            lst1.ItemsSource = at1;
            lst2.ItemsSource = at2;
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
        private void beyazBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = beyaz1;
            lst2.ItemsSource = beyaz2;
        }
        private void kirmiziBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = kir1;
            lst2.ItemsSource = kir2;
        }
        private void denizBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = deniz1;
            lst2.ItemsSource = deniz2;
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
        private async void unlu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UnluMamuller());
        }
        private async void atistirmalik_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Atistirmalik());
        }
        private async void et_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EtTavuk());
        }
    }
}