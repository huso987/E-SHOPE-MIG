using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class HızlıYemekViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand MezeButton { get; set; }

        public ICommand DondurulmuşButton { get; set; }

        

        public HızlıYemekViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.MezeButton = new Command(async () => await MMeze());
            this.DondurulmuşButton = new Command(async () => await MDondurulmuş());
           


        }

       

        private async Task MDondurulmuş()
        {
            await Navigation.PushModalAsync(new CayView());
        }

        private async Task MMeze()
        {
            await Navigation.PushModalAsync(new SuView());
        }
    }
}
