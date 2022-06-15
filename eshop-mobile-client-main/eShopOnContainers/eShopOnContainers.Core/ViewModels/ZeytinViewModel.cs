using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class ZeytinViewModel
    {

        public ObservableCollection<Product> ZeytinListesi { get; set; }

        public ZeytinViewModel()
        {

            ZeytinListesi = new ObservableCollection<Product>()
            {
                new Product(32,3,"Siyah Zeytin 500gr","https://productimages.hepsiburada.net/s/36/375/10534182682674.jpg",17),
                new Product(33,3,"Yeşil Zeytin 500gr","https://d2uiaykj5yb3c0.cloudfront.net/2agross/img/p/624f2113-55f3-4d55-b585-0b52b058f5e9.jpg",13),
                new Product(34,3,"Öncü Siyah Zeytin 900 gr","https://esenlik.com.tr/oncu-premium-siyah-zeytin-2xl-xl-181-230-1-kg-t-55216.jpg",26),
                new Product(35,3,"Cem Yeşil Zeytin 900gr","https://www.onurmarket.com/Uploads/UrunResimleri/buyuk/1131348-4b0b-0.jpg",33),



            };





        }

       


    }
}
