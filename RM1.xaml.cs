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
    public partial class RM1 : ContentPage
    {
        public RM1()
        {
            InitializeComponent();
        }

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }
    }
}