using eShopOnContainers.Core.Models.Item;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.ViewModels
{
    public class TelefonViewModel
    {

        public ObservableCollection<Product> TelefonListesi { get; set; }

        public TelefonViewModel()
        {

            TelefonListesi = new ObservableCollection<Product>()
            {
                new Product(70,5,"Samsung Galaxy A13","https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcTIGE-ZAnAbEvtyAe9nA2SP-FQ5q63e-sENIOP9QErJx4XH4BEEUNJTW86fJLDErUO0FdBSP-B0JBGM_lOY7_XYqiTcOT5Z1xRFD52EsdWUG-ZLY-47Kx3Leg&usqp=CAE",5000),
                new Product(71,5,"Xiaomi Redmi 10","https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcSONTZE-H8w0Uqtm9syIt_Wqk44TAY7Sk9pnl5DRlZ5FiMiffMV66ydoBbY3RQEODVpKCW39lXhQHREH9xxOETqXf73m-XNtdS5vr-myyGYlMUMcFJ99GB3&usqp=CAE",6500),
                new Product(72,5,"Samsung Galaxy S20","https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQiFgGUMOpYOJaFaOwxebqSNhx6iFrOveRW5g4EJtYFhnXwMOziv-TXsaIdse_jVpC_6gaDHXonbS8hMwbfX568p-6R5UPh-H3kMaubotl8Rw0zxAoB1mo8YQ&usqp=CAE",5650),
                new Product(73,5,"Apple Iphone 13","https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcT1fwSNyEBuEKHKX2eZUexdfuE0FfHPcX3ggkoNTofv-jBQvYqWH3-mblVDSqp4i_MwVufMn32OnctuncULT7JvPoX3NUZoGZybaYcozTVfmhY24E5jWVuLkQ&usqp=CAE",7500),
                new Product(74,5,"Oppo A16","https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcTHkph4t1xuD3l3PDiYPidbtbUNwytcwAoeSboZD5RamuJqq0MPzj_hGdpX9JO0pSa8ZcLdVom6owniT2E9mDDjxbWIJoFy-TbnXKFagK06XhCW2lIqtBxUgg&usqp=CAE",7000),


            };



        }
    }
}
