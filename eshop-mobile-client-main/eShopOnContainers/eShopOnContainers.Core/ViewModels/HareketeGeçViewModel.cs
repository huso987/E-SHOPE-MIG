using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class HareketeGeçViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand SağlıkTakviyeleri { get; set; }

        public ICommand Sporcuİçecegi { get; set; }

       


        public HareketeGeçViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.SağlıkTakviyeleri = new Command(async () => await MsağlıkTakviye());
            this.Sporcuİçecegi = new Command(async () => await MSporcuİçecegi());
            
        }

       
        private async Task MSporcuİçecegi()
        {
            await Navigation.PushModalAsync(new Sporcuİç());
        }

        private async Task MsağlıkTakviye()
        {
            await Navigation.PushModalAsync(new sağlıktakviyeView());
        }
    }
}
