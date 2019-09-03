using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageNew : CarouselPage
    {
        public CarouselPageNew()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}