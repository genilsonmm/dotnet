namespace MeuApp;

public partial class Detalhes : ContentPage
{
	public Detalhes(string texto)
	{
		InitializeComponent();

        entNome.Text = texto;
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();	
    }

    private async void btnAlert_Clicked(object sender, EventArgs e)
    {
        string nome = entNome.Text;



        await DisplayAlert("Aviso", nome, "Ok");

       
    }
}