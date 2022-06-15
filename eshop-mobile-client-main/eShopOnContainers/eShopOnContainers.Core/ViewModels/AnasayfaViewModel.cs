using eShopOnContainers.Core.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eShopOnContainers.Core.ViewModels
{
    public class AnasayfaViewModel
    {

        
          

        public INavigation Navigation { get; set; }
        public ICommand SıcakTazeYemek { get; set; }

        public ICommand MeyveSebze { get; set; }

        public ICommand Atıştırmalık { get; set; }

        public ICommand HızlıYemek { get; set; }

        public ICommand İçecek { get; set; }
        public ICommand HareketeGeç { get; set; }
        
        public List<string> SliderList = new List<string>()
        {

                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25112/27146-_hemenramazan_3420x900-72190d.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25392/27426-web_hemen_meyvesebze-f6faca.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/21710/23744-791_hemen_web_banner_ucretsiz_teslimat-4518f1.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/20901/22935-784_hemen_web_slider_20_tl_indirim(1)-b98bf3.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25857/27891-web_oyuncak_badgeli-9aa24e.png"
        };
    

    public AnasayfaViewModel(INavigation navigation)
        {

            this.Navigation = navigation;
            this.SıcakTazeYemek = new Command(async () => await MSıcakTAzeYemek());
            this.MeyveSebze = new Command(async () => await MMeyveSebze());
            this.Atıştırmalık = new Command(async () => await MAtıştırmalık());
            this.HızlıYemek = new Command(async () => await MHızlıYemek());
            this.İçecek = new Command(async () => await Mİçecek());
            this.HareketeGeç = new Command(async () => await MHareketeGeç());
        }

        private async Task MSıcakTAzeYemek()
        {
            await Navigation.PushModalAsync(new SıcakTazeYemek());
        }

        private async Task MMeyveSebze()
        {
            await Navigation.PushModalAsync(new MeyveSebze());
        }

        private async Task MAtıştırmalık()
        {
            await Navigation.PushModalAsync(new Atıştırmalık());
        }

        private async Task MHızlıYemek()
        {
            await Navigation.PushModalAsync(new HızlıYemek());
        }

        private async Task Mİçecek()
        {
            await Navigation.PushModalAsync(new İçecek());
        }

        private async Task MHareketeGeç()
        {
            await Navigation.PushModalAsync(new HareketeGeç());
        }
    }

}
