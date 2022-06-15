using eShopOnContainers.Core.Models;
using eShopOnContainers.Core.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eShopOnContainers.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Migrosev : ContentPage
    {
        ProductService productService = new ProductService();
        public Migrosev()
        {
           
            InitializeComponent();
            Sepet.list = new ObservableCollection<Product>();
            Beğeni.list = new ObservableCollection<Product>();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Product sepeteekle = new Product();
            var item = sender as Button;
            var obj = item.BindingContext as Product;
            Sepet.list.Add(obj);


            sepeteekle.ProductName = obj.ProductName;
            sepeteekle.ProductImageUrl = obj.ProductImageUrl;
            sepeteekle.UnitPrice = obj.UnitPrice;
            await productService.SepeteEkle(sepeteekle);

            await DisplayAlert("!!!", "Ürün Sepete Eklendi", "Tamam");
        }
    }
}