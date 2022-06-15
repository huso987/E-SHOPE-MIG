using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class İçecekViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand SuButtonu { get; set; }

        public ICommand GazlıİçecekButtonu { get; set; }

       

        public İçecekViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.SuButtonu = new Command(async () => await MSu());
            this.GazlıİçecekButtonu = new Command(async () => await MGazlıİçecek());
            

        }

      

        private async Task MGazlıİçecek()
        {
            await Navigation.PushModalAsync(new GazlıiçecekView());
        }

        private async Task MSu()
        {
            await Navigation.PushModalAsync(new SuView());
        }
    }
}
