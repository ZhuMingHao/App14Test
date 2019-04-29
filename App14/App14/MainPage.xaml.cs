using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App14
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
          
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
             await Browser.OpenAsync(new Uri("file:///C:/Users/v-zhumin/Desktop/hello.txt"), BrowserLaunchMode.External);
      //   var ss =   await DependencyService.Get<IFileLauncher>().LaunchFileAsync("D:\\Key.pdf");
        }
    }
}
