using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inicio.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndexMainPage : TabbedPage
    {
        public IndexMainPage ()
        {
            InitializeComponent();
        }
    }
}