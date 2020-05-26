using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlertSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin1 : ContentPage
    {
        public Admin1()
        {
            InitializeComponent();
        }
        private async void BtnAreas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Admin2()));

        }

        private async void BtnUsers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Admin3()));

        }

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }
    }
}