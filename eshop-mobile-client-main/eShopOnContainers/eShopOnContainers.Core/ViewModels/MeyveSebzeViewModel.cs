
using eShopOnContainers.Core.Views;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class MeyveSebzeViewModel
    {
        
        public INavigation Navigation { get; set; }
        public ICommand MeyveButtonu { get; set; }
       
        public ICommand SebzeButtonu { get; set; }

        public MeyveSebzeViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.MeyveButtonu = new Command(async () => await MMeyve());
            this.SebzeButtonu = new Command(async () => await MSebze());

        }

        private async Task MSebze()
        {
            await Navigation.PushModalAsync(new DenizMahsulleriKategorisiView());
        }

        private async Task MMeyve()
        {
            await Navigation.PushModalAsync(new KırmızıEtKategorisiView());
        }

        
    }
}
