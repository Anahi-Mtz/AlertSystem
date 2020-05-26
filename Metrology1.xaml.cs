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
    public partial class Metrology1 : TabbedPage
    {
        public Metrology1()
        {
            InitializeComponent();

            Children.Add(new M1());
            Children.Add(new RM1());
        }
    }
}