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
    public partial class Admin4 : ContentPage
    {
        public Admin4()
        {
            InitializeComponent();
        }

        private async void BtnSave_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Admin3()));

        }

        private async void BtnSelection_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Admin5()));

        }

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }
    }
}