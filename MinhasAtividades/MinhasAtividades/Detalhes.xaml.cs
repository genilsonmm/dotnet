using MinhasAtividades.Model;

namespace MinhasAtividades;

public partial class Detalhes : ContentPage
{
	public Detalhes(Atividade atividade)
	{
		InitializeComponent();
        lblDesc.Text = atividade.Descricao;
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}