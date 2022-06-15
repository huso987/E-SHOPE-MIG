using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class DondurulmuşViewModel
    {

        public ObservableCollection<Product> DondurulmuşListesi { get; set; }

        public DondurulmuşViewModel()
        {
            DondurulmuşListesi = new ObservableCollection<Product>()
            {
                new Product(43,4,"Superfresh 7/24 Fırından Simit 400 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17990281/17990281-ec6369.jpg",20),
                new Product(44,4,"Feast Parmak Patates 1 Kg","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014542/17014542-c95e7e.jpg",25),
                new Product(45,4,"Feast Bezelye 450 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014576/17014576-1a72de.jpg",20),
                new Product(46,4,"Superfresh Patates Kroket 450 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011078/17011078-2dd87a.jpg",30),

            };

        }

    }
}
