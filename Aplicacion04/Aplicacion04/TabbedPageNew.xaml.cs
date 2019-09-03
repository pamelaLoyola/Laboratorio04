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
    public partial class TabbedPageNew : TabbedPage
    {
        public TabbedPageNew()
        {
            InitializeComponent();
        }
    }
}