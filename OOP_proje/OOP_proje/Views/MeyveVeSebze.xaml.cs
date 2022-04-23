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
    public partial class MeyveVeSebze : ContentPage
    {
        List<MeyveVeSebzeNesne> meyveVeSebze1;
        List<MeyveVeSebzeNesne> meyveVeSebze2;
        List<MeyveVeSebzeNesne> meyve1 = new List<MeyveVeSebzeNesne> { };
        List<MeyveVeSebzeNesne> meyve2 = new List<MeyveVeSebzeNesne> { };
        List<MeyveVeSebzeNesne> sebze1 = new List<MeyveVeSebzeNesne> { };
        List<MeyveVeSebzeNesne> sebze2 = new List<MeyveVeSebzeNesne> { };
        List<MeyveVeSebzeNesne> yesillik1 = new List<MeyveVeSebzeNesne> { };
        List<MeyveVeSebzeNesne> yesillik2 = new List<MeyveVeSebzeNesne> { };
        public MeyveVeSebze()
        {
            InitializeComponent();
            meyveVeSebze1 = new List<MeyveVeSebzeNesne> {
             new MeyveVeSebzeNesne{Adi="Domates", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Sebze" , Navigationpage="Domates"},
             new MeyveVeSebzeNesne{Adi="Soğan", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Sebze"},
             new MeyveVeSebzeNesne{Adi="Portakal", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Meyve",Navigationpage="Portakal"},             
             new MeyveVeSebzeNesne{Adi="Maydonoz", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Yeşillik"},
            };
            meyveVeSebze2 = new List<MeyveVeSebzeNesne> {
            new MeyveVeSebzeNesne{Adi="Salatalık", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Sebze"},
             new MeyveVeSebzeNesne{Adi="Kıvırcık", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Yeşillik"},
             new MeyveVeSebzeNesne{Adi="Nane", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Yeşillik"},
             new MeyveVeSebzeNesne{Adi="Muz", Fiyati=19.5, Resimi="Domates.jpg", Tagi="Meyve" }
            };
            meyve1 = new List<MeyveVeSebzeNesne> { };
            meyve2 = new List<MeyveVeSebzeNesne> { };
            sebze1 = new List<MeyveVeSebzeNesne> { };
            sebze2 = new List<MeyveVeSebzeNesne> { };
            yesillik1 = new List<MeyveVeSebzeNesne> { };
            yesillik2 = new List<MeyveVeSebzeNesne> { };

            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Meyve")
                {
                    meyve1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Meyve")
                {
                    meyve2.Add(item);
                }
            }
            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Sebze")
                {
                    sebze1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Sebze")
                {
                    sebze2.Add(item);
                }
            }
            foreach (var item in meyveVeSebze1)
            {
                if (item.Tagi == "Yeşillik")
                {
                    yesillik1.Add(item);
                }
            }
            foreach (var item in meyveVeSebze2)
            {
                if (item.Tagi == "Yeşillik")
                {
                    yesillik2.Add(item);
                }
            }
            lst1.ItemsSource = meyveVeSebze1;
            lst2.ItemsSource = meyveVeSebze2;
        }
        private void meyveBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = meyve1;
            lst2.ItemsSource = meyve2;
        }
        private void sebzeBtn_Clicked(object sender, EventArgs e/*,List<MeyveVeSebzeNesne> sbz1, List<MeyveVeSebzeNesne> sbz2*/)
        {
            lst1.ItemsSource = sebze1;
            lst2.ItemsSource = sebze2;
        }
        private void yesillikBtn_Clicked(object sender, EventArgs e)
        {
            lst1.ItemsSource = yesillik1;
            lst2.ItemsSource = yesillik2;
        }

        private void lst1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if(e.Item==null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as MeyveVeSebzeNesne));
        }
        private void lst2_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            Navigation.PushModalAsync(new DetailPage(e.Item as MeyveVeSebzeNesne));
        }

        private  async void mvs_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeyveVeSebze());
        }
    }
}