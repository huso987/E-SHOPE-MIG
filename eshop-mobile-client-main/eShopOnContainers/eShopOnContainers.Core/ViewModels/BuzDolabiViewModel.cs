using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class BuzDolabiViewModel
    {

        public ObservableCollection<Product> BuzDolabiListesi { get; set; }

        public BuzDolabiViewModel()
        {

            BuzDolabiListesi = new ObservableCollection<Product>()
            {
                new Product(63,5,"Vestel NFK 48001X","https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcRQTlq2pxDnlXZvxwM0Yiuq3JZKr2Y8pW2lvm9HSvtHkIgLV3CkiQJmc9pxx0ssUM4DHzjxE22gmRwhBVN7g1t6iQE5ffZXmJIVBhhr2qxszfjPAB0N9ox61A0&usqp=CAE",5000),
                new Product(64,5,"Vestel NF 45001","https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcS9SgP9NgfmJcfysSzYBFkm2jhIsShHi5lD4slEKI3TfMjL3fQnTGYRM8vep4y_q25-19P6-vXXQHoBLEJkurhrQIau4o1Virw0Dt5S-y8yNaySP4a3YCTkLOY&usqp=CAE",4500),
                new Product(65,5,"Arçelik 274580","https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcSWKuW-hvu6xL_cC5LZDobDGzA8igZ-ix-0fAgA5-CNHk8KvrnVTKFrDxZWxWTjxHDTHlHwJMFWEpInRpsJIdtFMzlLZ1VCe92wGgId9rO9OyVW2Mzxq57TVg&usqp=CAE",4350),
                new Product(66,5,"Vestel FRFD 6020","https://encrypted-tbn1.gstatic.com/shopping?q=tbn:ANd9GcRslYjIliQ3mn_ZjrptQtPdZ1iOizcc1kJ5Ey8L_qHjEq4weaAhbmEuCzh3Ch5l08oqN-k7-R5njKP6qZ7UWJwHRCkuTUbWmuHE-skv7NWMMJUav16kRppfMq8&usqp=CAE",5250),



            };



        }
    }
}
