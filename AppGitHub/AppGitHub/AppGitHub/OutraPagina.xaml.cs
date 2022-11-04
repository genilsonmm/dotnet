using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGitHub
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutraPagina : ContentPage
    {
        public OutraPagina(string texto)
        {
            InitializeComponent();

            lblText.Text = texto;
            Title = "Outra página";
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}