using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class BebekSampuaniViewModel
    {

        public ObservableCollection<Product> BebekSampuaniListesi { get; set; }

        public BebekSampuaniViewModel()
        {

            BebekSampuaniListesi = new ObservableCollection<Product>()
            {
                new Product(80,6,"Johnson's Baby Şampuanı","https://www.onurmarket.com/Uploads/UrunResimleri/buyuk/1111238-ae-44b.jpg",15),
                new Product(81,6,"Dalin Baby Şampuanı","https://st.myideasoft.com/idea/ad/25/myassets/products/609/10503870677042.jpeg?revision=1594045980",20),
                new Product(82,6,"Agarta Baby Şampuanı","http://www.helalsitesi.com/Uploads/UrunResimleri/buyuk/agarta-dogal-bebek-sampuani---400-ml-937d.jpeg",13),
                new Product(83,6,"Aroma Baby Şampuanı","https://www.eurofoodemarket.com/wp-content/uploads/2021/05/AROM093-600x600.jpg",30),


            };



        }
    }
}
