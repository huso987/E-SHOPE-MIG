using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class BulasikMakinesiViewModel
    {

        public ObservableCollection<Product> BulasikMakinesiListesi { get; set; }

        public BulasikMakinesiViewModel()
        {

            BulasikMakinesiListesi = new ObservableCollection<Product>()
            {
                new Product(66,5,"Arçelik 6133 A++","https://cdn.dsmcdn.com/ty119/product/media/images/20210524/15/91143060/94850917/1/1_org_zoom.jpg",5000),
                new Product(67,5,"Arçelik 6055 Uh","https://productimages.hepsiburada.net/s/55/1500/11220181909554.jpg",4500),
                new Product(68,5,"Bosh 2500 A++","http://mobileimages.lowes.com/productimages/24fb77f6-5f2a-4c33-ac89-3918c6ac4f93/09361483.jpg",4350),
                new Product(69,5,"Vestel BM-511","https://productimages.hepsiburada.net/s/47/375/10904367693874.jpg",5250),



            };



        }

    }
}
