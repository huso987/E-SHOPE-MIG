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
        public ICommand BebekBeziButonu { get; set; }

        public ICommand IslakHavluButonu { get; set; }

        public ICommand BebekSampuaniButonu { get; set; }


        public HareketeGeçViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.BebekBeziButonu = new Command(async () => await MoveToBebekBezi());
            this.IslakHavluButonu = new Command(async () => await MoveToIslakHavlu());
            this.BebekSampuaniButonu = new Command(async () => await MoveToBebekSampuani());
        }

        private async Task MoveToBebekSampuani()
        {
            await Navigation.PushModalAsync(new BebekSampuaniView());
        }

        private async Task MoveToIslakHavlu()
        {
            await Navigation.PushModalAsync(new IslakHavluView());
        }

        private async Task MoveToBebekBezi()
        {
            await Navigation.PushModalAsync(new BebekBeziView());
        }
    }
}
