namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		entNome.Text = "Sou um texto do c#";
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		string nome = entNome.Text;

		DisplayAlert("Dialog", nome, "Ok");


    }
}

