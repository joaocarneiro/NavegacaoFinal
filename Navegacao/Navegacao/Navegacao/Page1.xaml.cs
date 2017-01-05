using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Navegacao
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async public void onClicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}
