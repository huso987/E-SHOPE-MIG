using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class SuViewModel
    {

        public ObservableCollection<Product> SuListesi { get; set; }

        public SuViewModel()
        {

            SuListesi = new ObservableCollection<Product>()
            {
                new Product(47,4,"Erikli Su 0,5L","https://migros-dali-storage-prod.global.ssl.fastly.net/sanalmarket/product/08062201/08062201-3aa86b-1650x1650.jpg",2),
                new Product(48,4,"Sırma Su 0,5L","https://cdn.dsmcdn.com/ty16/product/media/images/20210331/17/76733924/22288351/1/1_org_zoom.jpg",3),
                new Product(49,4,"Hayat Su 0,5L","https://d2uiaykj5yb3c0.cloudfront.net/bravo/img/p/0f5e70d8-4fb8-4ed7-b96f-02e62311394a.jpg",2),
                new Product(50,4,"Gümüş Su 0,5L","https://www.imcmarket.com/resimler/12082021122450.jpg",3),
                new Product(51,4,"Nazlı Su 0,5L","https://cdn.dsmcdn.com/ty262/product/media/images/20211203/20/3747114/328425643/1/1_org_zoom.jpg",2),



            };



        }
    }
}
