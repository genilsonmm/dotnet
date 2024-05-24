using Android.App;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            txtName.Text = "Qual coisa!";
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void btnMsg_Clicked(object sender, EventArgs e)
        {
            string nome = txtName.Text;

            await DisplayAlert("Aviso", nome, "Ok");
        }
    }

}
