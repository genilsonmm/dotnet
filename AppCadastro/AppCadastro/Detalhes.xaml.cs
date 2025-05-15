using AppCadastro.Model;

namespace AppCadastro;

public partial class Detalhes : ContentPage
{
	public Detalhes(Usuario usuario)
	{
		InitializeComponent();
		
		lblNome.Text = usuario.Nome;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}