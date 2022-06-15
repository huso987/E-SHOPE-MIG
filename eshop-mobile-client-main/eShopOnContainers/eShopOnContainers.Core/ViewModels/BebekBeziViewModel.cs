using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class BebekBeziViewModel
    {
        public ObservableCollection<Product> BebekBeziListesi { get; set; }

        public BebekBeziViewModel()
        {

            BebekBeziListesi = new ObservableCollection<Product>()
            {
                new Product(88,6,"Prima Bebek Bezi","https://img-morhipo.mncdn.com/mnresize/1200/1645/productimages/ii/8001841610917/[img][5][1].jpg?1044",88),
                new Product(89,6,"Molfix Bebek Bezi","https://www.imcmarket.com/resimler/29092020211737.jpeg",75),
                new Product(90,6,"Canbebe Bebek Bezi","https://www.onurmarket.com/Uploads/UrunResimleri/buyuk/1118524-a-49b6.jpg",80),
                new Product(91,6,"Sleepy Bebek Bezi","http://www.iyas.com.tr/images/thumbs/0003617_sleepy-natural-jumbo-bebek-bezi-junior-plus-5-13-20-kg-22-adet_510.jpg",65),



            };



        }
    }
}
