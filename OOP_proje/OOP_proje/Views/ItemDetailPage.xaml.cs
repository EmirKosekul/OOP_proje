using OOP_proje.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OOP_proje.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}