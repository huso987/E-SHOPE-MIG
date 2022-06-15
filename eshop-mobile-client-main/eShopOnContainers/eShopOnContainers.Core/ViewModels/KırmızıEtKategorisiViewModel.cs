using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class KırmızıEtKategorisiViewModel
    {


        public ObservableCollection<Product> KırmızıEtListesi { get; set; }



        public KırmızıEtKategorisiViewModel()
        {
            KırmızıEtListesi = new ObservableCollection<Product>(){

                new Product(11,2,"Dana Bonfile (kg)","https://esenlik.com.tr/dana-bonfile-kg-p-2294.jpg",75),
                new Product(12,2,"Kuzu Kuşbaşı (kg)","https://esenlik.com.tr/kuzu-kusbasi-kg-p-2302.jpg",65),
                new Product(13,2,"Dana Kuşbaşı (kg)","https://www.tasomarket.com/files/products/dana-kusbasi-extra-kg.jpg",60),
                new Product(14,2,"Dana Kıyma (kg)" ,"https://www.etgros.com/wp-content/uploads/2020/05/2-2.jpg",96),

            };



        }


    }
}
