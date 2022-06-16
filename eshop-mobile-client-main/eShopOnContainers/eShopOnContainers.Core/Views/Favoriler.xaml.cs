using eShopOnContainers.Core.Models.Item;
using eShopOnContainers.Core.Services.Marketing;
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
    public partial class Favoriler : ContentPage
    {
        ProductService productService = new ProductService();
        public Favoriler()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var favoriteProductList = await productService.FavoridenÜrünleriGetir();
            favorilerdekiÜrünler.ItemsSource = favoriteProductList;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            Product selectedProduct = new Product();

            var button = (ImageButton)sender;
            var item = (Product)button.BindingContext;
            selectedProduct.Id = item.Id;
            await productService.FavoridenKaldır(selectedProduct.Id);
            var favoriteProductList = await productService.FavoridenÜrünleriGetir();
            favorilerdekiÜrünler.ItemsSource = favoriteProductList;


            // Model.favoriteList.Remove(item);

            await DisplayAlert("Uyarı", item.ProductName + " Favorilerden Silindi", "Tamam");
        }
    }
}