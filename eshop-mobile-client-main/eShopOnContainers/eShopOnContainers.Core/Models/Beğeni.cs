using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eShopOnContainers.Core.Models
{
    public class Beğeni
    {
        static public ObservableCollection<Product> list { get; set; }
        public static List<Product> ItemsSource { get; internal set; }
    }
}
