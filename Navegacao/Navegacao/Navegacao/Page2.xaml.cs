using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Navegacao
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async public void onClickedBack(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async public void onClickedForward(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
