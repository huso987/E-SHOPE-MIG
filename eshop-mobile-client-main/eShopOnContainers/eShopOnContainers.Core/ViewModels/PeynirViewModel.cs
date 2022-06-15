using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    internal class PeynirViewModel
    {

        public ObservableCollection<Product> PeynirListesi { get; set; }

        public PeynirViewModel()
        {

            PeynirListesi = new ObservableCollection<Product>()
            {
                new Product(28,3,"İçim Peynir 300gr","https://www.kalemarketleri.com/Uploads/UrunResimleri/buyuk/icim-beyaz-peynir-500-grpeynirler-8061.jpg",24),
                new Product(29,3,"Ekici Peynir 300gr","https://www.iyas.com.tr/images/thumbs/0001029_ekici-tam-yagli-klasik-beyaz-peynir-300gr_510.jpg",26),
                new Product(30,3,"Sütaş Peynir 350gr","https://st2.myideasoft.com/idea/if/83/myassets/products/165/sm-urun-gorselleri-peynirler-320300-beyaz-peynir-700g.jpg",20),
                new Product(31,3,"Muratbey Misto Peynir 200gr","https://d2uiaykj5yb3c0.cloudfront.net/snowy/img/p/37641c21-815b-49a9-8580-2acb5a1f1934.jpg",26),



            };



        }
    }
}
