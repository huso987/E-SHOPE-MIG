using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AtıştırmalıkViewModel
    {

        public INavigation Navigation { get; set; }
        public ICommand ÇikolataButton { get; set; }

        public ICommand BarButton { get; set; }

      
        public AtıştırmalıkViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.ÇikolataButton = new Command(async () => await MÇikolata());
            this.BarButton = new Command(async () => await MBar());
           

        }

        private async Task MÇikolata()
        {
            await Navigation.PushModalAsync(new ÇikolataView());
        }

        private async Task MBar()
        {
            await Navigation.PushModalAsync(new BarView());
        }

     

        
    }
}
