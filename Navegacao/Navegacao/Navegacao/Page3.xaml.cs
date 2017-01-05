using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Navegacao
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        async public void onClickedBack(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async public void onClickedBegin(Object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        async public void onClickedTabbed(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        async public void onClickedCarousel(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page8());
        }
    }
}
