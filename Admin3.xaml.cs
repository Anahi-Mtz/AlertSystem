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
    public partial class Admin3 : ContentPage
    {
        public Admin3()
        {
            InitializeComponent();
        }
        private async void BtnNewUser_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new Admin4()));

        }

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }
    }
}