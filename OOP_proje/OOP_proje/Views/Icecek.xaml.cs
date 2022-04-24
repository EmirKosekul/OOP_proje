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
    public partial class Icecek : ContentPage
    {
        List<Entity> icecek1;
        List<Entity> icecek2;
        List<Entity> su1 = new List<Entity> { };
        List<Entity> su2 = new List<Entity> { };
        List<Entity> gazli1 = new List<Entity> { };
        List<Entity> gazli2 = new List<Entity> { };
        List<Entity> gazsiz1 = new List<Entity> { };
        List<Entity> gazsiz2 = new List<Entity> { };
        public Icecek()
        {
            InitializeComponent();
            icecek1 = new List<Entity> {
             new Entity{Adi="Hayat Su 10L", Fiyati=17.35, Resimi="hayatsu.jpg", Tagi="su" , Navigationpage="Domates"},
             new Entity{Adi="Kızılay Maden Suyu", Fiyati=9.90, Resimi="kizilaymaden.jpg", Tagi="su"},
             new Entity{Adi="Pepsi", Fiyati=10.9, Resimi="pepsi.jpg", Tagi="gazli",Navigationpage="Portakal"},
             new Entity{Adi="Lipton Ice Tea", Fiyati=7.90, Resimi="lipton.jpg", Tagi="gazsiz"},
            };
            icecek2 = new List<Entity> {
            new Entity{Adi="Akmina Maden Suyu", Fiyati=8.90, Resimi="akminamaden.jpg", Tagi="su"},
             new Entity{Adi="Coca Cola", Fiyati=11.90, Resimi="coca.jpg", Tagi="gazli"},
             new Entity{Adi="Bi Cola", Fiyati=19.5, Resimi="bicola.jpg", Tagi="gazli"},
             new Entity{Adi="Limonata", Fiyati=14.5, Resimi="limonata.jpg", Tagi="gazsiz" }
            };
            su1 = new List<Entity> { };
            su2 = new List<Entity> { };
            gazli1 = new List<Entity> { };
            gazli2 = new List<Entity> { };
            gazsiz1 = new List<Entity> { };
            gazsiz2 = new List<Entity> { };

            foreach (var item in icecek1)
            {
                if (item.Tagi == "su")
                {
                    su1.Add(item);
                }
            }
            foreach (var item in icecek2)
            {
                if (item.Tagi == "su")
                {
                    su2.Add(item);
                }
            }
            foreach (var item in icecek1)
            {
                if (item.Tagi == "gazli")
                {
                    gazli1.Add(item);
                }
            }
            foreach (var item in icecek2)
            {
                if (item.Tagi == "gazli")
                {
                   gazli2.Add(item);
                }
            }
            foreach (var item in icecek1)
            {
                if (item.Tagi == "gazsiz")
                {
                    gazsiz1.Add(item);
                }
            }
            foreach (var item in icecek2)
            {
                if (item.Tagi == "gazsiz")
                {
                    gazsiz2.Add(item);
                }
            }
            lst1.ItemsSource = icecek1;
            lst2.ItemsSource = icecek2;
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
        private void suBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = su1;
            lst2.ItemsSource = su2;
        }
        private void gazliBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = gazli1;
            lst2.ItemsSource = gazli2;
        }
        private void gazsizBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = gazsiz1;
            lst2.ItemsSource = gazsiz2;
        }
        private async void icecek_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Icecek());
        }
        private async void meyve_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveVeSebze());
        }
    }
}