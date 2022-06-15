using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class KolaViewModel
    {

        public ObservableCollection<Product> KolaListesi { get; set; }

        public KolaViewModel()
        {

            KolaListesi = new ObservableCollection<Product>()
            {

                new Product(56,4,"Coca Cola 2.5L","https://cdn.dsmcdn.com/ty27/product/media/images/20201127/18/33097970/58233893/1/1_org_zoom.jpg",15),
                new Product(57,4,"Pepsi 2L","https://ayb.akinoncdn.com/products/2019/10/01/3536/ef938965-51b4-49fc-bcec-065fa92ad245.jpg",13),
                new Product(58,4,"Cola Turka 1.5","http://www.altunbilekler.com/Uploads/UrunResimleri/buyuk/cola-turka-25-lt-3973.jpg",14),
                new Product(59,4,"Coca Cola 330mL","https://www.gulyurt.com.tr/yuklemeler/2021/01/60ba5836e4754_coca-cola330.jpg",6),


            };
        }
    }
}
