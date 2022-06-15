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
    public partial class Sepet : ContentPage
    {
        ProductService productService = new ProductService();
        public Sepet()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var productsFromBasket = await productService.GetAllProductFromBasket();
            sepettekiUrunler.ItemsSource = productsFromBasket;


        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            Product selectedProduct = new Product();
            var button = (ImageButton)sender;
            var item = (Product)button.BindingContext;

            selectedProduct.Id = item.Id;
            await productService.RemoveBasket(selectedProduct.Id);
            var productsFromBasket = await productService.GetAllProductFromBasket();
            sepettekiUrunler.ItemsSource = productsFromBasket;


            //Model.list.Remove(item);

            await DisplayAlert("Uyarı", item.ProductName + " Silindi", "Tamam");
        }
    }
}