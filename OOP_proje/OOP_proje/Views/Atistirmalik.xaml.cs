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
    public partial class Atistirmalik : ContentPage
    {
        List<Entity> at1;
        List<Entity> at2;
        List<Entity> cik1 = new List<Entity> { };
        List<Entity> cik2 = new List<Entity> { };
        List<Entity> kek1 = new List<Entity> { };
        List<Entity> kek2 = new List<Entity> { };
        List<Entity> kraker1 = new List<Entity> { };
        List<Entity> kraker2 = new List<Entity> { };
        public Atistirmalik()
        {
            InitializeComponent();
            at1 = new List<Entity> {
             new Entity{Adi="Eti Karam", Fiyati=7.35, Resimi="karam.jpg", Tagi="cik" , Navigationpage="Domates"},
             new Entity{Adi="Ülker Petibör", Fiyati=2.90, Resimi="ulkerpeti.jpg", Tagi="kek"},
             new Entity{Adi="Ülker Çubuk", Fiyati=10.9, Resimi="ulkercubuk.jpg", Tagi="kraker",Navigationpage="hazir"}
            };
            at2 = new List<Entity> {
            new Entity{Adi="Ülker Çikolata", Fiyati=8.90, Resimi="ulker.jpg", Tagi="cik"},
             new Entity{Adi="Eti Burçak", Fiyati=11.90, Resimi="burcak.jpg", Tagi="kek"},
             new Entity{Adi="Eti Çubuk", Fiyati=9.5, Resimi="eticubuk.jpg", Tagi="kraker"}
            };
            cik1 = new List<Entity> { };
            cik2 = new List<Entity> { };
            kek1 = new List<Entity> { };
            kek2 = new List<Entity> { };
            kraker1 = new List<Entity> { };
            kraker2 = new List<Entity> { };

            foreach (var item in at1)
            {
                if (item.Tagi == "cik")
                {
                    cik1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "cik")
                {
                    cik2.Add(item);
                }
            }
            foreach (var item in at1)
            {
                if (item.Tagi == "kek")
                {
                    kek1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "kek")
                {
                    kek2.Add(item);
                }
            }
            foreach (var item in at1)
            {
                if (item.Tagi == "kraker")
                {
                    kraker1.Add(item);
                }
            }
            foreach (var item in at2)
            {
                if (item.Tagi == "kraker")
                {
                    kraker2.Add(item);
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
        private void cikBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = cik1;
            lst2.ItemsSource = cik2;
        }
        private void kekBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = kek1;
            lst2.ItemsSource = kek2;
        }
        private void krakerBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = kraker1;
            lst2.ItemsSource = kraker2;
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