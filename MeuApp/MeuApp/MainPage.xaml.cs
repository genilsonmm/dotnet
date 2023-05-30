namespace MeuApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();


		entNome.Text = "Ola MAUI";
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
	}

    private async void btnNavegar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Detalhes("Olá eu venho de MainPage"));
    }

    private async void btnListagem_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Listagem());
    }
}

