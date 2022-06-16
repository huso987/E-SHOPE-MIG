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
    public partial class DondurulmuşView : ContentPage
    {
        ProductService productService = new ProductService();
        public DondurulmuşView()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Product productToBasket = new Product();

            var item = sender as Button;
            var obj = item.BindingContext as Product;

            productToBasket.Id = obj.Id;
            productToBasket.CategoryId = obj.CategoryId;
            productToBasket.ProductName = obj.ProductName;
            productToBasket.ProductImageUrl = obj.ProductImageUrl;
            productToBasket.UnitPrice = obj.UnitPrice;

            await productService.SepeteEkle(productToBasket);

            await DisplayAlert("Uyarı", "Sepete Eklendi", "Tamam");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            Product productToFavorite = new Product();

            var item = sender as ImageButton;
            var obj = item.BindingContext as Product;

            productToFavorite.Id = obj.Id;
            productToFavorite.CategoryId = obj.CategoryId;
            productToFavorite.ProductName = obj.ProductName;
            productToFavorite.ProductImageUrl = obj.ProductImageUrl;
            productToFavorite.UnitPrice = obj.UnitPrice;

            await productService.FavoriyeEkle(productToFavorite);

            await DisplayAlert("Uyarı", "Favorilere Eklendi", "Tamam");
        }

        private void cayListesi_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}