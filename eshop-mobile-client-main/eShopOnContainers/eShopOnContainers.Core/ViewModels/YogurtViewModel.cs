using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class YogurtViewModel
    {


        public ObservableCollection<Product> YogurtListesi { get; set; }

        public YogurtViewModel()
        {

            YogurtListesi = new ObservableCollection<Product>()
            {
                new Product(19,3,"Sütaş Yoğurt","https://st2.myideasoft.com/idea/ad/25/myassets/products/686/sutas-kaymaksiz-yogurt-2-kg.jpg",8),
                new Product(20,3,"Mis Yoğurt","https://fiyatinedir.net/wp-content/uploads/2021/06/Sok-yogurt-fiyatlari.jpg",7),
                new Product(21,3,"Murat Yoğurt","https://muratsanalmarket.com/idoApi/doc/murat-yogurt-4500-gr-1575804357.jpg",8),
                new Product(22,3,"İçim Yoğurt","https://d2uiaykj5yb3c0.cloudfront.net/yunus/img/p/56735ff3-cd27-4b4d-85ee-7e547f48a537.jpg",9),



            };



        }
    }
}
