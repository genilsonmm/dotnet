using MeuApp.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MeuApp;

public partial class Listagem : ContentPage
{
	ObservableCollection<User> users = new ObservableCollection<User>();

	public Listagem()
	{
		InitializeComponent();

        lstListagem.ItemsSource = users;

		// users.Add(new User() { Login = "Fulano", Avatar_url = "https://avatars.githubusercontent.com/u/1?v=4" });
		GetItems();
	}

	public async void GetItems()
	{
		var httpClient = new HttpClient();
		string uri = "https://api.github.com/users";

		using var response = await httpClient.GetAsync(uri);

		var json = await response.Content.ReadAsStringAsync();

		List<User> objs = JsonConvert.DeserializeObject<List<User>>(json);

		objs.ForEach(x => users.Add(x));
    }
}