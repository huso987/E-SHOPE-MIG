using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class SıcakTazeYemekViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand MigrosEvLez { get; set; }
        public ICommand PizzaMiG { get; set; }

        public SıcakTazeYemekViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.MigrosEvLez = new Command(async () => await MMigrosEvLez());
            this.PizzaMiG = new Command(async () => await MPizzaMiG());
        }

        private async Task MPizzaMiG()
        {
            await Navigation.PushModalAsync(new SebzeView());
        }

        private async Task MMigrosEvLez()
        {
           await Navigation.PushModalAsync(new MeyveView());
        }
    }
}
