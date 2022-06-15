using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class PizzaMiGViewModel
    {

        public ObservableCollection<Product> PizzaListesi { get; set; }

        

        public PizzaMiGViewModel()
        {


            PizzaListesi = new ObservableCollection<Product>()
            {
                new Product(1,1,"Pizza Mi-go Jambon - Chedarlı 520G Dondurulmuş Yeni","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060618/05060618-9d28cb.jpg",17),
                new Product(2,1,"Pizza Mi-go Karışık Pizza 545G Dondurulmuş (Yeni)","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060619/05060619-89c102.jpg",20),
                new Product(3,1,"Pizza Mi-go Peynirli Pizza 475G Dondurulmuş Yeni","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060617/05060617-8b497e.jpg",13),
                



            };
        }




        




    }
}
