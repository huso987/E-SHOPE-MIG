using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SağlıkTakviyeleriViewModel
    {
        public ObservableCollection<Product> TakviyeList { get; set; }

        public SağlıkTakviyeleriViewModel()
        {

            TakviyeList = new ObservableCollection<Product>()
            {
                new Product(88,6,"Ülker Pastil Ihlamur Limon Propolis 8 Adet 22.4 G","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511177/34511177-d72aa9.jpg",88),
                new Product(89,6,"Önce D3 Vitamini 30 Kapsül","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511137/34511137-809eb0.jpg",75),
                new Product(90,6,"One Up Multivitamin 30 Bitkisel Kapsül","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511124/34511124-037d5b.jpg",80),
                new Product(91,6,"Önce Çörek Otu Yağı 30 Kapsül","https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511131/34511131-32e45d.jpg",65),



            };



        }
    }
}
