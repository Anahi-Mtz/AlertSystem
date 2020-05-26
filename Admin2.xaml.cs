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
    public partial class Admin2 : ContentPage
    {

        // lo borras en un momento solo es para prueba 
        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Green", Color.Green },
            { "Gray", Color.Gray }, { "Red", Color.Red }
        };

        /*private int selectedIndex;
        private object picker;
        private object MainPicker;*/

        public Admin2()
        {
            /*InitializeComponent();
            var areasList = new List<string>();
            areasList.Add("Metrology 1");
            areasList.Add("Metrology 2");
            areasList.Add("Server Room 1");
            areasList.Add("Server Room 2");
            areasList.Add("Server Room 3");
          

            var Picker = new Picker { Title = "Select an Area", TitleColor = Color.Blue };
            picker.ItemsSource = areasList;

            DisplayAlert(areasList, "Select value", "Acept");*/

            Label header = new Label
            {
                Text = "Picker",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Picker picker = new Picker
            {
                Title = "Color",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string colorName in nameToColor.Keys)
            {
                picker.Items.Add(colorName);
            }

            // Create BoxView for displaying picked Color
            BoxView boxView = new BoxView
            {
                WidthRequest = 150,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            picker.SelectedIndexChanged += (sender, args) =>
            {
                if (picker.SelectedIndex == -1)
                {
                    boxView.Color = Color.Default;
                }
                else
                {
                    string colorName = picker.Items[picker.SelectedIndex];
                    boxView.Color = nameToColor[colorName];
                }
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    header,
                    picker,
                    boxView
                }
            };

        }

        

        private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }

      
    }
}
