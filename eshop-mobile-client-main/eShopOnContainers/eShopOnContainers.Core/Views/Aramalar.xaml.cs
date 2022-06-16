using eShopOnContainers.Core.Models.Item;
using eShopOnContainers.Core.Services.Marketing;
using eShopOnContainers.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aramalar : ContentPage
    {
        ProductService productService = new ProductService();
        public Aramalar()
        {
            InitializeComponent();
            BindingContext = new AramalarViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var urunler = await productService.UrünleriGetir();
            urunListesi.ItemsSource = urunler;
        }

        private async void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            var urunler = productService.UrünleriGetir();

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                urunListesi.ItemsSource = await urunler;
            }

            else
            {
                List<Product> searchResult = (from urun in await urunler where urun.ProductName.ToLower().Contains(e.NewTextValue.ToLower()) select urun).ToList();
                urunListesi.ItemsSource = searchResult;
            }

        }
    }
}